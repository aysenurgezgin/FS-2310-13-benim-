use master
go

create database Shopping
go

use Shopping
go 
--Categories tablosunu oluþturma

create table Categories(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Description nvarchar(100),
	IsActive bit default 1,
	CreatedDate datetime default getdate()
)
go

--Categories tablosuna veri giriþi
insert into Categories(Name) values
	('Telefon'),
	('Elektronik'),
	('Televizyon'),
	('Bilgisayar')

go

--Products tablosunu oluþturma
create table Products(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Properties nvarchar(500),
	Price money not null,
	IsActive bit default 1,
	CreatedDate datetime default getdate(),
	CategoryId int foreign key references Categories(Id)
	
)
go

--Products tablosuna veri giriþi
insert into Products(Name,Price,CategoryId) values
	('Iphone 13',45000,1),
	('Samsung S23',37000,1),
	('Xaomi 13',21000,1),

	('Vestel Elek.Süpürge',30000,3),

	('Sony', 30000,3),
	('Blaupunkt',22000,3),

	('Macbook Air M1',40000,4),
	('Lenovo' ,45000,4),
	('Casper',60000,4),
	('Macbook Pro M3',90000,4)

	go

