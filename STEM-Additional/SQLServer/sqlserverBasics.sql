-- DDL Using create and alter commands

--1.  create a table
create table emp(empid int, name varchar(30));

--2. change the table name
sp_rename 'dbo.emp',
'EmployeeDetails';

--3. change the column name
sp_rename 'dbo.EmployeeDetails.name',
'empname';

--4. change the datatype of the column
alter table EmployeeDetails
alter column empid bigint;

--5.add new column
alter table EmployeeDetails
add dept varchar(30),
    desg varchar(50),
    salary money,
    doj datetime;

--6. drop a column
alter table EmployeeDetails drop column doj,
    dept;

-- 7. drop the table
drop table EmployeeDetails;

-- DDL with Constraints - Rules when creating the table
--Primary Key, Unique, Default, Null, Not Null, Check, Identity, Foreign Key

create table Employee (
    EmpID int constraint pk_empid primary key identity,
    Empname varchar(30) not null,
    Dept varchar(30) constraint chk_dept check (dept in('IT', 'ACCOUNTS', 'HR', 'ADMIN')),
    EmailId varchar(30) constraint un_email unique,
    Location varchar(30) constraint un_loc default 'HYDERABAD',
    Salary money constraint chk_salary check(salary between 10000 and 999999),
    Desg varchar(30),
    Skillsets varchar(100),
);

create table Project(
    ProjID int constraint pk_projid primary key identity(100,100),
    Projname varchar(30) not null,
);

alter table Employee 
add ProjID int constraint
fk_emp_proj references Project(ProjID);



-- DML- insert, update , delete, truncate(How to handle null?)

--Insert multiple values in one single query
insert into Project values('ICICI Bank'),('Amazon'),('Flipkart');

--Insert data for all columns (Don't insert values for identity columns)
insert into Employee values('Martin','IT','martin@gmail.com','Gurgaon',75000,'Programmer','HTML,C#',300);

--Insert data only for specific not null columns
insert into Employee(Empname,Dept,Salary) values ('ALEX','ACCOUNTS',65000);
insert into Employee(Empname,Dept,Salary,EmailId) values ('CLARK','HR',55000,'clark@gmail.com');

--Insert specifically for null values(null shouldn't be put in "")
insert into Employee values('Scott','Admin','scott@gmail.com','Bangalore',55000,NULL,null,100);

-- Update the table(For null = operator won't work)
update Employee set ProjID = 200 where ProjID is null;
update Employee set salary = salary + salary*0.1;--Updates every row

--Deleting in a table
delete from Employee where EmailId is null;
truncate table Employee;


--Dummy Table for practice
CREATE TABLE [dept] (
	[deptno] [int] CONSTRAINT [pk_dpt] PRIMARY KEY ,
	[dname] [varchar] (20),
	[loc] [varchar] (20)
);

insert dept values(10,'ACCOUNTING','NEWYORK');
insert dept values(20,'RESEARCH','DALLAS');
insert dept values(30,'SALES','CHICKAGO');
insert dept values(40,'OPERATIONS','BOSTON');

create table emp(EMPNO int constraint pk_emp primary key,
ENAME VARCHAR(10),
JOB VARCHAR(9),
MGR int,
HIREDATE DATEtime,
SAL money,
COMM money,
DEPTNO int constraint fk_dep foreign key references dept(deptno));


INSERT emp values (7369,'SMITH','CLERK',7902,'DEC 17 1980',800,NULL,20);
INSERT EMP VALUES(7499,'ALLEN','SALESMAN',7698,'FEB 20 1981',1600,300,30);
INSERT EMP VALUES(7521,'WARD','SALESMAN',7698,'FEB 22 1981',1250,500,30);
INSERT EMP VALUES(7566,'JONES','MANAGER',7839,'APR 02 1981',2975,NULL,20);
INSERT EMP VALUES(7654,'MARTIN','SALESMAN',7698,'SEP 28 1981',1250,1400,30);
INSERT EMP VALUES(7698,'BLAKE','MANAGER',7839,'MAY 01 1981',2850,NULL,30);
INSERT EMP VALUES(7782, 'CLARK','MANAGER',7839,'JUN 09 1981',2450,NULL,10);
INSERT EMP VALUES(7788, 'SCOTT','ANALYST', 7566,'APR 19 1987',3000,NULL,20);
INSERT EMP VALUES(7839, 'KING','PRESIDENT',NULL,'NOV 17 1981',5000,NULL,10);
INSERT EMP VALUES(7844, 'TURNER','SALESMAN',7698, 'SEP 08 1981',1500,NULL,30);
INSERT EMP VALUES(7876, 'ADAMS','CLERK', 7788, 'MAY 23 1987',1100,NULL,20);
INSERT EMP VALUES(7900, 'JAMES','CLERK', 7698, 'DEC 03 1981',950,NULL,30);
INSERT EMP VALUES(7902, 'FORD','ANALYST',7566, 'DEC 03 1981',3000,NULL,20);
INSERT EMP VALUES(7934,'MILLER','CLERK',7782, 'JAN 23 1982',1300,NULL,10);


-- DQL , where , like, between, in , aggr functions, order by, group by 

--Retrieve All Values
select * from emp;

--Retrieve specific values
select EMPNO,ENAME,SAL,DEPTNO from emp;

--Change Display namd of column
select EMPNO 'Employee No.',ENAME 'Employee Name' from emp;

--Using different clauses
select distinct(job) from emp;
SELECT * from emp WHERE job='CLERK';
select * from emp WHERE job='CLERK' OR job='ANALYST';
select * from emp WHERE job='CLERK' AND sal > 3000;
select * from emp WHERE job in('CLERK','ANALYST');--Replacement of OR
select * from emp WHERE sal between 1000 AND 3000;
--A%(start) %S(end) A%S(start-end) %A%(Anywhere) _A%(2nd Char)
SELECT ename FROM emp WHERE ename LIKE 'M%';--Like (pattern matching)
SELECT ename FROM emp WHERE ename LIKE '%M%';
SELECT * FROM emp ORDER BY SAL desc;

--Aggregate functions
select count(*) 'TOTAL COUNT', count(comm) 'TOTAL COMM' from emp;
select max(sal) 'MAX Salary' , min(ename) 'MIN Name'  from emp;
select sum(sal) from emp where job='ANALYST';
select avg(sal) from emp;

--Group By
select JOB, COUNT(*) 'JOB' FROM emp GROUP BY job order by count(*) desc;
select count(*) 'TOTAL EMP' , sum(sal) 'TOTAL SAL',job from emp
where job <> 'PRESIDENT' GROUP BY job having count(*) >=2 order by job desc;


-- Joins
-- Inner Join
-- Outer Joins


-- Views 

--Views are updatable(changes in abse table)
update ciew_dept 20 set deptnp=50 where ename='ADAMS';

--Check updation of view on check option
create view_dept10 as 
select * form emp where deptno=10 with check option;
select * from view_dept10;
update view_dept10 set deptno=40 where ename='KING';--Not update
update view_dept10 set ename='CEO' where ename='KING';--Update


--Index(Used for faster retrieval of data)

--Clustered Index (Primary Key Column, Only 1 CI)

--Unique Non Clustered Index(Unique Constraint Col,Upto 999 NCI)
CREATE INDEX ind_ename on emp(ename);