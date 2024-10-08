using Microsoft.AspNetCore.Mvc;
using personWebApp.HerosApiCall;
using personWebApp.Models;

namespace personWebApp.Controllers
{
    public class HerosController : Controller
    {
        public async Task<IActionResult> ViewHeros()
        {
            HerosAPIClass herosCall = new HerosAPIClass();
            List<Heros> herosList = await herosCall.GetDataAsync();
            return View(herosList);
        }
    }
}
