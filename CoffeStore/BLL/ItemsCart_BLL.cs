using CoffeStore.DAL;
using System.Data;

namespace CoffeStore.BLL
{
    internal class ItemsCart_BLL
    {
        ItemsCart_DAL itemsCart = new ItemsCart_DAL();
        public DataTable ItemsCart()
        {
            return itemsCart.ItemsCartDAL();
        }

        public DataTable getQuantityOfItems_BLL(string dishID)
        {
            return itemsCart.getQuantityOfItems_DAL(dishID);
        }
        public void InsertIntoCart_BLL(string idValue, string ItemPicture, string ItemTitle, int ItemPrice, int numItemsOfCart)
        {
            itemsCart.InsertIntoCart_DAL(idValue, ItemPicture, ItemTitle, ItemPrice, numItemsOfCart);

        }
        public void createOrder_BLL(string idNhanvien)
        {

            itemsCart.createOrder_DAL(idNhanvien);
        }
        public void AddBillBLL()
        {
            itemsCart.AddBill_DAL();
        }
    }

}
