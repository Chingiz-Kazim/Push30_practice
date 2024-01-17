using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.ViewComponents
{
    public class HowItWorksViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

        }
}
