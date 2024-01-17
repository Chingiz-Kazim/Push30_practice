using FirstLessonUI.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstLessonUI.ViewComponents
{
    public class FilterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PushDBContext db)
        {
            ViewBag.Activity = new SelectList(db.Activities.ToList(), "Id", "Name");
            ViewBag.Package = new SelectList(db.Packages.ToList(), "Id", "Name");
            ViewBag.City = new SelectList(db.Cities.ToList(), "Id", "Name");
            ViewBag.Region = new SelectList(db.Regions.ToList(), "Id", "Name");
            return View();
        }

      }
}
