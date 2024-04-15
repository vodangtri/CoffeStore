namespace CoffeStore.DAL
{
    internal class TichDiemDAL:DatabaseAccess
    {
        public void TichDiem_DAL(int sdt)
        {
            TichDiem_DA_DAL(sdt);
        }
        public string LayDiem_DAL(int sdt)
        {
            return LayDiem_DA_DAL(sdt);
        }
    }
}
