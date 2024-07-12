using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //puplic değişkenler büyük harf ile başlar
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsList = "Ürünler listelendi";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün mevuct";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string ProductCountOfCategoryError = "Aynı kategoride 15 ten fazla ürün olamaz";
    }
}