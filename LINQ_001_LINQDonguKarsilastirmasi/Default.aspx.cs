using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_001_LINQDonguKarsilastirmasi
{
    public partial class Default : System.Web.UI.Page
    {
public class Kisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Yas { get; set; }
    public int Boy { get; set; }
}
public class Urun
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public int Fiyat { get; set; }
    public int Adet { get; set; }
}
        protected void Page_Load(object sender, EventArgs e)
        {
            //DonguIleIsimleriFiltrele();
            //SelectNew();
            //SelectBir();
            //WhereEsitlikKontrolu();
            //WhereBuyukKontrolu();
            //WhereCokluKontrol();
            //WhereFonksiyon1();
            //WhereFonksiyon2();
            //SiralaKucuktenBuyuge();
            //SiralaBuyuktenKucuge();
            //SiralaVarsayilan();
            UrunGrupla();
        }
        protected void DonguIleIsimleriFiltrele()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz" });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz" });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur" });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur" });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur" });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur" });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur" });

            int kizmazlar = 0;
            foreach (Kisi kayit in kisiler)
            {
                if (kayit.Soyad == "Kızmaz")
                    kizmazlar++;
            }
            Label1.Text = kizmazlar.ToString();
        }
        protected void LINQIleIsimleriFiltrele()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz" });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz" });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur" });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur" });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur" });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur" });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur" });

            int kizmazlar = (from kayit in kisiler
                                where kayit.Soyad == "Kızmaz"
                                select kayit).Count();
            Label1.Text = kizmazlar.ToString();
        }
        protected void SelectNew()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                select new
                                {
                                    kayit.Ad,
                                    kayit.Soyad
                                });

            string sonuc = "";
            foreach (var item in tumKisiler)
            {
                sonuc += item.Ad + " " + item.Soyad + "<br/>";
            };
            Label1.Text = sonuc;
        }
        protected void SelectBir()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                select kayit.Ad);

            foreach (var item in tumKisiler)
            {
                Label1.Text += item + "<br/>";
            };
        }
        protected void WhereEsitlikKontrolu()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                where kayit.Soyad == "Kızmaz"
                              select new { kayit.Ad, kayit.Soyad });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Ad + " " + item.Soyad + "<br/>";
            };
        }
        protected void WhereBuyukKontrolu()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                where kayit.Yas > 20
                                select new { kayit.Ad, kayit.Soyad });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Ad + " " + item.Soyad + "<br/>";
            };
        }
        protected void WhereCokluKontrol()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                where kayit.Yas > 18 && kayit.Soyad == "Yağmur"
                                select new { kayit.Ad, kayit.Soyad });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Ad + " " + item.Soyad + "<br/>";
            };
        }
        protected void WhereFonksiyon1()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                where kayit.Ad.EndsWith("an")
                                select new { kayit.Ad, kayit.Soyad });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Ad + " " + item.Soyad + "<br/>";
            };
        }
        protected void WhereFonksiyon2()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                where KisiFiltrele(kayit)
                                select new { kayit.Ad, kayit.Soyad });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Ad + " " + item.Soyad + "<br/>";
            };
        }
        private bool KisiFiltrele(Kisi kisi)
        {
            return kisi.Ad.EndsWith("an");
        }
        protected void SiralaKucuktenBuyuge()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                orderby kayit.Yas ascending
                                select new { kayit.Ad, kayit.Soyad, kayit.Yas });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Yas + " - " + item.Ad + " " + item.Soyad +  "<br/>";
            };
        }
        protected void SiralaBuyuktenKucuge()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 18, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 21, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                orderby kayit.Yas descending
                                select new { kayit.Ad, kayit.Soyad, kayit.Yas });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Yas + " - " + item.Ad + " " + item.Soyad + "<br/>";
            };
        }
        protected void SiralaVarsayilan()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Ad = "Veysel Uğur", Soyad = "Kızmaz", Yas = 27, Boy = 180 });
            kisiler.Add(new Kisi { Ad = "Baran Yağış", Soyad = "Kızmaz", Yas = 20, Boy = 190 });
            kisiler.Add(new Kisi { Ad = "Umutcan", Soyad = "Savur", Yas = 14, Boy = 150 });
            kisiler.Add(new Kisi { Ad = "İremnaz", Soyad = "Savur", Yas = 17, Boy = 170 });
            kisiler.Add(new Kisi { Ad = "Emre", Soyad = "Yağmur", Yas = 17, Boy = 175 });
            kisiler.Add(new Kisi { Ad = "Nagihan", Soyad = "Yağmur", Yas = 20, Boy = 165 });
            kisiler.Add(new Kisi { Ad = "Neslihan", Soyad = "Yağmur", Yas = 23, Boy = 168 });

            var tumKisiler = (from kayit in kisiler
                                orderby kayit.Yas
                                select new { kayit.Ad, kayit.Soyad, kayit.Yas });

            foreach (var item in tumKisiler)
            {
                Label1.Text += item.Yas + " - " + item.Ad + " " + item.Soyad + "<br/>";
            };
        }
        protected void UrunGrupla()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun{Id = 1, Ad = "Peynir",Fiyat = 16, Adet = 17},
                new Urun{Id = 2, Ad = "Zeytin",Fiyat = 9, Adet = 20 },
                new Urun{Id = 3, Ad = "Yağ",Fiyat = 10, Adet = 16 },
                new Urun{Id = 4, Ad = "Peynir",Fiyat = 20, Adet = 7 },
                new Urun{Id = 5, Ad = "Zeytin",Fiyat = 11, Adet = 26},
                new Urun{Id = 6, Ad = "Reçel",Fiyat = 9, Adet = 5} ,
                new Urun{Id = 7, Ad = "Peynir",Fiyat = 21, Adet = 4} ,
                new Urun{Id = 8, Ad = "Pekmez",Fiyat = 19, Adet = 2} ,
                new Urun{Id = 9, Ad = "Su",Fiyat = 3, Adet = 18} 
            };
            var secilenUrunler = from urun in urunler
                                    group urun by urun.Ad into grup
                                    select new { Adi = grup.Key, UrunGrubu = grup };
            foreach (var urun in secilenUrunler)
            {
                double urunFiyat = urun.UrunGrubu.Sum(u => u.Fiyat * u.Adet);
                Label1.Text += urun.Adi + " : " + urunFiyat + " TL<br/>";
            }

        }

    }
}