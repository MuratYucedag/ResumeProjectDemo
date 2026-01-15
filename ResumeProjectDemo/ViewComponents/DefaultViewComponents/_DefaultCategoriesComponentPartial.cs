using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultCategoriesComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;
        public _DefaultCategoriesComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Categories.ToList();
            return View(values);
        }
    }
}