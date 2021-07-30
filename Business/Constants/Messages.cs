using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "sistem bakimda";
        public static string ProductsListed = "urunler listelendi";
        public static string ProductCountOfCategoryError = "Kategori altindaki uru sayisi 10 u askin";
        public static string ProductNameAlreadyExists = "Bu isimde baska bir urun var";

        public static string CategoryLimitExceded = "kategori asildi";
    }
}
