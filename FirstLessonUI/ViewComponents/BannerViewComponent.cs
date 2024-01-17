using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.ViewComponents
{
    public class BannerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

        }
}
