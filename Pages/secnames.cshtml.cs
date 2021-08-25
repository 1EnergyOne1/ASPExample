using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace EnergyOne.Pages
{
    public class SecName: PageModel
    {
        public IEnumerable<string> Names {get;set;}
        public void OnGet()
        {
            ViewData["Title"] = "EnergyOne`s Веб-приложение - Имена";

            Names = new[] {"Anton", "Mari", "Nika"};
        }
    }
}