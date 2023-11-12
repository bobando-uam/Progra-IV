using Calculadora_D_202020051140.Models;
using Calculadora_D_202020051140.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_D_202020051140.Controllers
{
   
    public class CalculatorController : Controller
    {
        private readonly CalculadoraSalarioService _CalculadoraSalarioService;
        public CalculatorController(CalculadoraSalarioService calculadoraservice)
        {
            _CalculadoraSalarioService = calculadoraservice;
        }
        [HttpGet]
        public IActionResult Index()
        {
            CalculatorControlViewModel model=new CalculatorControlViewModel();
            
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(CalculatorControlViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            ViewBag.NotaFinal = await _CalculadoraSalarioService.CalculateFinalSalario(model);
            return View(model);
        }

    }
}
