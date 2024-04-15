namespace CoffeStore.DTO
{
    internal class ListOrderDTO
    {
        public string IdOrder { get; set; }
        public string NgayLap { get; set; }
        public string ThoiGianLap { get; set; }
        public string IdNhanvien { get; set; }
        public string IDGioHang { get; set; }
        public string NameItems { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
