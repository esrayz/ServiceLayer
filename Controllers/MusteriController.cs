using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models;
using System.Collections;

namespace ServiceLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusteriController : Controller
    {
        [HttpGet]
        public ActionResult<List<VMusteri>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();

            return ctx.VMusteriler.ToList();
        }
        [HttpPost]
        public IActionResult addNew(MusteriParam vm) {
            
        Musteri m = new Musteri();
            m.MusteriAdi = vm.MusteriAdi;
            m.MusteriSoyadi= vm.MusteriSoyadi;
            m.DogumTarihi = vm.DogumTarihi;
            m.CinsiyetId = vm.Cinsiyet;
            m.SehirId= vm.Sehir;
            m.Adres= vm.Adres;
            
            
            ETicaretContext ctx = new ETicaretContext();
            ctx.Musteris.Add(m);
            ctx.SaveChanges();
         return Ok("Kayıt Başarılı  "+ "Kayıt Numarınız: " + m.MusteriId);   


        
        }
        [HttpDelete]
        public IActionResult delete(int vm)
        {

            ETicaretContext ctx = new ETicaretContext();
            Musteri m = ctx.Musteris.Find(vm);
            ctx.Musteris.Remove(m);
            ctx.SaveChanges();
            return Ok("Kayıt Silindi ");

        }
        //[HttpGet]
        //public ActionResult<IEnumerable> Index()
        //{
        //    ETicaretContext ctx = new ETicaretContext();

        //    return ctx.Musteris.Select(m => new
        //    {

        //        Ad = m.MusteriAdi,
        //        Soyad = m.MusteriSoyadi,

        //        Esra = System.DateTime.Now,

        //    }).ToList();
        //}
    }
    //public class Kisi
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //}

}
