using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models;
using System.Collections;

namespace ServiceLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrunController : Controller
    {
        [HttpGet]
        public ActionResult<List<VUrun>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();

            return ctx.VUrunler.ToList();
        }
    }   
}
