select 

	p.ProductID  as Id,
	p.ProductName as Name,
	p.UnitPrice as CategoryId,
	p.UnitsInStock as Stock
from Products p
where p.UnitsInStock>=100
order by p.UnitsInStock desc