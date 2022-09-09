use StemDB

create table Login(
email varchar(100) constraint pk_email primary key,
password varchar(10) not null
)

insert into Login values('Joe@gmail.com','abc123')

insert into Login values('Bin@gmail.com','abc@123')

SELECT * FROM Login