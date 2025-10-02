
# Ứng Dụng Quản Lý Cửa Hàng Thuốc Windows Form (.NET)

Phần mềm quản lý cửa hàng thuốc - Ứng dụng desktop được thiết kế cho nhân viên và quản trị viên nhằm tối ưu hóa hoạt động của cửa hàng thuốc.

### Instructor
*[Đỗ Như Tài](https://github.com/dntai)*

## Tổng Quan
Dự án Quản Lý Cửa Hàng Thuốc là một giải pháp phần mềm mạnh mẽ, được phát triển để nâng cao và đơn giản hóa quy trình quản lý cửa hàng thuốc. Xây dựng bằng .NET WinForms, C#, và tích hợp SQL Server, ứng dụng này mang đến giao diện thân thiện cho việc quản lý các khía cạnh khác nhau của doanh nghiệp cửa hàng thuốc.

## Tính Năng

### 1. Xác Thực và Phân Quyền Quản Trị Viên
- Chức năng đăng nhập an toàn dành cho quản trị viên để truy cập và quản lý cơ sở dữ liệu.
- Phân quyền truy cập theo vai trò để đảm bảo mức độ ủy quyền phù hợp.

### 2. Quản Lý Sản Phẩm
- Thêm, sửa hoặc xóa các sản phẩm dược phẩm khỏi kho.
- Phân loại sản phẩm để tối ưu hóa hoạt động.
- Theo dõi mức tồn kho và nhận thông báo khi hết hàng.

### 3. Quản Lý Khách Hàng và Đơn Hàng
- Quản lý thông tin khách hàng, bao gồm hồ sơ và lịch sử mua hàng.
- Xử lý đơn hàng hiệu quả, ghi nhận chi tiết về các thuốc kê đơn hoặc không kê đơn (OTC).

### 4. Quản Lý Nhân Viên
- Thêm, cập nhật và quản lý hồ sơ nhân viên.
- Định nghĩa vai trò và trách nhiệm của nhân viên.

### 5. Bán Hàng và Báo Cáo
- Ghi nhận giao dịch bán hàng hàng ngày và tạo báo cáo chi tiết.
- Theo dõi mức tồn kho và tạo gợi ý đặt hàng lại.

### 6. Lập Hóa Đơn và Thanh Toán
- Tạo và in hóa đơn cho khách hàng.

## Công Nghệ 🔧
- **Ngôn Ngữ Lập Trình:** C#
- **Framework Giao Diện Người Dùng:** .NET WinForms
- **Công Nghệ Truy Cập Dữ Liệu:** ADO .NET
- **Cơ Sở Dữ Liệu:** Microsoft SQL Server 2019
- **Quản Lý Phiên Bản:** Git, GitHub
- **Môi Trường Phát Triển Tích Hợp (IDE):** Visual Studio 2022

## Hướng Dẫn Cài Đặt ✔️
Trước khi bắt đầu, hãy đảm bảo rằng các yêu cầu sau đã được cài đặt:

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs) - IDE để phát triển ứng dụng trên nền tảng .NET Framework.
- [.NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481).
- [Docker Desktop](https://www.docker.com/products/docker-desktop/) - Môi trường ảo.

**Cài SQL Server 2019 trên Docker:**

1. Tải image SQL Server 2019 :

   Vào mục Terminal trong Docker và chạy lệnh sau:

   ```bash
   docker pull mcr.microsoft.com/mssql/server:2019-latest
   ```

2. Tạo container SQL Server 2019 :
   Đảm bảo bạn đã cài đặt Docker Desktop. Sau đó chạy lệnh sau để tải và khởi động SQL Server 2019 trong container:

   ```bash
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Thanhtuan@123" -p 1433:1433 --name sqlserver2019 -d mcr.microsoft.com/mssql/server:2019-latest
   ```

   - `SA_PASSWORD`: Thay thế bằng mật khẩu mạnh bạn muốn sử dụng. Ở đây mình xài pass là "Thanhtuan@123".
   - `1433`: Đây là cổng mặc định để kết nối SQL Server.

3. Kiểm tra container đang chạy:

   Kiểm tra xem container SQL Server có hoạt động không:

   ```bash
   docker ps
   ```

4. Kết nối SQL Server bằng SQL Server Management Studio (SSMS):

   - **Server Name:** `localhost,1433`
   - **Authentication:** SQL Server Authentication
   - **Login:** `sa`
   - **Password:** Mật khẩu bạn đã thiết lập ở bước 2.

5. Thêm Cơ Sở Dữ Liệu:

   - Kết nối đến SQL Server và thả file DataCreate.sql vào và bấm execute (F5):

6. Cấu Hình Chuỗi Kết Nối Trong Ứng Dụng (nếu như bạn muốn thay đổi password) :

   - Cập nhật chuỗi kết nối trong ứng dụng để trỏ đến SQL Server trong container Docker:
   - Về phần này nó sẽ nằm trong file DataProvider.cs và thay thế trong connectionstring

     ```csharp
     "Data Source=localhost,1433;Initial Catalog=quanlycuahangthuoc;Persist Security Info=True;User ID=sa;Password=Thanhtuan@123;"
     ```

7. Clone repository:
   ```bash
   # Sử dụng HTTPS
   git clone https://github.com/CallmeSen/QuanLyTiemThuocSGU.git

   # Sử dụng SSH
   git clone git@github.com:CallmeSen/QuanLyTiemThuocSGU.git
   ```

8. Mở dự án trong Visual Studio.

9. Build và chạy ứng dụng.

## Ảnh Màn Hình 📸
<div align="center">
    <img src="https://github.com/user-attachments/assets/1ee87c27-97ae-4e18-9e36-ad7f41b22a40" alt="Screenshot 1" width="600">
</div>

<div align="center">
    <img src="https://github.com/user-attachments/assets/f95bfbb4-1126-4aa7-99d1-31388a4fcbe2" alt="Screenshot 2" width="600">
</div>

<div align="center">
    <img src="https://github.com/user-attachments/assets/13b76a0a-dc08-4219-a8f9-5cf27c775c93" alt="Screenshot 3" width="600">
</div>

<div align="center">
    <img src="https://github.com/user-attachments/assets/e4955952-9daf-4353-b9e6-f96b75f553b6" alt="Screenshot 4" width="600">
</div>

<div align="center">
    <img src="https://github.com/user-attachments/assets/804eebb2-a4c9-4d21-a87b-8340253b81d6" alt="Screenshot 5" width="600">
</div>

<div align="center">
    <img src="https://github.com/user-attachments/assets/ff8aaeec-afb6-45ed-8411-bb8c6c0183cf" alt="Image 1" width="600">
</div>

<div align="center">
    <img src="https://github.com/user-attachments/assets/32345477-1901-4a27-9e18-f95d6928c72f" alt="Image 2" width="600">
</div>

## Về Nhóm Dự Án 🤝
- **Developer:** *[CallmeSen](https://github.com/CallmeSen)*
- **Developer:** *[Nguyen Huynh Phuong Loc](https://github.com/nguyenhuynhphuongloc)*
