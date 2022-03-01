using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_001_LINQDonguKarsilastirmasi
{
    public partial class Fonkisyon : System.Web.UI.Page
    {
        public class Kisi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
            public int Boy { get; set; }
        }
        public class Ogrenci
        {
            public string OgrenciNo { get; set; }
            public string AdSoyad { get; set; }
            public string Ders { get; set; }
            public int Not { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //FonksiyonluWhere();
            //Average();
            //Count();
            //FirstOrDefault();
            //Last();
            //Max();
            //Min();
            //OrderBy();
            OrderByDescending();
        }
protected void FonksiyonluWhere()
{
    List<Kisi> kisiler = new List<Kisi>();
    kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
    kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
    kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
    kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
    kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
    kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
    kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

    var sorguSonuc = kisiler.Where(kisi => kisi.Soyad == "Kızmaz");

    foreach (var item in sorguSonuc)
    {
        Label1.Text += item.Ad + " " + item.Soyad + "<br/>";
    };
}
protected void Average()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var notOrtalama = ogrenciler.Average(o => o.Not);
    Label1.Text = notOrtalama.ToString();
}
protected void Count()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var ogrenciSayisi = ogrenciler.Count();
    Label1.Text = ogrenciSayisi.ToString();
}
protected void FirstOrDefault()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var ogrenci = ogrenciler.FirstOrDefault();
    Label1.Text = "Öğrenci No: " + ogrenci.OgrenciNo +
        "<br/>Ad Soyad: " + ogrenci.AdSoyad +
        "<br/>Ders: " + ogrenci.Ders +
        "<br/>Not: " + ogrenci.Not;
}
protected void Last()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var ogrenci = ogrenciler.Last();
    Label1.Text = "Öğrenci No: " + ogrenci.OgrenciNo +
        "<br/>Ad Soyad: " + ogrenci.AdSoyad +
        "<br/>Ders: " + ogrenci.Ders +
        "<br/>Not: " + ogrenci.Not;
}
protected void Max()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var not = ogrenciler.Max(o => o.Not);
    Label1.Text = not.ToString();
}
protected void Min()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var not = ogrenciler.Min(o => o.Not);
    Label1.Text = not.ToString();
}
protected void OrderBy()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var ogrencilerSirali = ogrenciler.OrderBy(o => o.Not);
    foreach (var ogrenci in ogrencilerSirali)
    {
        Label1.Text += "Öğrenci No: " + ogrenci.OgrenciNo +
            "<br/>Ad Soyad: " + ogrenci.AdSoyad +
            "<br/>Ders: " + ogrenci.Ders +
            "<br/>Not: " + ogrenci.Not + "<hr/>";
    };
}
protected void OrderByDescending()
{
    List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Programlamaya Giriş", Not=95},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Yazılım Mühendisliği", Not=98},
        new Ogrenci{ OgrenciNo = "1", AdSoyad = "Veysel Uğur Kızmaz", Ders="Veri Yapıları", Not=82},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Fizik", Not=78},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Matematik", Not=90},
        new Ogrenci{ OgrenciNo = "2", AdSoyad = "Neslihan Yağmur", Ders="Kimya", Not=88},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Programlamaya Giriş", Not=60},
        new Ogrenci{ OgrenciNo = "3", AdSoyad = "Umutcan Savur", Ders="Fizik", Not=68}
    };
    var ogrencilerSirali = ogrenciler.OrderByDescending(o => o.Not);
    foreach (var ogrenci in ogrencilerSirali)
    {
        Label1.Text += "Öğrenci No: " + ogrenci.OgrenciNo +
            "<br/>Ad Soyad: " + ogrenci.AdSoyad +
            "<br/>Ders: " + ogrenci.Ders +
            "<br/>Not: " + ogrenci.Not + "<hr/>";
    };
}
    }
}