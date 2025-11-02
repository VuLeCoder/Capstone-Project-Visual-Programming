--drop database Schedule
create database Schedule
go

use Schedule
go

--create table
create table tbl_TimeSlot (
	timeStr     varchar(10)     not null,
	timeVal     decimal(4, 2)   not null,

	primary key(timeStr)
)

create table tbl_User (
    UserId          int IDENTITY(1,1)   not null,
    UserName        nvarchar(100),
    Email           varchar(255)        unique not null,
    PasswordHash    varchar(255)        not null,

    primary key(UserId)
);

create table tbl_Group (
    GroupId         int identity(1, 1)  not null,
    GroupName       nvarchar(100)       default 'No Name',
    Description     nvarchar(255),
    CreatedBy       int                 not null,

    primary key (GroupId),
    foreign key (CreatedBy) references tbl_User(UserId)
);

create table tbl_ScheduleType (
    TypeId          int identity(1, 1)  not null,
    TypeName        nvarchar(100)       not null,
    Description     nvarchar(255),
    ColorCode       varchar(7)          not null,

    primary key (TypeId)
);

create table tbl_Schedule (
    ScheduleId      int identity(1, 1)  not null,
    UserId          int                 not null,
    GroupId         int,
    TypeId          int                 default 1,
    Title           nvarchar(100)       default 'No Title',
    ScheduleDate    datetime            not null,
    StartTime       decimal(4, 2)       not null,
    EndTime         decimal(4, 2)       not null,

    primary key (ScheduleId),
    foreign key (UserId) references tbl_User(UserId),
    foreign key (GroupId) references tbl_Group(GroupId),
    foreign key (TypeId) references tbl_ScheduleType(TypeId)
);

create table tbl_ScheduleDetail (
    DetailId        int identity(1, 1)  not null,
    ScheduleId      int                 not null,
    TypeId          int                 not null,
    Notes           nvarchar(MAX),
    
    primary key (DetailId),
    foreign key (ScheduleId) references tbl_Schedule(ScheduleId),
    foreign key (TypeId) references tbl_ScheduleType(TypeId)
);

create table tbl_GroupMember (
    GroupId         int                 not null,
    UserId          int                 not null,
    Role            varchar(50)         default 'Member', -- Leader / Member
    JoinedAt        datetime            default getdate(),

    primary key (GroupId, UserId),
    foreign key (GroupId) references tbl_Group(GroupId),
    foreign key (UserId) references tbl_User(UserId)
);


CREATE TABLE tbl_ScheduleParticipant (
    ScheduleId      int         not null,
    UserId          int         not null,
    ResponseStatus  varchar(20) default 'Pending',  -- Accepted / Declined / Pending
    
    primary key (ScheduleId, UserId),
    foreign key (ScheduleId) references tbl_Schedule(ScheduleId),
    foreign key (UserId) references tbl_User(UserId)
);

create table tbl_ToDoList (
    ToDoId          int identity(1,1) not null,
    UserId          int not null,
    Title           nvarchar(255) not null,
    Description     nvarchar(max),
    Priority        varchar(20) check (Priority in ('Low','Normal','High')) default 'Normal',
    Status          varchar(20) check (Status in ('Pending','InProgress','Completed')) default 'Pending',
    DueDate         datetime not null,
    CreatedAt       datetime default getdate(),

    primary key (ToDoId),
    foreign key (UserId) references tbl_User(UserId)
);


