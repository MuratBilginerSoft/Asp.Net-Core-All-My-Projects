using Microsoft.AspNetCore.Mvc;

namespace DeveloperEng_App.ViewComponents.DashboardLayout
{
    public class DashboardLayout :  ViewComponent
    {
        public IViewComponentResult Invoke(string partialViewName)
        {
            switch (partialViewName)
            {
                case "HeadPartial":
                    return View("/Views/Shared/Components/Dashboard/HeadPartial.cshtml");
                case "LeftSideBarPartial":
                    return View("/Views/Shared/Components/Dashboard/LeftSideBarPartial.cshtml");
                case "NavbarPartial":
                    return View("/Views/Shared/Components/Dashboard/NavbarPartial.cshtml");
                case "FooterPartial":
                    return View("/Views/Shared/Components/Dashboard/FooterPartial.cshtml");
                case "ConfiguratorPartial":
                    return View("/Views/Shared/Components/Dashboard/ConfiguratorPartial.cshtml");
                case "JSPartial":
                    return View("/Views/Shared/Components/Dashboard/JSPartial.cshtml");
                case "Partial7":
                    return View("/Views/Shared/Components/Dashboard/Partial7/Partial7.cshtml");
                case "Partial8":
                    return View("/Views/Shared/Components/Dashboard/Partial8/Partial8.cshtml");
                case "Partial9":
                    return View("/Views/Shared/Components/Dashboard/Partial9/Partial9.cshtml");
                case "Partial10":
                    return View("/Views/Shared/Components/Dashboard/Partial10/Partial10.cshtml");
                default:
                    return View("/Views/Shared/Components/Dashboard/Default.cshtml");
            }
        }
    }
}
