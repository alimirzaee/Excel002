using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Excel002.Data;
using Excel002.Models;

namespace Excel002.Controllers
{
    public class InvoiceItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvoiceItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InvoiceItems
        public  IActionResult Index(int? CityId, int? ProductId, int? CustomerId, String CityName, String CustomerName, String ProductName)
        {

            var result = _context.InvoiceItem.AsQueryable();

            if ( CityId!= null && CityId > 0 )            
                result = result.Where(e => e.city.Equals(CityId));
          

            if (ProductId != null && ProductId > 0)            
                result = result.Where(e => e.ProductId.Equals(ProductId));


            if (CustomerId != null && CustomerId > 0)
                result = result.Where(e => e.CustomerId.Equals(CustomerId));


            ViewBag.CityId = CityId;
            ViewBag.ProductId = ProductId;
            ViewBag.CustomerId = CustomerId;


            ViewBag.CityName = CityName;
            ViewBag.CustomerName = CustomerName;
            ViewBag.ProductName = ProductName;







            /// var applicationDbContext = _context.InvoiceItem.OrderByDescending(e=>e.Id).Take(20).Include(i => i.city).Include(i => i.customer).Include(p=>p.product);
            return View(result.Take(20).Include(i => i.city).Include(i => i.customer).Include(p => p.product));
        }

        // GET: InvoiceItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceItem = await _context.InvoiceItem
                .Include(i => i.city)
                .Include(i => i.customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoiceItem == null)
            {
                return NotFound();
            }

            return View(invoiceItem);
        }

        // GET: InvoiceItems/Create
        public IActionResult Create()
        {
            AddInvoiceModel model = new AddInvoiceModel();
           /// ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id");
          ///  ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            return View(model);
        }

        // POST: InvoiceItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CityId,CustomerId,ProductId,CityName,CustomerName,ProductName,Price")] AddInvoiceModel invoiceItem)
        {
            Boolean err = !ModelState.IsValid;
            Boolean priceIsInRange;
            var maxPrice = _context.InvoiceItem.Where(e => e.ProductId == invoiceItem.ProductId).Max(p => p.Price);
            priceIsInRange = invoiceItem.Price <= (maxPrice + (maxPrice * 15 / 100));
            

            if (ModelState.IsValid && priceIsInRange)
            {
                 
                InvoiceItem iv = new InvoiceItem
                {
                    CityId = invoiceItem.CityId,
                    CustomerId = invoiceItem.CustomerId,
                    ProductId = invoiceItem.ProductId,
                    Price = invoiceItem.Price
                };
                _context.Add(iv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            if (!priceIsInRange)
                ViewBag.PriceNotInRangeError = "Price is bigger than max price in DB";

            return View(invoiceItem);
        }

        // GET: InvoiceItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceItem = await _context.InvoiceItem.FindAsync(id);
            if (invoiceItem == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", invoiceItem.CityId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", invoiceItem.CustomerId);
            return View(invoiceItem);
        }

        // POST: InvoiceItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CityId,CustomerId,ProductId,Price")] InvoiceItem invoiceItem)
        {
            if (id != invoiceItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoiceItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceItemExists(invoiceItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", invoiceItem.CityId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", invoiceItem.CustomerId);
            return View(invoiceItem);
        }

        // GET: InvoiceItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceItem = await _context.InvoiceItem
                .Include(i => i.city)
                .Include(i => i.customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoiceItem == null)
            {
                return NotFound();
            }

            return View(invoiceItem);
        }

        // POST: InvoiceItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoiceItem = await _context.InvoiceItem.FindAsync(id);
            _context.InvoiceItem.Remove(invoiceItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceItemExists(int id)
        {
            return _context.InvoiceItem.Any(e => e.Id == id);
        }


        public IActionResult AddInvoice()
        {
            return View();
        }


         



    }
}
