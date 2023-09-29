using Microsoft.AspNetCore.Mvc;
using Actividad2.Models;
namespace Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(MonedaViewModel vm )
        {
            if (vm.TipoMoneda == "MXN" )
            {
                vm.Resultado = vm.Monto * 18m; 
            }
            else
            {
                vm.Resultado = vm.Monto / 18m;
            }
            return View(vm);
        }
    }
}
