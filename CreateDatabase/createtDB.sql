-- Dự kiến sẽ dùng db này

use LTTQSQL;
go

-- ==========================================
-- XÓA BẢNG NẾU ĐÃ TỒN TẠI (đảm bảo tạo mới)
-- ==========================================
IF OBJECT_ID('Work', 'U') IS NOT NULL DROP TABLE Work;
IF OBJECT_ID('GroupMember', 'U') IS NOT NULL DROP TABLE GroupMember;
IF OBJECT_ID('Group', 'U') IS NOT NULL DROP TABLE [Group];
IF OBJECT_ID('User', 'U') IS NOT NULL DROP TABLE [User];
GO

-- ==========================================
-- 1️⃣ BẢNG USER
-- ==========================================
CREATE TABLE tblUser (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- ==========================================
-- 2️⃣ BẢNG GROUP
-- ==========================================
CREATE TABLE tblGroup (
    GroupId INT PRIMARY KEY IDENTITY(1,1),
    GroupName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CreatedBy) REFERENCES tblUser(UserId)
);
GO

-- ==========================================
-- 3️⃣ BẢNG GROUPMEMBER
-- ==========================================
CREATE TABLE tblGroupMember (
    GroupId INT NOT NULL,
    UserId INT NOT NULL,
    Role NVARCHAR(50) DEFAULT 'Member',
    JoinedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (GroupId, UserId),
    FOREIGN KEY (GroupId) REFERENCES tblGroup(GroupId),
    FOREIGN KEY (UserId) REFERENCES tblUser(UserId)
);
GO

-- ==========================================
-- 4️⃣ BẢNG WORK
-- ==========================================
CREATE TABLE tblWork (
    WorkId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    GroupId INT NULL,
    Title NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    Location NVARCHAR(255),
    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserId) REFERENCES tblUser(UserId),
    FOREIGN KEY (GroupId) REFERENCES tblGroup(GroupId),
    FOREIGN KEY (CreatedBy) REFERENCES tblUser(UserId)
);
GO

-- ==========================================
-- DỮ LIỆU MẪU
-- ==========================================

-- 🧍‍♂️ 10 người dùng
INSERT INTO tblUser (UserName, Email, PasswordHash)
VALUES
('An Nguyen', 'an.nguyen@example.com', 'hash1'),
('Binh Tran', 'binh.tran@example.com', 'hash2'),
('Chi Le', 'chi.le@example.com', 'hash3'),
('Dung Pham', 'dung.pham@example.com', 'hash4'),
('Hanh Vu', 'hanh.vu@example.com', 'hash5'),
('Khoa Do', 'khoa.do@example.com', 'hash6'),
('Lan Phan', 'lan.phan@example.com', 'hash7'),
('Minh Hoang', 'minh.hoang@example.com', 'hash8'),
('Ngoc Nguyen', 'ngoc.nguyen@example.com', 'hash9'),
('Tuan Vo', 'tuan.vo@example.com', 'hash10');
GO

-- 👥 3 nhóm
INSERT INTO tblGroup (GroupName, Description, CreatedBy)
VALUES
('Team Alpha', 'Nhóm phát triển dự án A', 1),
('Team Beta', 'Nhóm marketing', 2),
('Team Gamma', 'Nhóm nghiên cứu', 3);
GO

-- 👤 Thành viên nhóm
INSERT INTO tblGroupMember (GroupId, UserId, Role)
VALUES
(1, 1, 'Leader'),
(1, 2, 'Member'),
(1, 3, 'Member'),
(1, 4, 'Member'),
(1, 5, 'Member'),

(2, 2, 'Leader'),
(2, 6, 'Member'),
(2, 7, 'Member'),
(2, 8, 'Member'),

(3, 3, 'Leader'),
(3, 9, 'Member'),
(3, 10, 'Member');
GO

-- 🗓️ Công việc (5 việc nhóm + 5 việc cá nhân)
INSERT INTO tblWork (UserId, GroupId, Title, Description, StartTime, EndTime, Location, CreatedBy)
VALUES
-- Việc nhóm (GroupId có giá trị)
(2, 1, 'Thiết kế giao diện', 'Tạo mockup trang chủ', '2025-11-02 09:00', '2025-11-02 17:00', 'Phòng A1', 1),
(3, 1, 'Lập trình backend', 'API xử lý dữ liệu', '2025-11-03 08:00', '2025-11-04 17:00', 'Phòng A2', 1),
(6, 2, 'Chiến dịch quảng cáo', 'Thiết kế poster', '2025-11-05 09:00', '2025-11-06 17:00', 'Văn phòng B', 2),
(7, 2, 'Đăng bài truyền thông', 'Lên lịch bài đăng Facebook', '2025-11-07 08:00', '2025-11-07 12:00', 'Văn phòng B', 2),
(9, 3, 'Báo cáo nghiên cứu', 'Viết báo cáo sơ bộ', '2025-11-08 10:00', '2025-11-08 16:00', 'Phòng Lab', 3),

-- Việc cá nhân (GroupId = NULL)
(1, NULL, 'Đọc tài liệu kỹ thuật', 'Tự học về Docker', '2025-11-09 09:00', '2025-11-09 11:00', 'Nhà', 1),
(2, NULL, 'Luyện tập tiếng Anh', 'Xem TED Talk và ghi chú', '2025-11-10 19:00', '2025-11-10 21:00', 'Nhà', 2),
(3, NULL, 'Tập thể dục', 'Chạy bộ 5km', '2025-11-11 06:00', '2025-11-11 06:45', 'Công viên', 3),
(4, NULL, 'Đọc sách', 'Đọc Clean Code', '2025-11-12 20:00', '2025-11-12 22:00', 'Nhà', 4),
(5, NULL, 'Lên kế hoạch tuần tới', 'Ghi chú công việc', '2025-11-13 19:00', '2025-11-13 20:00', 'Nhà', 5);
GO