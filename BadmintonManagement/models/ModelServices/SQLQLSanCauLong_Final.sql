﻿create database BadmintonManagementDB
go

use BadmintonManagementDB
go
--drop database BadmintonManagementDB
create table CUSTOMER
(
	PhoneNumber		varchar(13) not null,
	FullName		nvarchar(100)not null,
	Email			nvarchar(100)not null,

	constraint CUSTOMER_PK primary key(PhoneNumber)
)
go

create table PRICE
(
	PriceID		varchar(20)not null,
	PriceTag	decimal not null,
	TimeFactor	float not null,
	DateFactor	float not null,
	_Status		int not null,

	constraint PRICEID_PK primary Key (PriceID)
)
go

create table _USER(
	Username	nvarchar(50) not null,
	_Password	nvarchar(50) not null,
	_Name		nvarchar(100) not null,
	_Role		nvarchar(30) not null,
	Email		varchar(60) not null,
	PhoneNumber varchar(13) not null,
	_Status		nvarchar(30) not null,

	constraint Username_PK primary key (Username)	
)
go

create table RESERVATION
(
	ReservationNo	nvarchar(20) not null,
	Username		nvarchar(50) not null,
	PhoneNumber		varchar(13),
	Deposite		decimal,
	CreateDate		datetime not null,
	BookingDate		datetime not null,
	StartTime		DateTime not null,
	EndTime			DateTime not null,
	PriceID			varchar(20) not null,
	_Status			int not null,

	constraint RESERVATION_PK primary key(ReservationNo),
	constraint CUSTOMER_FK foreign key (PhoneNumber) references CUSTOMER(PhoneNumber),
	constraint _USER_FK foreign key (Username) references _USER(Username),
	constraint FK_RESERVATION_PRICE foreign key (PriceID) references PRICE(PriceID)
)
go

create table BRANCH (
	BranchID	nvarchar(20) not null,
	BranchName	nvarchar(50) not null,
	_Address	nvarchar(50) not null,

	constraint BRANCH_PK  primary key (BranchID)
) 
go

create table COURT (
	CourtID		nvarchar(20) not null,
	CourtName	nvarchar(50) not null,
	_Status		nvarchar(30) not null, 
	StartDate	datetime not null,
	BranchID	nvarchar(20) not null,

	constraint COURT_PK  primary key (CourtID) ,
	constraint BRANCH_FK_BRANCH foreign key (BranchID) references BRANCH(BranchID)
)
go

create table _SERVICE
(
	ServiceID		nvarchar(20) not null,
	ServiceName		nvarchar(100) not null,
	Unit			nvarchar(20) not null,
	Price			decimal not null,
	Quantity		int not null,
	_Status			varchar(30) not null,
	constraint PK_SERVICE_DETAIL_ServiceID primary key (ServiceID)
)
go

create table SERVICE_RECEIPT
(
	ServiceReceiptNo	nvarchar(20)  not null,
	CreateDate			datetime not null,
	Total				decimal,
	PhoneNumber			varchar(13),
	Username			nvarchar(50),

	constraint FK_SERVICE_RECEIPT_Customer	 foreign key  (PhoneNumber) references CUSTOMER,
	constraint PK_SERVICE_RECEIPT_ServiceReceiptNo primary key (ServiceReceiptNo),
	constraint PK_SERVICE_USER foreign key (Username) references _USER(Username)
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
	Note			nvarchar(255),

	constraint PK_RF_DETAIL primary key(ReservationNo, CourtID) ,
	constraint FK_ReservationNo foreign key (ReservationNo) references RESERVATION(ReservationNo),
	constraint FK_CourtID foreign key (CourtID) references COURT(CourtID),
	
)
go

create table RECEIPT(
	ReceiptNo			nvarchar(20) not null,
	_Date				datetime not null,
	Total				decimal,
	ExtraTime			float,
	ReservationNo		nvarchar(20),
	Username			nvarchar(50),
	Payment				nvarchar(30)
	constraint PK_ReceiptNo primary key (ReceiptNo),
	constraint FK_ReservationNo_ foreign key (ReservationNo) references RESERVATION(ReservationNo),
	constraint FK_ReservationNo_Usẻ foreign key (Username) references _USER(Username),
)
go

 

