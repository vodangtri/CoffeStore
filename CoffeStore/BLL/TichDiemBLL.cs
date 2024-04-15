using CoffeStore.DAL;

namespace CoffeStore.BLL
{
    internal class TichDiemBLL
    {
        TichDiemDAL score = new TichDiemDAL();
        public void TichDiem_BLL(int sdt)
        {
            score.TichDiem_DAL(sdt);
        }
        public string LayDiem_BLL(int sdt)
        {
            return score.LayDiem_DAL(sdt);
        }
    }
}
