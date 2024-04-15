using System.Data;

namespace CoffeStore.DAL
{
    internal class ItemsDAL: DatabaseAccess
    {
        public DataTable Items_DAL()
        {
            return Items_DA_DAL();
        }
        public DataTable getTotalQuantityOfDish_DAL(string dishID)
        {
            return getTotalQuantityOfDish_DA_DAL(dishID);
        }
        public void InsertToMenu_DAL(string picture, string nameItems, int price,int quantity)
        {
            InsertToMenu_DA_DAL(picture, nameItems,price, quantity);
        }
        public void UpdateInfomation_DAL(string idValue)
        {
            UpdateInfomation_DA_DAL(idValue);
        }
        public void UpdateInfomation_DAL(string ItemID, string ItemPicture, string ItemTitle, int ItemPrice, int ItemQuantity)
        {
            UpdateInfomation_DA_DAL(ItemID, ItemPicture, ItemTitle, ItemPrice, ItemQuantity);

        }
        public void UpdateQuantity_DAL(string ItemID,int ItemQuantity)
        {
            UpdateQuantity_DA_DAL(ItemID, ItemQuantity);
        }
        /*public void InsertIntoCart_DAL(string idValue, string ItemPicture, int soLuong, int ItemPrice, int numItemsOfCart)
        {
            InsertIntoCart_DA_DAL(idValue, ItemPicture, soLuong, ItemPrice, numItemsOfCart);
        }*/
    }
}
