/*
	Stored Procedure
	Server üzerinde çalýþtýrýlan kod parçalarýdýr.
	Fýnklara göre daha güvenli ve hýzlý çalýþýrlar.
	Bu yðzden de daha çok tercih edilirler.

	developer senin görvin dedce buraya eriþmek olacak veri tabýný ekibi bunu hazýrlar.
*/

use Northwind
go
drop producure if exist spSample
go

create procedure spSample
as
	select *
	from Products p
	where p.CategoryId=1
	order by p.UnitPrice desc

	go

	execute spSample