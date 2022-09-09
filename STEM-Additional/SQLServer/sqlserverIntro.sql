--Create a db
create database StemDBAyush

--Use the table
use StemDBAyush

--Create a atable
create table RegTable(
    Name VARCHAR(35) NOT NULL,
    Address varchar(100) not null,
    Password varchar(20) not null,
    Gender varchar(10),
    Qualification varchar(30),
    City varchar(30) not null,
    Skills varchar(50),
    age int,
    email varchar(50) primary key
);

--Insert in table
insert into RegTable
values(
        'Martin',
        'GachiBowli',
        '123',
        'Male',
        'BE,MBA',
        'Hyderabad',
        'HTML,CSS,JS',
        35,
        'martin@gmail.com'
    );

--Modify the table
update RegTable
set age = 40,
address = 'Kochi'
where email = 'martin@gmail.com';

--Delete from table
delete from RegTable
where email = 'martin@gmail.com';


create table test
(testid int primary key, testname varchar(30));