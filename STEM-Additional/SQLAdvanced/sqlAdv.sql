--Creating Views
create view v_EmpDept
AS
SELECT e.ename,d.dname,e.sal
from emp e
join dept d
on e.deptno = d.deptno
where e.deptno = 20 with CHECK option

select * from v_EmpDept
update v_EmpDept set dname='ACCOUNTING' where ename='SMITH'
select * from emp


--Creating variables
declare @num1 int,@num2 int,@res int
set @num1 = 10
set @num2 = 20
set @res = @num1 + @num2
print'Addition of 2 Numbers is ' + convert(varchar(4),@res)


--In Out Parameters
--TSQL - Transact Sql(queries with condn.)
--Stored Procedures, Functions and Triggers
--SPs are like void fn, Functions return value(scalar fn 1 value)
--If multiple values are returned it's called table valued fn


--Stored Procedures
create proc sp_UpdateSal(@empno int)
as
begin
declare @dno int
declare @sal money
select @dno = deptno from emp where empno=@empno
update emp
set sal=
case @dno
when 10 then sal+sal*.10
when 20 then sal+sal*.12 
when 30 then sal+sal*.8 
when 40 then sal+sal*.15
else 7500
end 
where empno=@empno
end

exec sp_UpdateSal 7369
select * from emp
exec sp_UpdateSal 7521
select * from emp

--Oracle
create table ResignedEmp
as
(select * from emp
where 1=2)
--SQLServer
select * into ResignedEmp
from emp
where 1=2


--Triggers create 2 magical tables
--Inserted(Store inserted item before inserting) & Deleted(Store deleted item before deleting)
create trigger trigger_deleteemp
on emp
for delete
as
begin
declare @eno int, @ename varchar(10),@job varchar(30),@mgr int,@hdate date,@sal money,@comm money,@dno int
select @eno=empno,@ename=ename,@job=job,@mgr=mgr,@hdate=hiredate,@sal=sal,@comm=comm,@dno= deptno from deleted
insert into ResignedEmp values(@eno,@ename,@job,@mgr,@hdate,@sal,@comm,@dno)
end

delete from emp where empno=7521
select * from emp where empno=7521

select * from ResignedEmp

--Update Trigger
create trigger trigger_updateemp
on emp
for update
AS
begin
declare @oldsal money,@newsal money
select @oldsal = sal from deleted
select @newsal = sal from inserted
if @newsal > @oldsal
begin
commit
print 'Salary updated successfully'
end
else
begin
rollback
print 'Cannot decrease salary'
end
end

update emp set sal=5000 where empno=7369
update emp set sal=2000 where empno=7566
select * from emp


--Functions
--Scalar function
create function fn_GetName(@eno int) returns varchar(30)
as
begin
declare @ename varchar(30)
select @ename = Ename from emp where empno=@eno
return @ename
end

declare @res varchar(30)
set @res = dbo.fn_GetName(7369)
print @res

--Table Valued function
--Rules
--1. no begin and end
--2. entire data which u r returning should be inside return method
--3. we cannot use table valued function for insert
create function fn_selectdata(@dno int) returns table
as
return (select * from emp where deptno=@dno)
select * from fn_selectdata(20)


select * into emp1
from emp

select * from emp1

--Won't Work
--create function fn_UpdateEmp(@job varchar(30)) returns table
--return (update emp set sal = sal + 117.68 where job=@job)


--CTE's and Ranking,Heirarchies,Managing query plans,Recursion,Pivot & Sampling,Security
select count(*) 'Count Emp',job,ename from emp
group by job

select ename,job,deptno,sal,
cume_dist() over (ORDER BY sal) as 'Salary Distribution'
from emp

select ename,job,deptno,sal,FIRST_VALUE(ename) over (order by sal) 'FIRST VALUE' from emp
select ename,job,deptno,sal,LAST_VALUE(ename) over (order by sal) 'LAST VALUE' from emp

select ename,job,deptno,sal,LAST_VALUE(ename) over (order by sal rows between unbounded preceding and unbounded following) 'LAST VALUE' from emp

select ename,deptno,sal,lead(ename,1) over (order by sal) 'Next Offset' from emp
select ename,deptno,sal,lag(ename,1) over (order by sal) 'Previous Offset' from emp


select empno,ename,sal,Rank() over (order by sal) 'Rank',
DENSE_RANK() over (order by sal) 'DENSE RANK',
ROW_NUMBER() over (order by sal) 'ROW NUMBER'
from emp

insert into emp(empno,ename,sal) values (3,'AYUSH',3000)

with CTE_EmpReports(ENO,EMPNAME,JOB,SAL,DNO)
as
(select empno,ename,job,sal,deptno from emp where job='SALESMAN')

select max(sal) from emp

