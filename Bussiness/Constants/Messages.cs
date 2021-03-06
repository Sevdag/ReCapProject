﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bussiness.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarListed= "Arabalar listelendi";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorListed = "Ürünlerin rengi listelendi";
        public static string ColorDeleted = "Ürünün rengi başarıyla silindi.";
        public static string ColorUpdated = "Ürünün rengi başarıyla güncellendi.";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";

        public static string RentalAdded = "Kiralama işlemi gerçekleşti";
        public static string InvalidRent= "Bu araba listede yok";
        public static string RentalListed = "Arabalar listelendi";
        public static string RentalDeleted = "Kiraladığınız araba başarıyla silindi.";
        public static string RentalUpdated = "Kiraladığınız araba başarıyla güncellendi.";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi.";

        public static string ImageAdded = "resim eklendi";
        public static string CarImageOutOfLimit ="Resim limitine erişildi!";
        public static string ImageDeleted="Resim silindi";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";
        public static string UserNotFound= "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
