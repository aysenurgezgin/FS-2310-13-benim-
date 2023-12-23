use master
go
drop  database if exists MoviesDb
go

create database  MoviesDb
go

use MoviesDb
go 
--Categories tablosunu olu�turma

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
	('�zg�rl��e Ka���',1,1),
	('�l�ml� d�nya',1,1),
	('Sevgi Yolu',1,1),
	('Big Bang Theory',1,2),
	('La Case de Pepel',1,2),
	('Hababm S�n�f�',2,2),
	('Zindan Adas�',2,3),
	('Melekler �ehri',2,3),
	('Prestij',2,3),
	('Kaybedenler klub�',2,3),
	('Leon Sevginin Yolu',2,3),
	('H�zl� ve �fkeli',2,4),
	('G�revimiz Tehlike',2,4),
	('Esaretin Bedeli',2,5),
	('Y�z�klerin Efendisi',1,5),
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
	('Sezen','K�ltablas�',1),
	('Kumru','Camdanbakan',1),
	('Ay�e','G�n�kurtaran',1),
	('Halil','Y�rekyakan',0)

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

