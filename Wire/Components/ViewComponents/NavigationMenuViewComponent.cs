using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using wire.Models;

namespace wire.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var menuItems = new List<MenuItem>
            {
                new MenuItem { Controller = "Home", Action = "Index", Label = "Home" },
                new MenuItem { Controller = "Home", Action = "About", Label = "About" },
                new MenuItem { Controller = "Employees", Action = "Index", Label = "Employees", DropdownItems = new List<MenuItem>{
                    new MenuItem { Controller = "Employees", Action="Index", Label = "List" },
                    new MenuItem { Controller = "Employees", Action="Create", Label = "Create" },
                } },
                new MenuItem { Controller = "Home", Action = "Privacy", Label = "Privacy" },
                
            };


            return View(menuItems); //Becomes "Model" in the view
        }
    }
}
