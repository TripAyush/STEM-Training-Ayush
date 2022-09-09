create table emp(empid int,name varchar(30));

--sp_rename 'dbo.emp','EmployeeDetails';

--sp_rename 'dbo.EmployeeDetails.name','empname';

alter table EmployeeDetails
alter column empid bigint

alter table EmployeeDetails
add dept varchar(30),
    desg varchar(50),
    salary money,
    doj datetime;

    alter table EmployeeDetails
drop column doj,dept;


create table Employee (
    EmpID int constraint pl_empid primary key identity,
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

insert into Project values('ICICI Bank'),('Amazon'),('Flipkart');

insert into Employee values('Martin','IT','martin@gmail.com','Gurgaon',75000,'Programmer','HTML,C#',300);

insert into Employee(Empname,Dept,Salary) values ('ALEX','ACCOUNTS',65000);

insert into Employee(Empname,Dept,Salary,EmailId) values ('CLARK','HR',55000,'clark@gmail.com');

insert into Employee values('Scott','Admin','scott@gmail.com','Bangalore',55000,NULL,null,100);

update Employee set ProjID = 200 where ProjID is null;

update Employee set salary = salary + salary*0.1;

CREATE TABLE [dept] (
	[deptno] [int] CONSTRAINT [pk_dpt] PRIMARY KEY ,
	[dname] [varchar] (20),
	[loc] [varchar] (20)
);

insert dept values(10,'ACCOUNTING','NEWYORK')
insert dept values(20,'RESEARCH','DALLAS')
insert dept values(30,'SALES','CHICKAGO')
insert dept values(40,'OPERATIONS','BOSTON')


create table emp(EMPNO int constraint pk_emp primary key,
ENAME VARCHAR(10),
JOB VARCHAR(9),
MGR int,
HIREDATE DATEtime,
SAL money,
COMM money,
DEPTNO int constraint fk_dep foreign key references dept(deptno));


insert emp values (7369,'SMITH','CLERK',7902,'DEC 17 1980',800,NULL,20);
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

select * from emp;

select EMPNO,ENAME,SAL,DEPTNO from emp;

select EMPNO 'Employee No.',ENAME 'Employee Name' from emp;

select distinct(job) from emp;

SELECT * from emp WHERE job='CLERK';

select * from emp WHERE job='CLERK' AND sal > 500;

SELECT ename FROM emp WHERE ename LIKE '%M';

SELECT * FROM emp ORDER BY SAL ASC;

select count(*) 'TOTAL COUNT', count(comm) 'TOTAL COMM' from emp;

select comm from emp;

select max(sal) 'MAX Salary' , min(ename) 'MIN Name'  from emp;
select avg(sal) from emp;

select sum(sal) from emp where job='ANALYST';

select JOB, COUNT(*) 'JOB' FROM emp GROUP BY job order by count(*) desc;

select count(*) 'TOTAL EMP' , sum(sal) 'TOTAL SAL',job from emp GROUP BY job;

select count(*) 'TOTAL EMP' , sum(sal) 'TOTAL SAL',job from emp where job <> 'PRESIDENT' GROUP BY job having count(*) >=2 order by job desc;

CREATE INDEX ind_ename on emp(ename); 