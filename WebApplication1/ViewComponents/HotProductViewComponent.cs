using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}