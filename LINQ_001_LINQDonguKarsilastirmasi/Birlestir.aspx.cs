using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_001_LINQDonguKarsilastirmasi
{
    public partial class Birlestir : System.Web.UI.Page
    {
public class Kategori
{
    public int Id { get; set; }
    public string Ad { get; set; }
}
public class Urun
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public int Fiyat { get; set; }
    public int KategoriId { get; set; }
}
        protected void Page_Load(object sender, EventArgs e)
        {
            JoinUrunler();
        }
protected void JoinUrunler()
{
    List<Kategori> kategoriler = new List<Kategori>()
    {
        new Kategori{ Id = 1, Ad = "Bilgisayar"},
        new Kategori{ Id = 2, Ad = "Cep Telefonu"},
        new Kategori{ Id = 3, Ad = "Elektronik"}
    };
    List<Urun> urunler = new List<Urun>()
    {
        new Urun{ Id = 1, KategoriId = 1, Ad="Laptop", Fiyat=2100},
        new Urun{ Id = 2, KategoriId = 2, Ad="Masaüstü bilgisayar", Fiyat=1500},
        new Urun{ Id = 3, KategoriId = 1, Ad="Tablet PC", Fiyat=1100},
        new Urun{ Id = 4, KategoriId = 2, Ad="Akıllı telefon", Fiyat=1200},
        new Urun{ Id = 5, KategoriId = 2, Ad="Cep telefonu", Fiyat=300},
        new Urun{ Id = 6, KategoriId = 2, Ad="Şarj aleti", Fiyat=20},
        new Urun{ Id = 7, KategoriId = 3, Ad="Ütü", Fiyat=150},
        new Urun{ Id = 8, KategoriId = 3, Ad="Mikrodalga fırın", Fiyat=200},
        new Urun{ Id = 9, KategoriId = 3, Ad="Çamaşır makinesi", Fiyat=1000},
        new Urun{ Id = 10, KategoriId = 3, Ad="Buzdolabı", Fiyat=2000}
    };
    var urunBilgileri = (from urun in urunler
                            join kategori in kategoriler
                            on urun.KategoriId equals kategori.Id
                            select new
                            {
                                UrunAdi = urun.Ad,
                                urun.Fiyat,
                                Kategori = kategori.Ad
                            });
    foreach (var urun in urunBilgileri)
    {
        Label1.Text += "Adı: " + urun.UrunAdi +
            ", Kategori: " + urun.Kategori +
            ", Fiyatı: " + urun.Fiyat + " TL<br/>";
    }
}
    }
}