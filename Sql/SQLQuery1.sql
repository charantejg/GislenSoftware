
use mydemodb
Go
select *
from Customer
order by LEN(FirstName)

-- Top
select top 10 * from Customer
order by Country

-- Offset and Fetch 
select * from Customer
order by FirstName
offset 10 rows
fetch next 10 rows only

-- Distinct
select distinct country, City from Customer
order by Country

-- Where (Filtering the records
select * from Customer
where Country = 'Germany' or City = 'London'
order by FirstName

select * from Product where UnitPrice >= 20

select * from Product where UnitPrice >= 15  and UnitPrice <= 30

select * from Product where UnitPrice between 15  and 30

-- Wildcards %
select * from Customer where FirstName like 'A%'
select * from Customer where FirstName like '%a%'
select * from Customer where FirstName like '%a'

-- underscore
select * from Customer where FirstName like 'M_____'

select * from Customer where Country in ('Germany','Mexico','UK')
order by Country

select FirstName +' '+ LastName as 'Full Name' from Customer

select * from Customer
select * from [mydemodb].[dbo].[Order] AS ORDERS

-- Id, first name, country , order number based on the customer id 
select c.Id, firstname,country ,o.ordernumber 
from Customer c
join [mydemodb].[dbo].[Order] o
on 
c.Id = o.CustomerId
order by c.Id


-- list all the customers + list of customers who has done orders till now 
select c.Id, FirstName, Country, ordernumber
from Customer c
left join [mydemodb].[dbo].[Order] o
on c.Id = o.CustomerId
--where ordernumber is null
order by c.Id

-- Right join
--list of firstname, country, ordernumber 
select ordernumber, FirstName
from Customer c
right join [mydemodb].[dbo].[Order] o
on c.Id = o.CustomerId  
order by FirstName

-- Full join / Full outer join 
select firstname, ordernumber 
from Customer c
full join [mydemodb].[dbo].[Order] o
on c.Id = o.CustomerId

--  cartesian cross joins
select * from Product
select * from Supplier
select * from Customer

--  supply chai product to all the avaialbe supliers
select ProductName , CompanyName
from Product
cross join 
Supplier
where ProductName = 'Chai'

--  Self joins
select * from students

select s1.student_id, s1.name from
students s1
 join students s2 
on s1.Student_Id  = s2.Mentor_Id

--  Group By 
select * from Customer
select * from [mydemodb].[dbo].[Order]

select count(*) as CustomerCount, Country from Customer
Group by Country
order by Country

-- get country wise orders 
select count(*) as customerordercount , country 
from Customer c
join [mydemodb].[dbo].[Order] o
on c.Id = o.CustomerId
group by Country
order by Country

select * from Product




















update [mydemodb].[dbo].[Order]  
set CustomerId = 85
WHERE Id in (127,364,545,623,659,751,797)

where [mydemodb].[dbo].[Order].CustomerId = 91























