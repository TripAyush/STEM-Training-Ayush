create database Payroll

use Payroll

create table [User](
    UserID int constraint pk_userid primary key identity(1000,1),
    UserName varchar(30) not null,
    Password varchar(30) not null,
    UserRole varchar(20) not null,    
)

create table Employee(
    EmpID int constraint pk_empid primary key identity,
    Empname varchar(30) not null,
    Dept varchar(30) constraint chk_dept check (dept in('IT', 'ACCOUNTS', 'HR', 'ADMIN')),
    EmailId varchar(30) constraint un_email unique,
    MobNo bigint constraint un_mno unique,
    Location varchar(30) constraint un_loc default 'HYDERABAD',
    Desg varchar(30) constraint chk_desg check (desg in('ANALYST', 'MANAGER', 'ASST MANAGER', 'JR STAFF')),
);

create table SalaryInfo(
    SalaryID int constraint pk_salid primary key identity,
    EmpID int constraint fk_emp references Employee(EmpID),    
    Salary money,
    Desg varchar(30) not null,
    SalaryDate datetime constraint def_Sd default getdate(),
);
drop table SalaryInfo

--Stored Procedures

create proc sp_InsertUser(@name varchar(30),@pass varchar(30),@role varchar(20),@uid int out)
as
begin
insert into [User] values(@name,@pass,@role)
select @uid=@@IDENTITY
end

create proc sp_LoginUser(@uid int,@pass varchar(30),@role varchar(20))
as
begin
select * from [User] where UserID=@uid and [Password]=@pass and UserRole=@role
end

create procedure sp_InsertEmployee(@name varchar(30),@dept varchar(30),@email varchar(30),@mno bigint,@loc varchar(30),@desg varchar(30),@eid int out)
as
begin
insert into Employee values(@name,@dept,@email,@mno,@loc,@desg)
select @eid=@@IDENTITY
end



create proc sp_ChangePassword(@uid int,@pass varchar(30))
as
begin
UPDATE [User] SET Password=@pass WHERE UserID=@uid
end

create proc sp_UpdateProfile(@eid int,@name varchar(30),@email varchar(30),@mno bigint,@loc varchar(30))
as
begin
UPDATE Employee SET Empname=@name,EmailId=@email,MobNo = @mno,Location=@loc WHERE EmpID=@eid
end

insert into [User] values('Janani','abc','Admin')

select * from [User]

create proc sp_GenerateSalary(@empid int,@desg varchar(30),@sal money,@sid int out)
as
begin
insert into SalaryInfo(EmpID,Desg,Salary) values(@empid,@desg,@sal)
select @sid=@@IDENTITY
--where EmpID=@empid
end


create procedure sp_DeleteEmployee(@eid int)
as
begin
delete from SalaryInfo where EmpID=@eid;
delete from Employee where EmpID=@eid;
end