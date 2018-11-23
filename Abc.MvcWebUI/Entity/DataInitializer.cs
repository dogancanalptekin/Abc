using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera ürünleri"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar ürünleri"},
                new Category(){Name="Elektronik",Description="Elektronik ürünleri"},
                new Category(){Name="Telefon",Description="Telefon ürünleri"},
                new Category(){Name="Beyaz Eşya",Description="Beyaz Eşya ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() {Name="Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",Description="Profesyonel Dijital Fotoğraf Makinesi",Price=1200,Stock=100,IsApproved=false,CategoryId=1,IsHome=true,Image = "3.jpg"},
                new Product() {Name="Canon Eos 100D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",Description="Profesyonel Dijital Fotoğraf Makinesi",Price=1000,Stock=250,IsApproved=true,CategoryId=1,IsHome=true,Image = "2.jpg"},
                new Product() {Name="Canon Eos 700D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",Description="Profesyonel Dijital Fotoğraf Makinesi",Price=900,Stock=70,IsApproved=true,CategoryId=1,IsHome=false,Image = "1.jpg"},
                new Product() {Name="Canon Eos 100D 18-55 mm IS STM Kit DSLR Fotoğraf Makinesi",Description="Profesyonel Dijital Fotoğraf Makinesi",Price=2000,Stock=180,IsApproved=false,CategoryId=1,IsHome=true,Image = "4.jpg"},
                new Product() {Name="Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description="Profesyonel Dijital Fotoğraf Makinesi Set",Price=2500,Stock=300,IsApproved=true,CategoryId=1,IsHome=true,Image = "5.jpg"},

                new Product() {Name="Dell Inspiron 3567 Intel Core i5 7200U 4GB 1TB R5 M430 Freedos ",Description="Taşınabilir Bilgisayar",Price=3000,Stock=100,IsApproved=true,CategoryId=2,IsHome=false,Image = "1.jpg"},
                new Product() {Name="Lenovo Legion Y520-15IKBN Intel Core i7 7700HQ 16GB 1TB + 128GB SSD GTX1050Ti Freedos 15.6",Description="PTaşınabilir Bilgisayar",Price=7000,Stock=150,IsApproved=true,CategoryId=2,IsHome=true,Image = "2.jpg"},
                new Product() {Name="Asus X542UR-GQ434 Intel Core i5 8250U 4GB 1TB GT930MX",Description="PTaşınabilir Bilgisayar",Price=3200,Stock=100,IsApproved=true,CategoryId=2,IsHome=false,Image = "3.jpg"},
                new Product() {Name="Asus FX503VD-DM104 Intel Core i5 7300HQ 8GB 1TB GTX1050 ",Description="Taşınabilir Bilgisayar",Price=4600,Stock=80,IsApproved=true,CategoryId=2,IsHome=true,Image = "4.jpg"},
                new Product() {Name="Monster Abra A5 V13.1.1 Intel Core i5 8300H 8GB 256GB SSD GTX1050",Description="Taşınabilir Bilgisayar",Price=5200,Stock=200,IsApproved=false,CategoryId=2,IsHome=true,Image = "1.jpg"},

                new Product() {Name="LG 55EC930V 140CM FULLHD UYDU ALICILI SMART CURVED 3D OLED TV",Description="LG OLED TV ile karanlığın içine dalın. Organik kendinden püskürtmeli pikseller, tamamen kapanma özelliğinden dolayı en derin siyah seviyelere ulaşıyor - ışık yayılmıyor veya pikselden geçiyor. Bu, LED  TV teknolojisinin eşleşemeyeceği şekilde tonlarına ve renklerin hayata geçiri",Price=4000,Stock=100,IsApproved=true,CategoryId=3,IsHome=true,Image = "1.jpg"},
                new Product() {Name="Samsung UE-43MU7000 43 109 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV",Description="Samsung UE43MU7000 43 MU7000 7 Serisi Flat 4K UHD TV belgesel izlerken ya da şov programlarını takip ederken görüntü kalitesine önem veren kullanıcılara hitap ediyor.",Price=3500,Stock=150,IsApproved=true,CategoryId=3,IsHome=false,Image = "2.jpg"},
                new Product() {Name="Vestel 55UD8400 55 140 Ekran 4K Ultra HD Smart LED TV",Description="Vestel 55UD8400 55 140 Ekran 4K UHD Smart LED TV, yüksek teknoloji ile desteklenen 4K çözünürlüğe sahip ekran paneli ile görüntü deneyimlerinizi geliştirmek için kullanımınıza sunuluyor. ",Price=2800,Stock=100,IsApproved=false,CategoryId=3,IsHome=true,Image = "3.jpg"},
                new Product() {Name="Philips 55PUS7303 55 139 Ekran 4K Ultra HD Smart LED TV",Description="4K Ultra HD. Görseller öyle net ki kendinizi aksiyonun içinde zannedeceksiniz.",Price=4600,Stock=80,IsApproved=true,CategoryId=3,IsHome=true,Image = "4.jpg"},
                new Product() {Name="Samsung UE-43MU7000 43 109 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV",Description="4K ekran çözünürlüğü, yeterli çözünürlüğe sahip filmlerinizi izlerken gerçeğe yakın görüntüler sergiliyor.",Price=5200,Stock=200,IsApproved=true,CategoryId=3,IsHome=false,Image = "5.jpg"},

                new Product() {Name="Iphone XS",Description="LG OLED TV ile karanlığın içine dalın. Organik kendinden püskürtmeli pikseller, tamamen kapanma özelliğinden dolayı en derin siyah seviyelere ulaşıyor - ışık yayılmıyor veya pikselden geçiyor. Bu, LED  TV teknolojisinin eşleşemeyeceği şekilde tonlarına ve renklerin hayata geçiri",Price=4000,Stock=100,IsApproved=true,CategoryId=4,IsHome=true,Image = "1.jpg"},
                new Product() {Name="Iphone 8 Plus",Description="Samsung UE43MU7000 43 MU7000 7 Serisi Flat 4K UHD TV belgesel izlerken ya da şov programlarını takip ederken görüntü kalitesine önem veren kullanıcılara hitap ediyor.",Price=3500,Stock=150,IsApproved=false,CategoryId=4,IsHome=true,Image = "2.jpg"},
                new Product() {Name="Samsung Galaxy Note 9",Description="Yüksek teknoloji ile desteklenen 4K çözünürlüğe sahip ekran paneli ile görüntü deneyimlerinizi geliştirmek için kullanımınıza sunuluyor. ",Price=2800,Stock=100,IsApproved=true,CategoryId=4,IsHome=true,Image = "3.jpg"},
                new Product() {Name="Huawei Mate 20 Pro",Description="4K Ultra HD. Görseller öyle net ki kendinizi aksiyonun içinde zannedeceksiniz.",Price=4600,Stock=80,IsApproved=true,CategoryId=4,IsHome=true,Image = "4.jpg"},
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}