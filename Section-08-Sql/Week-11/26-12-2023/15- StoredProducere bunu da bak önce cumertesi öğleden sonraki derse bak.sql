/*
	Stored Procedure
	Server �zerinde �al��t�r�lan kod par�alar�d�r.
	F�nklara g�re daha g�venli ve h�zl� �al���rlar.
	Bu y�zden de daha �ok tercih edilirler.

	developer senin g�rvin dedce buraya eri�mek olacak veri tab�n� ekibi bunu haz�rlar.
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