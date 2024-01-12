using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace Components{
    public class Filter_bar : ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View("Filter");
        }
    }
}