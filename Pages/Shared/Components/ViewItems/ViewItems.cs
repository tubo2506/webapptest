using Microsoft.AspNetCore.Mvc;
using Item_CS;

namespace Components{
    public class ViewItems :ViewComponent
    {
        ItemList ListItemService = new ItemList(){};
        public IViewComponentResult Invoke(int id){
            Item ListItemServices = ListItemService.PickItem(id);
            return View<Item>(ListItemServices);
        }
    }
}