using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.ViewComponents
{
    public class PricingViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
