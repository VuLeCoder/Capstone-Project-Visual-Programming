# 🚀 README — Task & Group Management App

## Thư viện ngoài (cài trên NuGet)
- SunnyUI
- có gì thì gpt để hỏi lại :>

## 📋 Mục lục
- [⚠️ Lỗi và tình trạng các nhánh](#️-lỗi-và-tình-trạng-các-nhánh)
- [🎯 Mục tiêu & Chức năng](#-mục-tiêu--chức-năng)
  - [👤 Individual (Cá nhân)](#-individual-cá-nhân)
  - [👥 Group (Nhóm)](#-group-nhóm)
- [🧠 Chức năng Form GroupSchedule](#-Chức-năng-Form-GroupSchedule)


---

## ⚠️ Lỗi và tình trạng các nhánh

| 🌿 Nhánh | 🧩 Trạng thái | 📌 Ghi chú |
|----------|----------------|------------|
| **`main`** | ✅ Ổn định | Nhánh chính để merge code đã test |
| **`Huy`** | ⚠️ Conflict | Lỗi ở **Form "Xem việc cần làm"** khi merge với `main` |

---

## 🎯 Mục tiêu & Chức năng

### 👤 Individual (Cá nhân)

Form phục vụ cho các tính năng cá nhân của từng người dùng.

| 🧱 Form | 📝 Mô tả | ⚙️ Trạng thái |
|----------|-----------|---------------|
| `Profile` | Thay đổi **tên**, **email**, **mật khẩu** | ✅ Cần làm |
| `Setting` | Cài đặt cá nhân (theme, chế độ, v.v.) | ❌ Có thể bỏ qua |
| `Notification` | Quản lý thông báo cá nhân | 🕒 Làm sau |
| `Xem việc cần làm` | Hiển thị danh sách công việc của user | ⚠️ Conflict với `main` |

---

### 👥 Group (Nhóm)

Form phục vụ các thao tác tương tác nhiều người dùng (leader, member).

| 🧱 Form | 📝 Mô tả | ⚙️ Trạng thái |
|----------|-----------|---------------|
| `Tạo nhóm mới` | Nhập thông tin group mới (theo DB `tbl_Group`) | ✅ Cần làm |
| `Tham gia nhóm` | Nhập **GroupID** để join nhóm có sẵn | ✅ Cần làm |
| `Nhóm đã tham gia` | Danh sách nhóm mà user đã tạo/tham gia | ✅ Có trong `main` (form đen test) |
| `Group_Profile` | Thông tin nhóm & thành viên | 👥 Theo role `leader` / `member` |
| `Xác nhận tham gia` | Khi user click vào lịch nhưng chưa là member | ✅ Cần làm |

---

## 🧠 Chức năng Form GroupSchedule

Khi **người dùng bấm vào một nhóm đã tham gia**, hệ thống sẽ mở form có giao diện tương tự `Form_MySchedule`, chỉ khác nội dung hiển thị.

### 🧩 Giao diện:
| Thành phần | Chức năng |
|-------------|------------|
| 🏷️ **Label “Lịch cá nhân”** | → Hiển thị **tên nhóm** |
| 👑 **Role = Leader** | Hiện nút `Tạo lịch mới` và `Mời thành viên` |
| 👥 **Role = Member** | Chỉ được xem lịch, không chỉnh sửa |
| 🔁 **ComboBox chọn nhóm** | Nằm dưới nút “Quay lại trang chủ” để chuyển nhanh giữa nhóm |

### ⚙️ Chức năng:
- **Hiển thị các lịch có GroupID là nhóm đang xem** trong bảng `tbl_Schedule`
- **Leader**:
  - Tạo / sửa / xóa lịch
  - Kiểm tra trùng lịch với bản thân trước khi thêm mới
  - Cho phép xóa các lịch trùng để thêm mới
- **Member (hoặc chưa tham gia)**:
  - Khi click lịch → hiển thị form **Xác nhận tham gia**
  - Nếu trùng lịch → hỏi có muốn xóa lịch cá nhân để tham gia lịch nhóm không → Nếu có thì cập nhật database (Xóa lịch cũ và thêm lịch mới) (ae check `tbl_Schedule` kỹ để rõ)


---
