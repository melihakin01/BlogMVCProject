using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogMVCProject.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori = new List<Kategori>()
            {
                new Kategori() {KategoriAd="DONANIM" },
                new Kategori() {KategoriAd="YAZILIM" },
                new Kategori() {KategoriAd="TEKNOLOJİ" },
            };
            foreach (var item in kategori)
            {
                context.Kategoris.Add(item);
            }
            context.SaveChanges();

            var makale = new List<Makale>()
            {
                new Makale() {Baslik="İşlemci Nedir?",Aciklama="CPU (Central Processing Unit – Merkezi İşlem Birimi) yani işlemci, milyarlarca mikroskobik transistörden oluşan küçük bir çiptir. İki ana bileşeni vardır: Aritmetik mantık birimi (ALU) ve kontrol birimi (CU). Kontrol ünitesi (CU), bilgisayarınızın ana belleğinden talimatları almaktan ve bu talimatları komutlara dönüştürmekten sorumludur.",Resim="islemci.jpg",YayinTarih=Convert.ToDateTime("2021.10.26"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="melihakin"},
                new Makale() {Baslik="AnaKart Nedir?",Aciklama="Bilgisayar başta olmak üzere televizyon ve cep telefonu gibi elektronik cihazlarda da bulunan, donanımların bir araya toplanması ve bu donanımların birbirleri ile iletişim kurarak koordineli bir şekilde çalışmalarını sağlayan parçaya anakart (motherboard) denir.",Resim="Anakart.jpg",YayinTarih=Convert.ToDateTime("2021.10.26"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="melihakin"},
                new Makale() {Baslik="Ekran Kartı Nedir?",Aciklama="Ekran kartı, bilgisayardaki grafik verilerini işleyip görüntü olarak monitörde gösterilmesini sağlar. Yazılım ve donanım özellikleri sayesinde yüksek çözünürlüklü görüntülerin oluşturulmasına imkân tanır. Kullanılan grafik işlemcisi (GPU), bellek tipi ve kapasitesi, chip seti ve çekirdek hızının yanı sıra soğutma mekanizması, slot ve fan tipi, hız aşırtma (overclock) gibi özellikler bakımından da pek çok farklı ekran kartı modeli vardır.",Resim="ekran-kartı.jpg",YayinTarih=Convert.ToDateTime("2021.10.26"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="melihakin"},
            };
            foreach (var item in makale)
            {
                context.Makales.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}