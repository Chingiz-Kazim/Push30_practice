using FirstLessonUI.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PushDBContext db)
        {
            var model = db.SiteInfos.FirstOrDefault();
            return View(model);
        }

    }
}
