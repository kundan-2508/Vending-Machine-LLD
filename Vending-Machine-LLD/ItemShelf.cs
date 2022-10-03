namespace Vending_Machine_LLD
{
    public  class ItemShelf
    {
        int code;
        bool soldOut;
        Item item;
        public int getCode()
        {
            return code;
        }
        public void setCode(int code)
        {
            this.code = code;
        }
        public Item getItem()
        {
            return item;
        }
        public void setItem(Item item)
        {
            this.item = item;
        }
        public bool getSoldOut()
        {
            return soldOut;
        }
        public void setSoldOut(bool soldOut)
        {
            this.soldOut = soldOut;
        }
    }
}
