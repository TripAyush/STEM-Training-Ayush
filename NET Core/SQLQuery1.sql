select * from Customer

create table BookStore(
    ISBN int constraint pk_bookid primary key identity(10000,99999),
    Title varchar(100) not null,
    Category varchar(100) not null,
    AuthorName varchar(30) not null,
    Pages int not null,
    Price money not null,    
)

create procedure sp_InsertBook(@title varchar(100),@cat varchar(100),@auth varchar(30),@pages int,@price money,@isbn int out)
as
begin
insert into BookStore values(@title,@cat,@auth,@pages,@price)
select @isbn=@@IDENTITY
end