select T1.Thang, cast(round((T1.Total/(T1.Total+T.Total))*100,2) as decimal(38,2)) as San,cast((100-round((T1.Total/(T1.Total+T.Total))*100,2)) as decimal(38,2)) as dichvu
from (	select convert(int,Month(R._Date)) as Thang,sum(R.Total) as Total 
		from RECEIPT R
		where convert(varchar,year(R._Date)) = '2023'
		group by convert(int,Month(R._Date))) T1 , (select convert(int ,month(S.CreateDate)) as Thang,sum(S.Total) as Total 
													from SERVICE_RECEIPT S
													where convert(varchar,year(S.CreateDate)) = '2023'
													group by convert(int,Month(S.CreateDate))) T
where T1.Thang = T.Thang and T1.Thang = 1
order by T1.Thang 

select * from COURT
select * 
from RESERVATION re
where DATEPART(DAY, re.StartTime) = DATEPART(DAY, GETDATE()); 


select * 
from RESERVATION re
where DATEPART(WEEK, re.StartTime) = DATEPART(WEEK, GETDATE()); 

select * 
from RESERVATION re
where DATEPART(MONTH, re.StartTime) = DATEPART(MONTH, GETDATE()); 

select c.CourtID,c.CourtName,c.BranchID , c.BranchName , b.FullName, b.PhoneNumber , b.ReservationNo , b.StartTime , b.EndTime , c._Status ,  b._Status
                            from (	select c.CourtID , c.CourtName , c.BranchID , br.BranchName, c._Status
		                            from COURT c , BRANCH br 
		                            where c.BranchID = br.BranchID and c._Status != 'Disable' ) c
                            Left Join (select rf.CourtID , tmp.FullName , tmp.PhoneNumber , rf.ReservationNo,tmp.StartTime,tmp.EndTime , tmp._Status
			                            from RF_DETAIL rf ,		(select reser.ReservationNo , a.FullName , a.PhoneNumber , FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime , reser._Status
									                            from RESERVATION reser , CUSTOMER a
									                            where Cast(reser.StartTime as Date) = Cast(CURRENT_TIMESTAMP  as DATE) and 
									                            FORMAT(CURRENT_TIMESTAMP , 'HH:mm') < FORMAT(reser.EndTime, 'HH:mm') and 
									                            FORMAT(CURRENT_TIMESTAMP , 'HH:mm') >= FORMAT(reser.StartTime, 'HH:mm')  and 
									                            a.PhoneNumber = reser.PhoneNumber ) tmp
			                            where rf.ReservationNo = tmp.ReservationNo
			                            )  b 
                            on b.CourtID = c.CourtID

select reser.ReservationNo , a.FullName , a.PhoneNumber , FORMAT(reser.StartTime, 'HH:mm') as StartTime , 
FORMAT(reser.EndTime, 'HH:mm') as EndTime , reser._Status
from RESERVATION reser , CUSTOMER a
where Cast(reser.StartTime as Date) = Cast(CURRENT_TIMESTAMP  as DATE) and 
FORMAT(CURRENT_TIMESTAMP , 'HH:mm') < FORMAT(reser.EndTime, 'HH:mm') and 
FORMAT(CURRENT_TIMESTAMP , 'HH:mm') >= FORMAT(reser.StartTime, 'HH:mm')  and 
a.PhoneNumber = reser.PhoneNumber


select rf.CourtID
                        from RF_DETAIL rf 
                        where rf.ReservationNo in (select re.ReservationNo 
					                        from RESERVATION re 
					                        where Cast(re.StartTime as Date) >= Cast(CURRENT_TIMESTAMP  as DATE) )
                        and rf.CourtID = @_idcourt
--IncomeOfYear 2023


