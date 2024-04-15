using System.Data;

namespace CoffeStore.DAL
{
    internal class ItemsCart_DAL:DatabaseAccess
    {
        public DataTable ItemsCartDAL()
        {
            return ItemsCart_DA_DAL();
        }

        public void InsertIntoCart_DAL(string idValue, string ItemPicture,string ItemTitle, int ItemPrice, int numItemsOfCart)
        {
            InsertIntoCart_DA_DAL(idValue, ItemPicture, ItemTitle, ItemPrice, numItemsOfCart);
        }
        public void createOrder_DAL(string idNhanvien)
        
        {
            createOrder_DA_DAL(idNhanvien);
        }
        public void AddBill_DAL()
        {
            AddToSupportingCart_DA_DAL();
        }
    }
}
