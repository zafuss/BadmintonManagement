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

	constraint PK_SERVICE_DETAIL_ServiceID primary key (ServiceID)
)
go

create table SERVICE_RECEIPT
(
	ServiceReceiptNo	nvarchar(20),
	CreateDate			datetime,
	Total				decimal,

	constraint PK_SERVICE_RECEIPT_ServiceReceiptNo primary key (ServiceReceiptNo)
)
go

create table SERVICE_DETAIL
(
	ServiceReceiptNo	nvarchar(20),
	ServiceID			nvarchar(20),
	Quantity			int,
	PhoneNumber		varchar(13),
	
	constraint FK_SERVICE_DETAIL_Customer	 foreign key  (PhoneNumber) references CUSTOMER,
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