select S1.ServiceReceiptNo,convert(varchar,S1.CreateDate,105) as NgayLap,C.FullName,S1.PhoneNumber,U._Name,S1.Total
from SERVICE_RECEIPT S1,_USER U,CUSTOMER C
where  S1.PhoneNumber = C.PhoneNumber and U.Username = S1.Username
		and convert(varchar,month(s1.CreateDate)) = '4' and convert(varchar,year(s1.CreateDate)) = '2023' 

select C.FullName,C.PhoneNumber,C.Email,count(R.ReservationNo) as SoLan
from RESERVATION R,CUSTOMER C,RECEIPT R1
where R.PhoneNumber = C.PhoneNumber and R1.ReservationNo = R.ReservationNo 
	and R1._Date > '2023-4-16' and R1._Date < '2023-7-18'
group by C.FullName,C.PhoneNumber,C.Email

select C.FullName,C.PhoneNumber,C.Email,count(R.ReservationNo) as SoLan
from RESERVATION R,CUSTOMER C,RECEIPT R1
where R.PhoneNumber = C.PhoneNumber and R1.ReservationNo = R.ReservationNo and CONVERT(varchar,month(R1._Date))= '4'  and CONVERT(varchar,year(R1._Date))= '2023'
group by C.FullName,C.PhoneNumber,C.Email


select c.CourtID,c.CourtName,c.BranchID , c.BranchName , b.FullName, b.PhoneNumber , b.ReservationNo , b.StartTime , b.EndTime  , b._Status , CASE 
																																				When c._Status = 'Maintenance' then 'Maintenance'
																																				When b.ReservationNo is NULL then 'Available'
																																				When b.ReservationNo is not NULL then 'Using'
																																				When b._Status = 3 then 'OvTime'
																																				END as Status
from (	select c.CourtID , c.CourtName , c.BranchID , br.BranchName, c._Status
		from COURT c , BRANCH br 
		where c.BranchID = br.BranchID and c._Status != 'Available' and c._Status != 'Disable') c
Left Join (select rf.CourtID , tmp.FullName , tmp.PhoneNumber , rf.ReservationNo,tmp.StartTime,tmp.EndTime , tmp._Status
			from RF_DETAIL rf ,	(select reser.ReservationNo , a.FullName , a.PhoneNumber , FORMAT(reser.StartTime, 'HH:mm') as StartTime , 
										FORMAT(reser.EndTime, 'HH:mm') as EndTime , reser._Status
								from RESERVATION reser left join CUSTOMER a
								on a.PhoneNumber = reser.PhoneNumber
								where Cast(reser.StartTime as Date) = Cast(CURRENT_TIMESTAMP  as DATE) and 
									FORMAT(CURRENT_TIMESTAMP , 'HH:mm') < FORMAT(reser.EndTime, 'HH:mm') and 
									FORMAT(CURRENT_TIMESTAMP , 'HH:mm') >= FORMAT(reser.StartTime, 'HH:mm')  or 
									reser._Status = 3  ) tmp
			where rf.ReservationNo = tmp.ReservationNo)  b 
on b.CourtID = c.CourtID
select * from RESERVATION

select rf.ReservationNo , tmp.FullName , tmp.PhoneNumber ,tmp.[Ngay Choi], tmp.StartTime,tmp.EndTime , tmp.[Tong gio choi]
                            from RF_DETAIL rf ,		(select reser.ReservationNo, a.FullName , a.PhoneNumber , FORMAT(reser.BookingDate, 'dd/MM/yyyy')as[Ngay Choi] , 
							FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime , 
						                            FORMAT( DATEADD(MINUTE,DATEDIFF(MINUTE,reser.StartTime,reser.EndTime),'00:00'), 'HH:mm') as [Tong gio choi]
						                            from RESERVATION reser left join CUSTOMER a
													on a.PhoneNumber = reser.PhoneNumber 
						                            where CONVERT(datetime,reser.BookingDate,103) between @_date1 and @_date2 ) tmp , COURT a
                            where rf.ReservationNo = tmp.ReservationNo and rf.CourtID = a.CourtID and rf.CourtID = @courtID\

							select * from RESERVATION