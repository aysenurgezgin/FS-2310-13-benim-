USE master
GO

IF EXISTS (SELECT * FROM sysdatabases WHERE NAME='PersonelTakip')
		DROP DATABASE PersonelTakip
GO

CREATE DATABASE PersonelTakip
GO

USE PersonelTakip
GO

CREATE TABLE Departmanlar
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Ad VARCHAR(50),
	Sorumlu VARCHAR(50)
)
GO

INSERT INTO Departmanlar VALUES
('Ýnsan Kaynaklarý','Alex de Souza'),
('Muhasebe','Bafetimbi Gomis'),
('Satýþ','Serdar Aziz'),
('Üretim','Elif Kaya')
GO

USE PersonelTakip
GO

CREATE TABLE Unvanlar
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Ad VARCHAR(50)
)
GO

INSERT INTO Unvanlar VALUES
('Ýþçi'),('Mühendis'),('Takým Lideri'),('Þef'),('Yönetici')
GO

USE PersonelTakip
GO

CREATE TABLE Calisanlar
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Ad VARCHAR(50),
	Soyad VARCHAR(50),
	TcNo VARCHAR(11) UNIQUE,
	PersonelNo VARCHAR(5) UNIQUE,
	DogumTarihi DATE,
	IseBaslamaTarihi DATE,
	DepartmanId INT,
	UnvanId INT,
	Durumu VARCHAR(5),
	FOREIGN KEY(DepartmanId) REFERENCES Departmanlar(Id),
	FOREIGN KEY(UnvanId) REFERENCES Unvanlar(Id)
)
GO

USE PersonelTakip
GO

INSERT INTO Calisanlar VALUES
	('Seda','Kodyazar','89763344984','74522','1975-3-19','2012-5-1',1,1,'Aktif'),
	('Faruk','Günsayan','89763344985','82345','1976-3-19','2013-4-11',1,2,'Aktif'),
	('Cemal','Gittigelmez','89763344986','63467','1975-3-19','2010-12-13',1,2,'Aktif'),
	('Orhan','Taklacý','89763344988','34112','1979-3-16','2010-5-20',1,3,'Aktif'),
	('Cem','Parasaydý','89763344989','11111','1973-3-19','1999-5-17',2,1,'Aktif'),
	('Tarkan','Çalhankýzý','89763344917','22222','1988-3-19','2019-3-14',2,1,'Aktif'),
	('Feride','Kodyazar','89763344927','33333','1986-3-19','2020-1-16',2,2,'Aktif'),
	('Selcan','Günsayan','89763344937','44444','1989-3-19','2017-6-23',2,4,'Aktif'),
	('Begüm','Tutkopar','89763344947','55555','1987-3-19','2018-7-24',2,4,'Aktif'),
	('Umay','Gittigelmez','89763344957','66666','1999-3-19','2018-8-26',2,4,'Aktif'),
	('Gülen','Günsayan','89763344967','77777','1990-3-19','2013-9-3',3,1,'Aktif'),
	('Güler','Kodyazar','89763344977','88888','1991-3-19','2013-10-23',3,1,'Aktif'),
	('Gül','Taklacý','89763344987','99999','1980-3-10','2014-9-13',3,1,'Aktif'),
	('Tahir','Kodyazar','89763344187','00000','1983-3-19','2014-8-13',3,2,'Aktif'),
	('Ferdi','Taklacý','89763344287','12222','1972-3-19','2014-4-13',3,2,'Pasif'),
	('Canan','Çalhankýzý','89763344387','14444','1971-3-19','2014-5-10',3,2,'Aktif'),
	('Aslý','Çalhankýzý','89763344487','15555','1970-3-19','1998-2-10',3,3,'Aktif'),
	('Ahmet','Parasaydý','89763344587','13333','1982-3-19','2002-1-10',4,1,'Pasif'),
	('Recep','Gittigelmez','89763344687','16666','1984-3-19','2008-1-10',4,2,'Aktif'),
	('Serhan','Günsayan','89763344787','17777','1980-3-19','2006-2-13',4,3,'Aktif'),
	('Merve','Tutkopar','89763344887','18888','1979-3-19','2006-3-13',4,4,'Aktif'),
	('Zeynep','Taklacý','89763342987','18889','1973-3-19','2006-5-13',4,4,'Aktif')
GO
