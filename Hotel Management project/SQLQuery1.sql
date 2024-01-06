create table login(userID varchar(20),password varchar(10),conpassword varchar(10),
				   Addres varchar(100),phone bigint)
insert into login values('admin','admin123','admin123','N0:2, Chennai.',
						'9532487542')
select * from login
create table tblFood(Fid int identity(1,1)primary key , Fname varchar(20) Unique,
					 Ftype char(1) check(Ftype='V' or Ftype= 'N'), Fprice Money check(Fprice>0), 
					 Favailable varchar(20) not null)
select * from tblFood

create table tblBilling(BillNo int not null , BillDate datetime,
					   Fid int foreign key references tblFood(Fid), Price Money check(Price>0), 
					   Quantity int Default(1), Amount Money check(Amount>0)) 
select * from tblBilling


