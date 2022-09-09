create database StemDBAyush

use StemDBAyush

create table RegTable(
Name VARCHAR(35) NOT NULL,
Address varchar(100) not null,
Password varchar(20) not null,
Gender varchar(10),
Qualification varchar(30),
City varchar(30) not null,
Skills varchar(50),
age int,
email varchar(50) primary key);

insert into RegTable values('Martin','Mangalore','123','Male','BE,MBA','Bangalore','HTML,CSS,JS',35,'martin@gmail.com');

update RegTable set age=40,address='Kochi' where email='martin@gmail.com'