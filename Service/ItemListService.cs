namespace Item_CS {
    public class ItemList{
        public List<Item> ListItem = new List<Item> (){
           
        };
        public int numberCard = 12;
        public string[] images = new string[] {
            "https://i.pinimg.com/564x/c7/bd/16/c7bd16fd4a262efbd877c2fc13d46970.jpg",
            "https://i.pinimg.com/564x/3c/a8/a0/3ca8a086748918b6bf4f7bfdde35fc6b.jpg",
            "https://i.pinimg.com/564x/04/d8/0c/04d80c2668f063e1d81678255cc183ca.jpg",
            "https://i.pinimg.com/564x/1a/2d/0d/1a2d0d2d903dddd8ef392ed1360e076c.jpg",
            "https://i.pinimg.com/736x/36/d9/2f/36d92f0a795b012adadaad78302015c0.jpg",
            "https://i.pinimg.com/564x/d3/6b/41/d36b4122bc952809f5930d0e8b26cfb2.jpg",
            "https://i.pinimg.com/564x/68/1e/39/681e397954425d3b83096d14d715686a.jpg",
            "https://i.pinimg.com/736x/3a/ed/9e/3aed9e88b8c34354ae3ae31f176d2b24.jpg",
        };
        public double[] itemPrice = new double[]{
                23.44, 344.33, 588.22, 212.33, 288.44, 10.32,994.32
            };
        public List<Item> RandomListItem(){
                for(int i = 1 ; i <= numberCard; i++){
                Random rdn = new Random();
                int randomI = rdn.Next(0,itemPrice.Length);
                int index = rdn.Next(0,images.Length);
                ListItem.Add(new Item(){
                    Index = i,
                    UrlImage = images[index],
                    Price = itemPrice[randomI]});
            };
            return ListItem;
        }
        public Item RandomItem(){
            Item item = null;
            for(int i = 1 ; i <= numberCard; i++){
                Random rdn = new Random();
                int randomI = rdn.Next(0,itemPrice.Length);
                int index = rdn.Next(0,images.Length);
                item = new Item(){
                    Index = i,
                    UrlImage = images[index],
                    Price = itemPrice[randomI]};
            };
            return item;
        }
        public Item PickItem(int id){
            Item item = null;
            Random rdn = new Random();
            int indexI = rdn.Next(0,images.Length);
            int randomI = rdn.Next(0,itemPrice.Length);
            item = new Item(){
                Index = id,
                UrlImage = images[indexI],
                Price = itemPrice[randomI]};

            return item;
        }
    }
}