select * from tbl_ToDoList
-- insert into
insert into tbl_TimeSlot (timeStr, timeVal) values
('12:00 AM', 0.00),
('12:15 AM', 0.25),
('12:30 AM', 0.50),
('12:45 AM', 0.75),
('01:00 AM', 1.00),
('01:15 AM', 1.25),
('01:30 AM', 1.50),
('01:45 AM', 1.75),
('02:00 AM', 2.00),
('02:15 AM', 2.25),
('02:30 AM', 2.50),
('02:45 AM', 2.75),
('03:00 AM', 3.00),
('03:15 AM', 3.25),
('03:30 AM', 3.50),
('03:45 AM', 3.75),
('04:00 AM', 4.00),
('04:15 AM', 4.25),
('04:30 AM', 4.50),
('04:45 AM', 4.75),
('05:00 AM', 5.00),
('05:15 AM', 5.25),
('05:30 AM', 5.50),
('05:45 AM', 5.75),
('06:00 AM', 6.00),
('06:15 AM', 6.25),
('06:30 AM', 6.50),
('06:45 AM', 6.75),
('07:00 AM', 7.00),
('07:15 AM', 7.25),
('07:30 AM', 7.50),
('07:45 AM', 7.75),
('08:00 AM', 8.00),
('08:15 AM', 8.25),
('08:30 AM', 8.50),
('08:45 AM', 8.75),
('09:00 AM', 9.00),
('09:15 AM', 9.25),
('09:30 AM', 9.50),
('09:45 AM', 9.75),
('10:00 AM', 10.00),
('10:15 AM', 10.25),
('10:30 AM', 10.50),
('10:45 AM', 10.75),
('11:00 AM', 11.00),
('11:15 AM', 11.25),
('11:30 AM', 11.50),
('11:45 AM', 11.75),
('12:00 PM', 12.00),
('12:15 PM', 12.25),
('12:30 PM', 12.50),
('12:45 PM', 12.75),
('01:00 PM', 13.00),
('01:15 PM', 13.25),
('01:30 PM', 13.50),
('01:45 PM', 13.75),
('02:00 PM', 14.00),
('02:15 PM', 14.25),
('02:30 PM', 14.50),
('02:45 PM', 14.75),
('03:00 PM', 15.00),
('03:15 PM', 15.25),
('03:30 PM', 15.50),
('03:45 PM', 15.75),
('04:00 PM', 16.00),
('04:15 PM', 16.25),
('04:30 PM', 16.50),
('04:45 PM', 16.75),
('05:00 PM', 17.00),
('05:15 PM', 17.25),
('05:30 PM', 17.50),
('05:45 PM', 17.75),
('06:00 PM', 18.00),
('06:15 PM', 18.25),
('06:30 PM', 18.50),
('06:45 PM', 18.75),
('07:00 PM', 19.00),
('07:15 PM', 19.25),
('07:30 PM', 19.50),
('07:45 PM', 19.75),
('08:00 PM', 20.00),
('08:15 PM', 20.25),
('08:30 PM', 20.50),
('08:45 PM', 20.75),
('09:00 PM', 21.00),
('09:15 PM', 21.25),
('09:30 PM', 21.50),
('09:45 PM', 21.75),
('10:00 PM', 22.00),
('10:15 PM', 22.25),
('10:30 PM', 22.50),
('10:45 PM', 22.75),
('11:00 PM', 23.00),
('11:15 PM', 23.25),
('11:30 PM', 23.50),
('11:45 PM', 23.75),
('00:00 PM', 24);

insert into tbl_User (UserName, Email, PasswordHash)
values
('VuLe', '1', '1')

insert into tbl_ScheduleType (TypeName, Description, ColorCode)
values 
    ('Study', '', '#42A5F5'),
    ('Meeting', 'Regular team meeting to discuss progress', '#FF5733')

insert into tbl_ToDoList (UserId, Title, Description, Priority, Status, DueDate)
values
(1, N'Gọi điện cho khách hàng A', N'Thảo luận về gia hạn hợp đồng.', 'Normal', 'Pending', '2025-11-02 09:00:00'),
(1, N'Hoàn thành báo cáo quý', N'Viết báo cáo tổng kết quý 4.', 'High', 'InProgress', '2025-11-04 17:00:00'),
(1, N'Đẩy code lên production', N'Merge branch "feature-xyz" vào main và deploy.', 'Low', 'Completed', '2025-11-06 14:00:00');
