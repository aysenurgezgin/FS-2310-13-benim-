use Nortwind
go 

drop proc if exists spGetProductsByCategoryName
go

create proc spGetProductsByCategoryName
@categoryName nvarchar(15)
as

	select
	*
	from Products p join Categories c
	on p.CategoryId=c.Category 