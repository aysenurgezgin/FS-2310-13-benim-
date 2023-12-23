use master
go
drop  database if exists MoviesDb
go

create database  MoviesDb
go

use MoviesDb
go 
--Categories tablosunu oluþturma

create table Categories(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Description nvarchar(100),
	IsActive bit default 1 not null,
	CreatedDate datetime default getdate() not null
)
go

insert into Categories(Name) values
('Macera'),('Komedi'),('Duygusal')
go

create table Directories (
	Id int primary key identity(1,1),
	Name nvarchar(50)not null,
	Gender bit not null,
	Age smallint ,
	IsActive bit default 1 not null,
	CreatedDate datetime  default getdate() not null
	)
	go


	insert into Directories(Name, Gender) values
	('Ferzan',1), ('Kemal',0),('Suzan',1),('Cemal',0),
	('Zeynep',1),('Baransel',0)

	go
create table Films(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	IsActive bit default 1  not null,
	CategoryId int foreign key references Categories(Id),
	CreatedDate datetime default getdate() not null,
	DirectorId int foreign key references Directories(Id)
	)
	go
	insert into Films(Name,CategoryId, DirectorId) values
	('Özgürlüðe Kaçýþ',1,1),
	('Ölümlü dünya',1,1),
	('Sevgi Yolu',1,1),
	('Big Bang Theory',1,2),
	('La Case de Pepel',1,2),
	('Hababm Sýnýfý',2,2),
	('Zindan Adasý',2,3),
	('Melekler Þehri',2,3),
	('Prestij',2,3),
	('Kaybedenler klubü',2,3),
	('Leon Sevginin Yolu',2,3),
	('Hýzlý ve öfkeli',2,4),
	('Görevimiz Tehlike',2,4),
	('Esaretin Bedeli',2,5),
	('Yüzüklerin Efendisi',1,5),
	('Inseption',1,6),
	('Bilmiyorum',1,6),

	go

	create table Stars(
	Id int primary key identity(1,1),
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Age smallint not null,
	Gender bit  not null,
	IsActive bit default 1 not null,
	CreatedDate datetime  default getdate() not null
	)
	go 

	insert into Stars(FirstName, LastName,Gender) values
	('ALi','Can',0),
	('Sezen','Kültablasý',1),
	('Kumru','Camdanbakan',1),
	('Ayþe','Günükurtaran',1),
	('Halil','Yürekyakan',0)

	go

	create table FilmsStars(
	 StartId int foreign key references Stars(Id),
	 FilmId int foreign key references Films(Id),
	 constraint [PK_FilmsStars] primary key clustered(
		StarId, FilmId
	    )  on[primary]
	 )
	 go

	 /*insert into FilmsStars values
	 
	 (1,1),(1,4),(1,7),(1,11),(1,12),
	 (2,1),(2,6),(2,7),(2,8),
	 (3,9),
	 (),(1,1),(1,1),
	 (1,1),(1,1)