select ename,empno,job,deptno from emp where sal = max(sal)

select ename,empno,job,deptno from emp where empno in (select empno from emp where sal=3000)


with
CTE_EmpReports(EmpNo)
as
(select empno from emp where sal=3000)
,empDetailsCTE(ename,empno,job,deptno)
as
(select ename,emp.empno,job,deptno from emp join CTE_EmpReports er on emp.empno=er.empno)
select ename,empno,job,deptno from empDetailsCTE

with number_cte
as
(select 1 as n union all select n+1 from number_cte where n < 101)
select n from number_cte;

;with CTE_EMPJOB(ENO,NAME,JOB,SAL,DNO)
as
(select empno,ename,job,sal,deptno from emp where job='SALESMAN')
select ENO,NAME,JOB,SAL,DNO from CTE_EMPJOB;


--Won't work with Afggregate Fn
select ename from emp where sal=max(sal)
--Subquery(inner query runs first then second)
select ename from emp where sal=max(select max(sal) from emp)


--Pivot table(Transponse along with aggr fn)
CREATE TABLE product_sales (
  product_name VARCHAR(100),
  store_location VARCHAR(50),
  num_sales INT
);


INSERT INTO product_sales (product_name, store_location, num_sales) VALUES
('Chair', 'North', 55),
('Desk', 'Central', 120),
('Couch', 'Central', 78),
('Chair', 'South', 23),
('Chair', 'South', 10),
('Chair', 'North', 98),
('Desk', 'West', 61),
('Couch', 'North', 180),
('Chair', 'South', 14),
('Desk', 'North', 45),
('Chair', 'North', 87),
('Chair', 'Central', 34),
('Desk', 'South', 42),
('Couch', 'West', 58),
('Couch', 'Central', 27),
('Chair', 'South', 91),
('Chair', 'West', 82),
('Chair', 'North', 37),
('Desk', 'North', 68),
('Couch', 'Central', 54),
('Chair', 'South', 81),
('Desk', 'North', 25),
('Chair', 'North', 46),
('Chair', 'Central', 121),
('Desk', 'South', 85),
('Couch', 'North', 43),
('Desk', 'West', 10),
('Chair', 'North', 5),
('Chair', 'Central', 16),
('Desk', 'South', 9),
('Couch', 'West', 22),
('Couch', 'Central', 59),
('Chair', 'South', 76),
('Chair', 'West', 48),
('Chair', 'North', 19),
('Desk', 'North', 3),
('Couch', 'West', 63),
('Chair', 'South', 81),
('Desk', 'North', 85),
('Chair', 'North', 90),
('Chair', 'Central', 47),
('Desk', 'West', 63),
('Couch', 'North', 28);

SELECT * FROM product_sales;


select product_name,NORTH,SOUTH,CENTRAL,WEST from
(select product_name,store_location,num_sales from product_sales)
as sales_location
pivot
(sum(num_sales) for store_location IN(NORTH,SOUTH,CENTRAL,WEST)) as Pivot_Table


--Hierarchies
create table Sample_Continent(
    Node hierarchyid not null,
    [Geographical Name] varchar(30) not null,
    [Geographical Type] varchar(20) not null,
)

insert into Sample_Continent values
--First level
('/1/','ASIA','CONTINENT'),
('/2/','AFRICA','CONTINENT'),
('/3/','OCEANIA','CONTINENT'),
--Second level
('/1/1/','INDIA','COUNTRY'),
('/1/2/','CHINA','COUNTRY'),
('/1/3/','SOUTH KOREA','COUNTRY'),
('/2/1/','SOMALIA','COUNTRY'),
('/2/2/','KENYA','COUNTRY'),
('/3/1/','AUSTRALIA','COUNTRY'),
--Third level
('/1/1/1/','NEW DELHI','CITY'),
('/1/2/1/','BEIJING','CITY'),
('/1/3/1/','SEOUL','CITY'),
('/2/1/1/','MOGADISHU','CITY'),
('/2/2/1/','NAIROBI','CITY'),
('/3/1/1/','CANBERRA','CITY')

select Node,Node.ToString() as [Node Text],
Node.GetLevel() as [Node Level],
[Geographical Name],
[Geographical Type]
from Sample_Continent ORDER BY [Node Text]


--Security
CREATE USER Tester
WITHOUT LOGIN
WITH DEFAULT_SCHEMA = dbo

GO
GRANT CONNECT TO Tester

select CURRENT_USER

execute as user='Tester'

select * from product_sales--Doesn't work

grant select on product_sales to tester

select * from product_sales--Now works


revoke select on emp to tester
go


revoke delete on emp to tester
go

select CURRENT_USER

use StemDb

execute as user='Tester'
select CURRENT_USER

select * from emp
delete from emp where empno=1

grant select on emp to tester