using Microsoft.AspNetCore.Mvc;
using personWebApp.FruitsApiCall;
using personWebApp.Models;

namespace personWebApp.Controllers
{
    public class FruitsController : Controller
    {
        public async Task<IActionResult> ViewFruits()
        {
            FruitsAPIClass fruitsCall = new FruitsAPIClass();
            List<Fruits> FruitsList = await fruitsCall.GetDataAsync();
            return View(FruitsList);
        }
    }
}
