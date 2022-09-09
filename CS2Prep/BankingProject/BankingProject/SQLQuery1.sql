use StemDB

create table Customer(
    CustId int constraint pk_custid primary key identity(10000,99999),
    CustName varchar(30) not null,
    CustAddress varchar(100) not null,
    MobNo bigint constraint un_mno unique,
    EmailId varchar(100) constraint un_em unique,
    Gender varchar(10) not null,    
)

alter table Customer
add Password varchar(30) not null

select * from Customer

create table Accounts(
    AccountNo bigint constraint pk_acc primary key identity(1166110100000,1),
    CustId int constraint fk_cust_accts references Customer(CustId),
    AccountType varchar(30) not null,
    Balance money not null,
    Status varchar(15) not null
)

select * from Accounts


create table [Transaction](
    TransactionId int constraint pk_tid primary key identity,
    TransactionDate datetime constraint def_Td default getdate(),
    AccountNo bigint constraint fk_accts_trans references Accounts(AccountNo),
    TransactionType varchar(50) not null,
    TransactionAmount money not null, 
)
select * from [Transaction]

create procedure sp_InsertCustomer(@name varchar(30),@add varchar(100),@mno bigint,@email varchar(50),@gen varchar(10),
@pwd varchar(30),@cid int out)
as
begin
insert into Customer values(@name,@add,@mno,@email,@gen,@pwd)
select @cid=@@IDENTITY
end


create proc sp_LoginCustomer(@cid int,@pass varchar(30),@result varchar(20) out)
as
begin
declare @cnt int
select @cnt=count(*) from Customer where CustId=@cid and Password=@pass
if @cnt = 1
  begin
  set @result='Login Success'
  end
else
  begin
  set @result='Login Failed'
  end
end

create proc sp_InsertAccounts(@cid int,@acctype varchar(30),@status varchar(15),@accid bigint out)
as
begin
insert into Accounts values(@cid,@acctype,0,@status)
select @accid=@@IDENTITY
end


alter proc sp_InsertTransaction(@accno bigint,@tt varchar(30),@tamt money,@tid int out)
as
begin
insert into [Transaction](AccountNo,TransactionType,TransactionAmount) values(@accno,@tt,@tamt)
if @tt='Withdraw'
  begin
  update Accounts set Balance = Balance - @tamt where AccountNo = @accno
  end

if @tt='Deposit'
  begin
  update Accounts set Balance = Balance + @tamt where AccountNo = @accno
  end

if @tt='Fund Transfer'
  begin
  update Accounts set Balance = Balance - @tamt where AccountNo = @accno
  end
select @tid=@@IDENTITY
end

alter proc sp_LoginCustomer(@cid int,@pass varchar(30))
as
begin
select * from Customer where CustId=@cid and [Password]=@pass
end

