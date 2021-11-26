using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace firstApp.Controllers
{
    [Authorize]
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.Nombre ="Fatima";
            personal.Apellido ="Ayala";
            personal.Edad=18;
            personal.CorreoElectronico ="ftayala89@gmail.com";
            personal.Telefono = 73663246;
            personal.Direccion = "Caserio El Tablon, Uluazapa";

            return View(personal);
        }
    }
}