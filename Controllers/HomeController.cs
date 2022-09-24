using Microsoft.AspNetCore.Mvc;
using MvcModels.Models;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Ogrenci> ogrList = new List<Ogrenci>();
            ogrList.Add(new Ogrenci { Id=1,Adi="Büşra" });
            ogrList.Add(new Ogrenci { Id = 2,Adi="Kübra" });
            ogrList.Add(new Ogrenci { Id=3,Adi="İsmail" });
            ogrList.Add(new Ogrenci { Id=4,Adi="Celalettin" });
            ogrList.Add(new Ogrenci { Id=5,Adi="Ziya" });
            ogrList.Add(new Ogrenci { Id=6,Adi="Onur" });
            ogrList.Add(new Ogrenci { Id = 7, Adi = "Özgür" });

            // modeli view'a bind ediyoruz...
            return View(ogrList); 
        }


        // bu action view'dan çağrılacak....
        public IActionResult Ekle(Ogrenci ogrenci)
        {
            return View();
        }

        public IActionResult OgrenciGoster()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Id = 1;
            ogr.Adi = "Ekrem";

            return Json(ogr); // Json formata dönüştür ve dön...
        }
    }
}
