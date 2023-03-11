using CoreDemo.Areas.Admin.Models;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Eğitim",
                categorycount = 10
            });

            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            });

            list.Add(new CategoryClass
            {
                categoryname = "Psikoloji",
                categorycount = 5
            });

            list.Add(new CategoryClass
            {
                categoryname = "Sağlık",
                categorycount = 20
            });
            return Json(new { jsonlist = list });
        }
    }
}
