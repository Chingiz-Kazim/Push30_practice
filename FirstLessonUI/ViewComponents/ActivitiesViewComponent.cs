using FirstLessonUI.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.ViewComponents
{
    public class ActivitiesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PushDBContext db)
        {
            var model = db.Activities.ToList();
            return View(model);
        }

      }
}
