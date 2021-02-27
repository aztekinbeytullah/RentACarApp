using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Message
    {
        public static string InsertSuccess = "Ekleme İşlemi Başarılı.";
        public static string DeleteSuccess = "Silme İşlemi Başarılı.";
        public static string UpdateSuccess = "Güncelleme İşlemi Başarılı.";
        public static string InsertError = "Ekleme İşlemi Başarısız.";
        public static string DeleteError = "Silme İşlemi Başarısız.";
        public static string UpdateError = "Güncelleme İşlemi Başarısız.";
        public static string Listed = "Talep Listelendi.";
        public static string GeneralError="Hata Oluştu";
        public static string GeneralSuccess = "İşlem Başarıyla Sonuçlandı";
        public static string ThisCarIsNotRental="Bu araç kiralanamaz";
        internal static string DailyPriceUnderMinPrice="Günlük kiralama bedeli belirlenen bedelin altında";
    }
}
