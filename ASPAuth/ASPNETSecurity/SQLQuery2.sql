create table Reunion(
    MembershipId int constraint pk_MemId primary key identity,
    Attendance varchar(5) not null,
    FirstName varchar(50) not null,
    LastName varchar(50) not null,
    PhoneNumber bigint not null,
    Meals varchar(50) not null,
    Games varchar(max) not null,
    Questions varchar(max) not null,
)


create proc sp_InsertReunion(@attn varchar(5),
@fn varchar(50),@ln varchar(50),@pn bigint,
@meals varchar(50),@games varchar(max),@ques varchar(max),
@memid int out)
as begin
insert into Reunion values(@attn,@fn,@ln,@pn,@meals,@games,@ques)
select @memid=@@IDENTITY
end

create proc sp_SelectReunion
as
begin
select * from Reunion
end

declare @memid int
exec sp_InsertReunion 'Yes','Ayush','Tripathy',9971770605,'Vegetarian','Indoor,Outdoor','Rain Check',@memid out
print 'Membership id is : ' + convert(varchar(4),@memid)

exec sp_SelectReunion


create table Student(
    RollNo int constraint pk_rollnum primary key identity,
    Name varchar(20) not null,
    Accounts int not null,
    Marketing int not null,
    Computing int not null,
    )

create proc sp_InsertStudent(@fn varchar(50),
@acc int,@mar int,@com int,
@roll int out)
as begin
insert into Student values(@fn,@acc,@mar,@com)
select @roll=@@IDENTITY
end


alter proc sp_InsertStudent(@fn varchar(50),
@acc int,@mar int,@com int,@total int,@aggregate int,@grade varchar(1),
@roll int out)
as begin
insert into Student values(@fn,@acc,@mar,@com,@total,@aggregate,@grade)
select @roll=@@IDENTITY
end