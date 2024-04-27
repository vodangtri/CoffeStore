using CoffeStore.DTO;
using CoffeStore.HeThong.NhanVienBanHang.GioHang;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoffeStore.DAL
{
    internal class DatabaseAccess
    {

        private string connectionString = @"Data Source=VIET;Initial Catalog=CoffeStore;Integrated Security=True;MultipleActiveResultSets=True;";


        public string checkLoginData_DA_DAL(User tk)
        {
            string userName = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT * FROM Account WHERE UserName = @UserName AND UserPassword = @UserPassword";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", tk.UserName);
                    cmd.Parameters.AddWithValue("@UserPassword", tk.UserPassword);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                userName = reader.GetString(5);
                            }
                        }
                        else
                        {
                            return "Thông tin đăng nhập không chính xác!";
                        }
                    }
                }
            }
            return userName;
        }
        public string checkUsername_DA_DAL(User tk)
        {
            string userName = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT * FROM Account WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", tk.UserName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                userName = reader.GetString(5);
                            }
                        }
                        else
                        {
                            return "Tên đăng nhập này không tồn tại!";
                        }
                    }
                }
            }
            return userName;
        }
        public string getIdByUsername_DA_DAL(string name)
        {
            string userID = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT * FROM Account WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", name);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            userID = row["UserID"].ToString();
                        }
                    }
                }
            }
            return userID;
        }
        public void ChangePassword_DA_DAL(string username,string newPassword)
        {

            string sql = "UPDATE Account SET UserPassword = @UserPassword WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Thêm tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@UserPassword", newPassword);

                    // Mở kết nối và thực hiện câu lệnh SQL
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public string getNameNVById_DA_DAL(string IdNhanvien)
        {
            string fullName = "";

            // Câu lệnh SELECT để lấy FullName từ bảng TaiKhoan dựa vào IdNhanvien
            string query = "SELECT FullName FROM Account WHERE UserID = @IdNhanvien";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdNhanvien", IdNhanvien);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lấy giá trị FullName từ cột FullName trong kết quả truy vấn
                            fullName = reader.GetString(reader.GetOrdinal("FullName"));
                        }
                    }
                }
            }

            return fullName;
        }
        public DataTable Items_DA_DAL()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT * FROM Items where TrangThai <> 'disable'";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
        public DataTable ItemsCart_DA_DAL()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT * FROM GioHang where StatusItems<>'done'";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }

        public DataTable ListOrder_DA_DAL()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT distinct IdOrder,NgayLap,ThoiGianLap,IdNhanvien FROM ChiTietDonDat where TrangThai='available'";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }

        public DataTable getTotalQuantityOfDish_DA_DAL(string dishID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT Quantity FROM Items where Items.ID = @dishID";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@dishID", dishID);//khai bao bien
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
        public void InsertToMenu_DA_DAL(string picture, string nameItems, int price, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo đối tượng SqlCommand và gán tên thủ tục lưu trữ
                using (SqlCommand command = new SqlCommand("InsertItems", connection))
                {
                    // Đặt kiểu thực thi là StoredProcedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào thủ tục lưu trữ
                    command.Parameters.AddWithValue("@Picture", picture);
                    command.Parameters.AddWithValue("@NameItems", nameItems);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    // Thực thi thủ tục lưu trữ
                    command.ExecuteNonQuery();

                    // Thông báo thành công
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }

            }
        }
        public DataTable getQuantityOfItems_DAL(string dishID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT Quantity FROM GioHang where GioHang.IDItems = @dishID";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@dishID", dishID);//khai bao bien
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
        public void UpdateInfomation_DA_DAL(string id)
        {
            //string connectionString = @"Data Source=TRIS\SQLEXPRESS;Initial Catalog=CoffeStore;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string idValue = id;
                string updateQuery = "UPDATE Items SET TrangThai = 'disable' WHERE ID = @ID";

                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@ID", idValue);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    //MessageBox.Show("Xóa dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đối tượng có ID tương ứng");
                }

                connection.Close();
            }
        }
        public void UpdateInfomation_DA_DAL(string ItemID, string ItemPicture, string ItemTitle, int ItemPrice, int ItemQuantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu lệnh SQL để cập nhật đối tượng trong bảng "Items"
                string updateItemsQuery = "UPDATE Items SET Picture = @ItemPicture, NameItems = @ItemTitle, Price = @ItemPrice, Quantity = @ItemQuantity WHERE ID = @ItemID";
                using (SqlCommand command = new SqlCommand(updateItemsQuery, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL cho bảng "Items"
                    command.Parameters.AddWithValue("@ItemID", ItemID);
                    command.Parameters.AddWithValue("@ItemPicture", ItemPicture);
                    command.Parameters.AddWithValue("@ItemTitle", ItemTitle);
                    command.Parameters.AddWithValue("@ItemPrice", ItemPrice);
                    command.Parameters.AddWithValue("@ItemQuantity", ItemQuantity);

                    // Thực hiện câu lệnh SQL cho bảng "Items"
                    command.ExecuteNonQuery();
                }

                // Tạo câu lệnh SQL để cập nhật đối tượng trong bảng "GioHang"
                string updateGioHangQuery = "UPDATE GioHang SET Picture = @ItemPicture, NameItems = @ItemTitle,Price=@ItemPrice WHERE IDItems = @ItemID";
                using (SqlCommand command = new SqlCommand(updateGioHangQuery, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL cho bảng "GioHang"
                    command.Parameters.AddWithValue("@ItemID", ItemID);
                    command.Parameters.AddWithValue("@ItemPicture", ItemPicture);
                    command.Parameters.AddWithValue("@ItemTitle", ItemTitle);
                    command.Parameters.AddWithValue("@ItemPrice", ItemPrice);

                    // Thực hiện câu lệnh SQL cho bảng "GioHang"
                    command.ExecuteNonQuery();
                }

                // Đóng kết nối SQL
                connection.Close();
            }
        }
        public void UpdateQuantity_DA_DAL(string ItemID, int ItemQuantity)
        {
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu lệnh SQL để cập nhật đối tượng
                string updateQuery = "UPDATE Items SET Quantity = @ItemQuantity WHERE ID = @ItemID";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@ItemID", ItemID);
                    command.Parameters.AddWithValue("@ItemQuantity", ItemQuantity);

                    // Thực hiện câu lệnh SQL
                    command.ExecuteNonQuery();
                }

                // Đóng kết nối SQL
                connection.Close();
            }
        }
        public void InsertIntoCart_DA_DAL(string idValue, string ItemPicture, string ItemTitle, int ItemPrice, int numItemsOfCart)
        {
            // string connectionString = @"Data Source=TRIS\SQLEXPRESS;Initial Catalog=CoffeStore;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu lệnh SQL để kiểm tra xem hàng đã tồn tại trong bảng GioHang hay chưa
                string checkQuery = "SELECT COUNT(*) FROM GioHang WHERE IDItems = @IDItems";
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@IDItems", idValue);
                    int existingRows = (int)command.ExecuteScalar();

                    // Nếu hàng đã tồn tại, cập nhật số lượng và trạng thái. Ngược lại, chèn một hàng mới.
                    string query;
                    if (existingRows > 0)
                    {
                        query = "UPDATE GioHang SET Quantity = Quantity + @Quantity, StatusItems = 'available' WHERE IDItems = @IDItems";
                    }
                    else
                    {
                        query = "INSERT INTO GioHang (IDItems, Picture, NameItems, Price, Quantity) VALUES (@IDItems, @Picture, @NameItems, @Price, @Quantity)";
                    }

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Picture", ItemPicture);
                    command.Parameters.AddWithValue("@NameItems", ItemTitle); // Cần cung cấp giá trị của cột NameItems
                    command.Parameters.AddWithValue("@Price", ItemPrice);
                    command.Parameters.AddWithValue("@Quantity", numItemsOfCart);

                    // Thực hiện câu lệnh SQL
                    command.ExecuteNonQuery();
                }

                // Đóng kết nối SQL
                connection.Close();
            }
        }

        public void createOrder_DA_DAL(string idNhanvien)
        {
            // Thực hiện câu lệnh SQL EXEC AutoIncrementOrder
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AutoIncrementOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdNhanvien", idNhanvien); // Thêm dòng này
                    cmd.ExecuteNonQuery();
                }
            }

            // Thực hiện INSERT dữ liệu vào bảng ChiTietDonDat
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertQuery = "INSERT INTO ChiTietDonDat (IdOrder,NgayLap,ThoiGianLap,IdNhanvien,IDGioHang, NameItems, Price, Quantity) SELECT (SELECT TOP 1 IdOrder FROM DonDatItems ORDER BY IdOrder DESC), (SELECT TOP 1 NgayLap FROM DonDatItems ORDER BY IdOrder DESC), (SELECT TOP 1 ThoiGianLap FROM DonDatItems ORDER BY IdOrder DESC), (SELECT TOP 1 IdNhanvien FROM DonDatItems ORDER BY IdOrder DESC), IDItems, NameItems, Price, Quantity FROM GioHang WHERE StatusItems = 'available'";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Cập nhật trạng thái StatusItems thành 'done' và Quantity thành 0 trong bảng GioHang
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE GioHang SET StatusItems = 'done', Quantity = 0 WHERE StatusItems = 'available'";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public DataTable Bill_DA_DAL(string idOrder)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Mở kết nối
                conn.Open();

                // Tạo câu lệnh SQL để lấy dữ liệu từ bảng ChiTietDonDat
                string sql = "SELECT IDGioHang, NameItems, Quantity, Price FROM ChiTietDonDat WHERE IdOrder = @IdOrder";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    // Thêm tham số cho câu lệnh SQL
                    command.Parameters.Add(new SqlParameter("@IdOrder", idOrder));

                    // Thực hiện câu lệnh SQL và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Đọc dữ liệu từ SqlDataReader vào DataTable
                        dataTable.Load(reader);
                    }
                }

                // Đóng kết nối
                conn.Close();
            }

            return dataTable;
        }

        public void AddToSupportingCart_DA_DAL()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertQuery = "insert into SupportingCart(IDItems,NameItems,Price,Quantity) (Select IDItems,NameItems,Price,Quantity from GioHang where StatusItems='available')";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void AddToBill_DA_DAL(string IdOrder, string NgayLap, string ThoiGian, string IdNhanvien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string selectQuery = "SELECT IDItems, NameItems, Price, Quantity FROM SupportingCart";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, conn))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string IDItems = reader["IDItems"].ToString();
                            string NameItems = reader["NameItems"].ToString();
                            int Price = (int)reader["Price"];
                            int Quantity = (int)reader["Quantity"];
                          
                            // Kiểm tra xem mặt hàng này đã tồn tại trong ChiTietDonDat hay chưa
                            string checkQuery = "SELECT COUNT(*) FROM ChiTietDonDat WHERE IDGioHang = @IDGioHang and IdOrder=@IdOrder";
                            // string checkQuery = "SELECT COUNT(*) FROM ChiTietDonDat WHERE IDGioHang = @IDGioHang and IdOrder=@IdOrder";
                            using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                            {
                                checkCommand.Parameters.AddWithValue("@IDGioHang", IDItems);
                                checkCommand.Parameters.AddWithValue("@IdOrder", IdOrder);
                                int existingRows = (int)checkCommand.ExecuteScalar();

                                string query;
                                if (existingRows > 0)
                                {
                                    // Nếu mặt hàng đã tồn tại, cập nhật số lượng
                                    query = "UPDATE ChiTietDonDat SET Quantity = Quantity + @Quantity WHERE IDGioHang = @IDGioHang and IdOrder=@IdOrder";
                                }
                                else
                                {
                                    // Nếu mặt hàng chưa tồn tại, chèn một hàng mới
                                    query = "INSERT INTO ChiTietDonDat (IdOrder, NgayLap, ThoiGianLap, IdNhanvien, IDGioHang, NameItems, Price, Quantity) VALUES (@IdOrder, @NgayLap, @ThoiGian, @IdNhanvien, @IDGioHang, @NameItems, @Price, @Quantity)";
                                }

                                using (SqlCommand command = new SqlCommand(query, conn))
                                {
                                    command.Parameters.AddWithValue("@IdOrder", IdOrder);
                                    command.Parameters.AddWithValue("@NgayLap", NgayLap);
                                    command.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                                    command.Parameters.AddWithValue("@IdNhanvien", IdNhanvien);
                                    command.Parameters.AddWithValue("@IDGioHang", IDItems);
                                    command.Parameters.AddWithValue("@NameItems", NameItems);
                                    command.Parameters.AddWithValue("@Price", Price);
                                    command.Parameters.AddWithValue("@Quantity", Quantity);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE GioHang SET StatusItems = 'done', Quantity = 0 WHERE StatusItems = 'available'";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM SupportingCart";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void HuyDon_DA_DAL(string IdOrder)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL UPDATE statement to update the Trangthai field to 'cancel' for the records with the corresponding IdOrder
                string sqlUpdate = "UPDATE ChiTietDonDat SET Trangthai = 'cancel' WHERE IdOrder = @IdOrder";

                using (SqlCommand command = new SqlCommand(sqlUpdate, connection))
                {
                    command.Parameters.AddWithValue("@IdOrder", IdOrder); // Add the @IdOrder parameter

                    command.ExecuteNonQuery();
                }

                // SQL SELECT statement to retrieve the rows from ChiTietDonDat with the corresponding IdOrder
                string sqlSelect = "SELECT IDGioHang, Quantity FROM ChiTietDonDat WHERE IdOrder = @IdOrder";

                using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                {
                    command.Parameters.AddWithValue("@IdOrder", IdOrder); // Add the @IdOrder parameter

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the rows of ChiTietDonDat
                        while (reader.Read())
                        {
                            // Retrieve the IDGioHang and Quantity values
                            string IDGioHang = reader.GetString(0);
                            int Quantity = reader.GetInt32(1);

                            // SQL UPDATE statement to add the Quantity of ChiTietDonDat to the Quantity of Items for the current row
                            string sqlUpdateQuantity = "UPDATE Items SET Quantity = Quantity + @Quantity, TrangThai = 'available' WHERE ID = @IDGioHang";

                            using (SqlCommand updateCommand = new SqlCommand(sqlUpdateQuantity, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Quantity", Quantity);
                                updateCommand.Parameters.AddWithValue("@IDGioHang", IDGioHang);

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        public void Thanhtoan_DA_DAL(string IdOrder)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Câu lệnh SQL UPDATE để cập nhật trường Trangthai thành 'cancel' cho bản ghi có IdOrder tương ứng
                string sqlUpdate = "UPDATE ChiTietDonDat SET Trangthai = 'done' WHERE IdOrder = @IdOrder";

                using (SqlCommand command = new SqlCommand(sqlUpdate, connection))
                {
                    command.Parameters.AddWithValue("@IdOrder", IdOrder); // Thêm tham số @IdOrder

                    command.ExecuteNonQuery();
                }
            }
        }

      
        public void DeleteItems_DA_DAL(string idGioHang, int quantity, string IdOrder)
        {
            string deleteQuery = "DELETE FROM ChiTietDonDat WHERE IDGioHang = @IDGioHang AND IdOrder = @IdOrder";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Xóa dữ liệu liên quan đến idGioHang và IdOrder trong bảng ChiTietDonDat
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@IDGioHang", idGioHang);
                deleteCommand.Parameters.AddWithValue("@IdOrder", IdOrder);
                deleteCommand.ExecuteNonQuery();

                // Tăng số lượng và cập nhật trạng thái trong bảng Items
                string updateQuery = "UPDATE Items SET Quantity = Quantity + @quantity, TrangThai = 'active' WHERE ID = @ID";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@quantity", quantity);
                updateCommand.Parameters.AddWithValue("@ID", idGioHang);
                updateCommand.ExecuteNonQuery();
            }
        }

        public void TichDiem_DA_DAL(int sdt)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra xem sdt đã có trong bảng PhieuTichDiem chưa
                string checkQuery = "SELECT COUNT(*) FROM PhieuTichDiem WHERE Id = @sdt";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@sdt", sdt);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Nếu đã có, kiểm tra xem số điểm hiện tại có bằng 10 không
                        string selectQuery = "SELECT Diem FROM PhieuTichDiem WHERE Id = @sdt";
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@sdt", sdt);
                            int currentPoints = (int)selectCommand.ExecuteScalar();

                            if (currentPoints < 10)
                            {
                                // Nếu số điểm hiện tại nhỏ hơn 10, thực hiện cập nhật số điểm
                                string updateQuery = "UPDATE PhieuTichDiem SET Diem = Diem + 1 WHERE Id = @sdt";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@sdt", sdt);
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Nếu số điểm hiện tại bằng 10, hiển thị thông báo
                                if (MessageBox.Show("Số điểm hiện tại đã đạt tối đa.\nVui lòng đổi điểm sang mã giảm giá.", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                                {
                                    // Kiểm tra xem Id đã có trong bảng Voucher chưa
                                    string checkVoucherQuery = "SELECT COUNT(*) FROM Voucher WHERE MaVoucher = @sdt";
                                    using (SqlCommand checkVoucherCommand = new SqlCommand(checkVoucherQuery, connection))
                                    {
                                        checkVoucherCommand.Parameters.AddWithValue("@sdt", sdt);
                                        int voucherCount = (int)checkVoucherCommand.ExecuteScalar();

                                        if (voucherCount > 0)
                                        {
                                            // Nếu đã có, thực hiện cập nhật số lượng voucher và đặt lại điểm
                                            string updateVoucherQuery = "UPDATE Voucher SET SoLuongVoucher = SoLuongVoucher + 1 WHERE MaVoucher = @sdt";
                                            using (SqlCommand updateVoucherCommand = new SqlCommand(updateVoucherQuery, connection))
                                            {
                                                updateVoucherCommand.Parameters.AddWithValue("@sdt", sdt);
                                                updateVoucherCommand.ExecuteNonQuery();
                                            }

                                            string resetPointsQuery = "UPDATE PhieuTichDiem SET Diem = 0 WHERE Id = @sdt";
                                            using (SqlCommand resetPointsCommand = new SqlCommand(resetPointsQuery, connection))
                                            {
                                                resetPointsCommand.Parameters.AddWithValue("@sdt", sdt);
                                                resetPointsCommand.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            // Nếu chưa có, thực hiện chèn dữ liệu mới vào bảng Voucher và đặt lại điểm
                                            string insertVoucherQuery = "INSERT INTO Voucher (MaVoucher, SoLuongVoucher) VALUES (@sdt, 1)";
                                            using (SqlCommand insertVoucherCommand = new SqlCommand(insertVoucherQuery, connection))
                                            {
                                                insertVoucherCommand.Parameters.AddWithValue("@sdt", sdt);
                                                insertVoucherCommand.ExecuteNonQuery();
                                            }

                                            string resetPointsQuery = "UPDATE PhieuTichDiem SET Diem = 0 WHERE Id = @sdt";
                                            using (SqlCommand resetPointsCommand = new SqlCommand(resetPointsQuery, connection))
                                            {
                                                resetPointsCommand.Parameters.AddWithValue("@sdt", sdt);
                                                resetPointsCommand.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Nếu sdt chưa có trong bảng PhieuTichDiem, thực hiện chèn dữ liệu mới
                        string insertQuery = "INSERT INTO PhieuTichDiem (Id, Diem) VALUES (@sdt, 1)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@sdt", sdt);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public string LayDiem_DA_DAL(int sdt)
        {
            string diem="" ;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn điểm dựa trên số điện thoại
                string query = "SELECT Diem FROM PhieuTichDiem WHERE Id = @sdt";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sdt", sdt);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        diem = result.ToString();
                    }
                }
            }

            return diem;
        }

        public void TaoHoaDon_DA_DAL(string IdNhanvien)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AutoIncrementHoaDon", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số và truyền giá trị
                    command.Parameters.AddWithValue("@IdNhanvien", IdNhanvien);

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();
                }
            }
        }

        public void HoaDon_DA_DAL(string IdOrder)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get the latest HoaDon
                string sqlQuery = "SELECT TOP 1 * FROM HoaDon ORDER BY NgayLap DESC, ThoiGianLap DESC";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string HD_IDHoaDon = reader["IDHoaDon"].ToString();
                    string HD_NgayLap = reader["NgayLap"].ToString();
                    string HD_ThoiGian = reader["ThoiGianLap"].ToString();
                    string HD_IdNhanvien = reader["IdNhanvien"].ToString();

                    reader.Close();

                    // Check if the data already exists in ChiTietHoaDon
                    sqlQuery = "SELECT COUNT(*) FROM ChiTietHoaDon WHERE IdOrder = @IdOrder";
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@HD_IDHoaDon", HD_IDHoaDon);
                    cmd.Parameters.AddWithValue("@IdOrder", IdOrder);

                    int count = (int)cmd.ExecuteScalar();

                    // If the data does not exist, insert into ChiTietHoaDon
                    if (count == 0)
                    {
                        sqlQuery = "INSERT INTO ChiTietHoaDon (HD_IDHoaDon, HD_NgayLap, HD_ThoiGian, HD_IdNhanvien, IdOrder, IDGioHang, NameItems, Price, Quantity) SELECT @HD_IDHoaDon, @HD_NgayLap, @HD_ThoiGian, @HD_IdNhanvien, IdOrder, IDGioHang, NameItems, Price, Quantity FROM ChiTietDonDat WHERE IdOrder = @IdOrder";
                        cmd = new SqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@HD_IDHoaDon", HD_IDHoaDon);
                        cmd.Parameters.AddWithValue("@HD_NgayLap", HD_NgayLap);
                        cmd.Parameters.AddWithValue("@HD_ThoiGian", HD_ThoiGian);
                        cmd.Parameters.AddWithValue("@HD_IdNhanvien", HD_IdNhanvien);
                        cmd.Parameters.AddWithValue("@IdOrder", IdOrder);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                   
                }
            }
        }

        public DataTable HoaDonDADAL(string IdOrder)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT TOP 1 HD_IDHoaDon, HD_NgayLap, HD_ThoiGian,HD_IdNhanvien FROM ChiTietHoaDon WHERE IdOrder = @IdOrder ORDER BY HD_IDHoaDon DESC;";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@IdOrder", IdOrder);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
        public DataTable ListHoaDon_DA_DAL(string IdHoaDon)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Mở kết nối
                conn.Open();

                // Tạo câu lệnh SQL để lấy dữ liệu từ bảng ChiTietDonDat
                string sql = "SELECT NameItems, Quantity, Price FROM ChiTietHoaDon WHERE HD_IDHoaDon = @IdHoaDon";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    // Thêm tham số cho câu lệnh SQL
                    command.Parameters.Add(new SqlParameter("@IdHoaDon", IdHoaDon));

                    // Thực hiện câu lệnh SQL và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Đọc dữ liệu từ SqlDataReader vào DataTable
                        dataTable.Load(reader);
                    }
                }

                // Đóng kết nối
                conn.Close();
            }

            return dataTable;
        }
        public string tinhTongTien_DA_DAL(string IdHoaDon)
        {
            int tongTien = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT SUM(Price) AS TongTien FROM ChiTietHoaDon WHERE HD_IDHoaDon = @IdHoaDon;";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@IdHoaDon", IdHoaDon);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        tongTien = Convert.ToInt32(result);
                    }
                }
                conn.Close();
            }
            return tongTien.ToString();
        }
        public string LaySoLuongVoucher_DA_DAL(int sdt)
        {
            string soLuongVoucher = string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT SoLuongVoucher FROM Voucher WHERE MaVoucher = @sdt;";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        soLuongVoucher = result.ToString();
                    }
                    else
                    {
                        //soLuongVoucher = "Không tìm thấy Mã Giảm Giá";
                        MessageBox.Show("Không tìm thấy Mã Giảm Giá");
                        soLuongVoucher = "0";
                    }
                }
                conn.Close();
            }
            return soLuongVoucher;
        }

        public void ApplyVoucher_DA_DAL(string idHD,string sdt, string soLuongVoucher)
        {
            int quantityOfVoucher=int.Parse(soLuongVoucher);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "UPDATE ChiTietHoaDon SET Voucher =Voucher + @soLuongVoucher WHERE HD_IDHoaDon = @idHD;";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@soLuongVoucher", quantityOfVoucher);
                    cmd.Parameters.AddWithValue("@idHD", idHD);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "UPDATE Voucher SET SoLuongVoucher = SoLuongVoucher - @quantityOfVoucher WHERE MaVoucher = @sdt;";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@quantityOfVoucher", quantityOfVoucher);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Áp dụng mã giảm giá thành công.");
        }
        public int SoLuongVoucher_DA_DAL(string idHoaDon)
        {
            int voucher = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT Voucher FROM ChiTietHoaDon WHERE HD_IDHoaDon = @idHoaDon;";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            voucher = reader.GetInt32(0);
                        }
                    }
                }
                conn.Close();
            }
            return voucher;
        }
        public void ThemVaoDoanhThu_DA_DAL(string IdHoaDon, string GhiChu,string tenNhanvien, double TongTienHD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("InsertDoanhThu", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số và giá trị tương ứng
                command.Parameters.AddWithValue("@HD_IDHoaDon", IdHoaDon);
                command.Parameters.AddWithValue("@TenNhanvien", tenNhanvien);
                command.Parameters.AddWithValue("@GhiChu", GhiChu);
                command.Parameters.AddWithValue("@TongtienHD", TongTienHD);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi khi thực thi stored procedure
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        public DataTable DoanhThu_DA_DAL(string startDateString, string endDateString)
        {
            DataTable doanhThuTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT HD_IDHoaDon, CONVERT(varchar, NgayLap, 101) AS NgayLap,TenNhanvien, TongtienHD, GhiChu FROM DoanhThu WHERE NgayLap >= CONVERT(varchar, @startDate, 101) AND NgayLap <= CONVERT(varchar, @endDate, 101)";

                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDateString);
                    cmd.Parameters.AddWithValue("@endDate", endDateString);

                    // Thực hiện câu lệnh SQL và lấy dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Đọc dữ liệu từ SqlDataReader vào DataTable
                        doanhThuTable.Load(reader);
                    }
                }

                conn.Close();
            }

            // Kiểm tra số hàng trong doanhThuTable
            if (doanhThuTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu.");
            }

            return doanhThuTable;
        }
        public int TongDoanhThu_DA_DAL(string startDateString,string endDateString)
        {
            int tongDoanhThu = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sSQL = "SELECT SUM(TongtienHD) FROM DoanhThu WHERE NgayLap >= CONVERT(date, @startDate, 101) AND NgayLap <= CONVERT(date, @endDate, 101)";
                using (SqlCommand cmd = new SqlCommand(sSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDateString.ToString());
                    cmd.Parameters.AddWithValue("@endDate", endDateString.ToString());

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        tongDoanhThu = Convert.ToInt32(result);
                    }
                }
                conn.Close();
            }

            return tongDoanhThu;
        }
    }
 }

    
