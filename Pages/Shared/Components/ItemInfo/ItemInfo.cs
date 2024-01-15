using Item_CS;
using Microsoft.AspNetCore.Mvc;

namespace Components{
    public class ItemInfo : ViewComponent
    {
        ItemList ListItemService = new ItemList(){};

        public IViewComponentResult Invoke(bool order){
            List<Item> _item;
            List<Item> ListItemServices = ListItemService.RandomListItem();
            if(order){
                _item = ListItemServices.OrderBy(p => p.Price).ToList();
            }
            else{
                _item = ListItemServices.OrderByDescending(p => p.Price).ToList();
            }
            return View<List<Item>>(_item);

    }
}
}