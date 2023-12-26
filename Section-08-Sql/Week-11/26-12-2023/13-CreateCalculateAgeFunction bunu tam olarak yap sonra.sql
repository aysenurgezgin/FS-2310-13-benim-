use  Northwind
go
drop  function if exists dbo.fnCalculateAge
go

create function fnCalculateAge(@birthDay date)
	return int
begin
	declare @result int
	declare @today date
	set @today = GETDATE()
	set @result =DATEDIFF(year,@birthDay,@today)
	return @result
end

go


select dbo.fnCalculateAge('1975-7-16')
go