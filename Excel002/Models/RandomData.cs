using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excel002.Models
{


    public class InvoiceItemShow
    {
       
        public String city { get; set; }
       
        public String customer { get; set; }
 
        public String product { get; set; }
        public String productCode { get; set; }
        public float Price { get; set; }




    }

    public class RandomData
    {

       static String[] Names = { "علی", "رضا", "محمد", "حسن", "حسین", "کریم", "هوشنگ", "باقر", "جواد", "رسول", "آیدین", "آرش", "آروین", "بردیا", "رکسانا", " یوسف", "فرید", "قاسم", "غلام", "گلناز", "وحید" };

      static  String[] Families = { "علوی", "رضایی", "محمدزاده", "حسنی", "حسین پور", "کرامت", "راد", "رحمتی", "جانباز", "راعی", "رستمی", "کمانگیر", "سپهراد", "پورمحمود", "شیری", "آبادی", "فرهادی", "قنبری", "غلامزاده", "گلستان", "وصال" };

     static String[] Products = { "جاروبرقی", "تلویزیون", "یخچال", "اجاق گاز", "میز", "مبل", "بوفه", "کاسه", "بشقاب", "تختخواب", "چنگال", "قاشق", "کمد", "فرش", "آویز", "شارژر", "قندان", "کتاب", "قلم", "فن", "توپ" };
        static String[] ProductCodes = { "001", "002", "002", "003", "004", "005", "006", "007", "008", "009", "010", "011", "012", "013", "014", "015", "016", "017", "018", "019", "020" };
        static int[] ProductFees = { 1500000, 4000000, 10000000, 3800000, 900000, 4200000, 1600000, 10000, 6000, 3000000, 5000, 6000, 1350000, 1780000, 25000, 30000, 5500, 35000, 4500, 6000,12000 };

        public static String[] Cities = { "تهران", "مشهد", "ارومیه", "تبریز", "اصفهان", "شیراز", "سنندج", "کرمانشاه", "بندرعباس", "یزد", "کرمان", "اراک", "کرج", "آباده", "قم", "رشت", "ساری", "قزوین", "مرند", "ماکو", "شبستر" };

public static InvoiceItemShow generateRandomItem()
        {
            InvoiceItemShow it = new InvoiceItemShow();
            var rnd = new Random();
            it.city = Cities[ rnd.Next(0,Cities.Length)];
            it.customer = Names[rnd.Next(0, Names.Length)] + ' ' + Families[rnd.Next(0, Families.Length)];

            int gid = rnd.Next(0, Products.Length);
            it.product = Products[gid];
            it.productCode = ProductCodes[gid];

            it.Price = ProductFees[gid] + (rnd.Next(-10, 10) * ProductFees[gid]) / 10;
            return it;
        }

    }
}
