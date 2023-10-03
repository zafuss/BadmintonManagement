create database BadmintonManagementDB
go

use BadmintonManagementDB
go

create table CUSTOMER
(
	PhoneNumber		varchar(13),
	FullName		nvarchar(100),
	Email			nvarchar(100),

	constraint CUSTOMER_PK primary key(PhoneNumber)
)
go

create table PRICE
(
	PriceID		varchar(20),
	PriceTag	decimal,
	TimeFactor	float,
	DateFactor	float,

	constraint PRICEID_PK primary Key (PriceID)
)
go

create table _USER(
	Username	nvarchar(50),
	_Password	nvarchar(50),
	_Name		nvarchar(100),
	_Role		nvarchar(30),
	Email		varchar(60),
	PhoneNumber varchar(13),
	_Status		nvarchar(30),

	constraint Username_PK primary key (Username)	
)
go

create table RESERVATION
(
	ReservationNo	nvarchar(20),
	Username		nvarchar(50),
	PhoneNumber		varchar(13),
	Deposite		decimal,
	CreateDate		datetime,
	BookingDate		datetime,
	_Status			int,

	constraint RESERVATION_PK primary key(ReservationNo),
	constraint CUSTOMER_FK foreign key (PhoneNumber) references CUSTOMER(PhoneNumber),
	constraint _USER_FK foreign key (Username) references _USER(Username)
)
go

create table BRANCH (
	BranchID	nvarchar(20),
	BranchName	nvarchar(50),
	_Address	nvarchar(50),

	constraint BRANCH_PK  primary key (BranchID)
) 
go

create table COURT (
	CourtID		nvarchar(20),
	CourtName	nvarchar(50),
	_Status		nvarchar(30), 
	StartDate	datetime,
	BranchID	nvarchar(20),

	constraint COURT_PK  primary key (CourtID) ,
	constraint BRANCH_FK_BRANCH foreign key (BranchID) references BRANCH(BranchID)
)
go

create table _SERVICE
(
	ServiceID		nvarchar(20),
	ServiceName		nvarchar(100),
	Unit			nvarchar(20),
	Price			decimal,
	Quantity		int,
	_Status			varchar(30)
	constraint PK_SERVICE_DETAIL_ServiceID primary key (ServiceID)
)
go

create table SERVICE_RECEIPT
(
	ServiceReceiptNo	nvarchar(20),
	CreateDate			datetime,
	Total				decimal,
	PhoneNumber			varchar(13),

	constraint FK_SERVICE_RECEIPT_Customer	 foreign key  (PhoneNumber) references CUSTOMER,
	constraint PK_SERVICE_RECEIPT_ServiceReceiptNo primary key (ServiceReceiptNo)
)
go

create table SERVICE_DETAIL
(
	ServiceReceiptNo	nvarchar(20),
	ServiceID			nvarchar(20),
	Quantity			int,
	
	constraint PK_SERVICE_DETAIL_ServiceReeiptNo primary key  (ServiceReceiptNo,ServiceID),
	constraint FK_SERVICE_DETAIL_ServiceReceiptNo foreign key  (ServiceReceiptNo) references SERVICE_RECEIPT,
	constraint FK_SERVICE_DETAIL_ServiceID	 foreign key  (ServiceID) references _SERVICE ,
)
go

create table RF_DETAIL(
	ReservationNo	nvarchar(20),
	CourtID			nvarchar(20),
	StartTime		DateTime,
	EndTime			DateTime,
	PriceID			varchar(20),

	constraint PK_RF_DETAIL primary key(ReservationNo, CourtID) ,
	constraint FK_ReservationNo foreign key (ReservationNo) references RESERVATION(ReservationNo),
	constraint FK_CourtID foreign key (CourtID) references COURT(CourtID),
	constraint FK_CourtID_PRICE foreign key (PriceID) references PRICE(PriceID)
)
go

create table RECEIPT(
	ReceiptNo			nvarchar(20),
	_Date				datetime,
	Total				decimal,
	ExtraTime			float,
	ReservationNo		nvarchar(20),	

	constraint PK_ReceiptNo primary key (ReceiptNo),
	constraint FK_ReservationNo_ foreign key (ReservationNo) references RESERVATION(ReservationNo),
)
go

set dateformat DMY

insert into CUSTOMER values ('337514097',N'Đậu Văn Nghĩa',N'nghiadauvan@gmail.com')
insert into CUSTOMER values ('984263841',N'Đặng Hoàng Gia Phú',N'zafus2103@gmail.com')
insert into CUSTOMER values ('912371232',N'Nguyễn Hoàng Long',N'long823652@gmail.com')
insert into CUSTOMER values ('337514096',N'Trần Tuấn Kiệt',N'tuankiet061203@gmail.com')

insert into PRICE values ('P001',40000,	1.25,1.5)
insert into PRICE values ('P002',	500000,	1.25,1.5)

