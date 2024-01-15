using Item_CS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Components{
    public class ItemInfo : ViewComponent
    {
        ItemListService ItemService;
        public void ItemList(ItemListService _items){
            ItemService = _items;
        }
        public IViewComponentResult Invoke(bool order){
            List<Item> itemss = ItemService?.RandomItem();
            List<Item> _item;
            if(order){
                _item = itemss.OrderBy(p => p.Price).ToList();
            }
            else{
                _item = itemss.OrderByDescending(p => p.Price).ToList();
            }
            return View<List<Item>>(_item);

    }
}
}