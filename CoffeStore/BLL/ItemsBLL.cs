using CoffeStore.DAL;
using System.Data;

namespace CoffeStore.BLL
{
    internal class ItemsBLL 
    {
        ItemsDAL items = new ItemsDAL();
        public DataTable Items_BLL()
        {
            return items.Items_DAL();
        }
       public DataTable getTotalQuantityOfItemsBLL(string dishID)
        {
            return items.getTotalQuantityOfDish_DAL(dishID);
        }
        public void InsertToMenu(string picture, string nameItems, int price,int quantity)
        {
            items.InsertToMenu_DAL(picture, nameItems,price, quantity);
        }
        public void UpdateInfomationBLL(string idValue)
        {
            items.UpdateInfomation_DAL(idValue);
        }
        public void UpdateInfomationBLL(string ItemID, string ItemPicture, string ItemTitle, int ItemPrice, int ItemQuantity)
        {
            items.UpdateInfomation_DAL(ItemID, ItemPicture, ItemTitle, ItemPrice, ItemQuantity);
        }

        public void UpdateQuantity_BLL(string ItemID,int ItemQuantity)
        {
            items.UpdateQuantity_DAL(ItemID, ItemQuantity);
        }

        /*public void InsertIntoCart_BLL(string idValue, string ItemPicture, int soLuong, int ItemPrice, int numItemsOfCart)
        {
            items.InsertIntoCart_DAL(idValue,ItemPicture, soLuong,ItemPrice, numItemsOfCart);

        }*/

    }
}