insert into _USER values (N'admin', N'CinA5MJWDvBTvOJSvluE4g==', N'admin', N'Admin', 'todsdreamcompany@gmail.com', '823216213' , N'Enabled')	
insert into _USER values (N'cauvang', N'XRzJdOMLLZLn1vXjWu7kiQ==', N'Nguyễn Bá Khánh Trình', N'Staff', 'khanhtrinh123oki@gmail.com', '963788076' , N'Enabled')
insert into _USER values (N'staff', N'50clNoCb9AMObQO+OKsiBA==', N'staff', N'Staff', 'todstaff@gmail.com', '963788077' , N'Enabled')		
insert into _USER values (N'vannghia', N'CbsPi4IZBrPiEj0EvRLllQ==', N'Đậu Văn Nghĩa', N'Staff', 'nghiadauvan@gmail.com', '337514097' , N'Enabled')	

insert into _SERVICE values (N'SV01',	N'Nước lọc Là vì e',N'Lon'	,10.000	,1)
insert into _SERVICE values (N'SV02',	N'Thuê vợt',N'Cái '	,100.000	,1)
insert into _SERVICE values (N'SV03',	N'CoCaCola',N'chai'	,10000	,1)
insert into _SERVICE values (N'SV04',	N'Mua cầu',N'Quả'	,20000	,1)

insert into BRANCH values (N'BT001',N'Bình Thạnh',N'Gần Hutech')
insert into BRANCH values (N'TD001',N'Thủ Đức',N'Long Trường Quận 9')

insert into COURT values (N'SBT001',N'Sân Bình Thạnh 1',N'Used',CONVERT(datetime ,'17-10-23 10:34:09 AM',5 ) , N'BT001')
insert into COURT values (N'SBT002',N'Sân Bình Thạnh 2',N'Use',CONVERT(datetime ,'20-10-23 09:34:09 AM',5 ) , N'BT001')
insert into COURT values (N'SBT003',N'Sân Bình Thạnh 3',N'Disable',CONVERT(datetime ,'25-10-23 08:34:09 AM',5 )  , N'BT001')
insert into COURT values (N'SBT004',N'Sân Bình Thạnh 4',N'Used',CONVERT(datetime ,'12-11-23 12:34:09 AM',5 ) , N'BT001')
insert into COURT values (N'SBT005',N'Sân Bình Thạnh 5',N'Maintaince',CONVERT(datetime ,'12-11-23 10:34:09 AM',5 ) , N'BT001')
insert into COURT values (N'SBT006',N'Sân Bình Thạnh 6',N'Used',CONVERT(datetime ,'12-11-23 07:34:09 AM',5 ) , N'BT001')
insert into COURT values (N'STD001',N'Sân Thủ Đức 1',N'Used',CONVERT(datetime ,'7-12-24 06:34:09 AM',5 ) , N'TD001')
insert into COURT values (N'STD002',N'Sân Thủ Đức 2',N'Used',CONVERT(datetime ,'11-12-24 15:34:09 PM',5 ) , N'TD001')
insert into COURT values (N'STD003',N'Sân Thủ Đức 3',N'Maintaince',CONVERT(datetime ,'15-12-24 16:34:09 PM',5 ) , N'TD001')


insert into RESERVATION values (N'6761'	,N'admin'	,'337514097'	,0	,CONVERT(datetime ,'2023-10-02 09:32:25 AM',5)	,CONVERT(datetime ,'2023-10-02 09:31:16 AM',5)	,0)
insert into RESERVATION values (N'7105'	,N'admin'	,'984263841'	,0	,CONVERT(datetime ,'2023-10-01 23:28:54 PM',5)	,CONVERT(datetime ,'2023-10-01 23:28:46 PM',5)	,0)
insert into RESERVATION values (N'8773'	,N'admin'	,'912371232'	,0	,CONVERT(datetime ,'2023-10-02 09:34:04 PM ',5)	,CONVERT(datetime ,'2023-10-02 09:33:53 AM',5)	,0)

insert into RF_DETAIL values (N'6761',	N'SBT001',	CONVERT(datetime ,'2023-10-02 07:00:00 AM',5),	CONVERT(datetime ,'2023-10-02 08:00:00 AM',5),	'P001')
insert into RF_DETAIL values (N'6761',	N'SBT002',	CONVERT(datetime ,'2023-10-02 09:00:00 AM',5),	CONVERT(datetime ,'2023-10-02 10:00:00 AM',5),	'P001')
insert into RF_DETAIL values (N'7105',	N'SBT001',	CONVERT(datetime ,'2023-10-02 13:00:00 PM',5),	CONVERT(datetime ,'2023-10-01 14:00:00 AM',5),	'P001')
insert into RF_DETAIL values (N'8773',	N'SBT003',	CONVERT(datetime ,'2023-10-02 15:00:00 PM',5),	CONVERT(datetime ,'2023-10-02 16:00:00 AM',5),	'P001')


create table RF_DETAIL(
	ReservationNo	nvarchar(20),
	CourtID			nvarchar(20),
	StartTime		DateTime,
	EndTime			DateTime,
	PriceID			varchar(20),

	constraint PK_RF_DETAIL primary key(ReservationNo, CourtID) ,
	constraint FK_ReservationNo foreign key (ReservationNo) references RESERVATION(ReservationNo),
	constraint FK_CourtID foreign key (CourtID) references COURT(CourtID),
	constraint FK_CourtID_PRICE foreign key (PriceID) references PRICE(PriceID)
)
go

