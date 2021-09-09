-- Agregate functions 
--  Along with Group by



select min(unitprice), max(unitprice) from Product

select Round(AVG(unitprice),0) from product

select count(*) as product_count, CompanyName from product
join Supplier 
on Product.SupplierId = Supplier.Id
group by CompanyName

select Max(UnitPrice) as product_max_price, CompanyName from product
join Supplier 
on Product.SupplierId = Supplier.Id
group by CompanyName

select sum(unitprice) from Product

select sum(UnitPrice) as product_subtotal_price, CompanyName from product
join Supplier 
on Product.SupplierId = Supplier.Id
group by CompanyName
having sum(unitprice) > 100

-- 47.00	Exotic Liquids
select * from Supplier where CompanyName = 'Exotic Liquids'
select * from Product where SupplierId = 1


--STDEV standard deviation statistical caculation 
select STDEV(unitprice) from Product




select count(*) as company_count , Country 
from Supplier 
group by Country
order by Country

select count(*) as productcount, companyname, country
from product 
join Supplier
on Product.SupplierId = Supplier.Id
group by CompanyName, Country
order by Country, CompanyName

select count(*) as ordersinyear , year(orderdate) as orderyear
from [mydemodb].[dbo].[Order]
--where Id in ( 1,2,3,4,5)
group by year(orderdate)
Having count(*) > 140
order by orderyear

-- get lowest and highest unit price in each supplier company 
select companyname, min(unitprice) as lowest , max(unitprice) as higest
from product
join Supplier
on Product.SupplierId = Supplier.Id
group by CompanyName
having min(unitprice) <25 or max(unitprice) > 50

-- Grouping Sets
--  without grouping set use the union all 
select  companyname, null as country, count(*) as higest
from product
join Supplier
on Product.SupplierId = Supplier.Id
group by CompanyName
union all
select null as companyname,  Country, count(*) as higest
from product
join Supplier
on Product.SupplierId = Supplier.Id
group by Country
union all
select CompanyName, Country, count(*) as higest
from product
join Supplier
on Product.SupplierId = Supplier.Id
group by CompanyName, Country


-- with grouping set 

select CompanyName, Country, count(*) as higest
from product
join Supplier
on Product.SupplierId = Supplier.Id
group by 
grouping sets ((CompanyName,Country),
				(CompanyName),
				(Country),
				())


-- CUBES

select CompanyName, Country, count(*) as higest
from product
join Supplier
on Product.SupplierId = Supplier.Id
group by 
cube (CompanyName, Country)

-- Rollup
select  Country, CompanyName, count(*) as higest
from product
join Supplier
on Product.SupplierId = Supplier.Id
group by 
rollup ( Country, CompanyName)
order by CompanyName, country




select * from [mydemodb].[dbo].[Order]
select * from OrderItem
select * from Product
select * from Supplier
--  Joining more than one table 
-- output order number, date, product 
select OrderNumber, OrderDate,ProductName
from [mydemodb].[dbo].[Order] o
join OrderItem on o.Id = OrderItem.OrderId
join Product on OrderItem.ProductId = Product.Id


--  SubQuery
-- Output - prouct name where company name = 'Exotic Liquids'
select ProductName from Product
where SupplierId in  
(select id from Supplier where CompanyName = 'Exotic Liquids')

select ProductName from product 
join Supplier
on Supplier.Id = Product.SupplierId
where Supplier.CompanyName = 'Exotic Liquids'


select * from [Order]
select * from Customer

-- output display orders beloging to country uk
select OrderNumber from [Order]
where  customerId in  
(select Id from Customer where country = 'Uk')

-- Exists is true or false 
--  Any is one ore more results but of type boolean 


-- union all vs union 
select Id, ProductName, UnitPrice from Product where id in (1,2,3,4,5)
union all
select Id, ProductName, UnitPrice from Product where id in (4,5,6,7)

select Id, ProductName, package  from Product where id in (1,2,3,4,5)
union
select Id, ProductName, ProductName  from Product where id in (4,5,6,7)

select Id, ProductName, UnitPrice  from Product where id in (1,2,3,4,5)
intersect
select Id, ProductName, UnitPrice  from Product where id in (4,5,6,7)


select Id, ProductName, UnitPrice  from Product where id in (6,7)
except
select Id, ProductName, UnitPrice  from Product where id in (1,2,3,4,5)


-- Common Table Expressions CTE - temporary result set 

--WITH expression_name [columns]
--AS
--(Select  )

with cte_customer (fullname, Hq) As 
(select FirstName +' ' LastName , city from Customer )
select fullname, Hq from 
cte_customer where Hq = 'London'



--PIVOT 

select * from Supplier
select * from Product

select companyname , count(*) as productcount
from Supplier
join Product
on Supplier.Id = Product.SupplierId
group by CompanyName



--  Aux joyeux ecclésiastiques,  Bigfoot Breweries , Escargots Nouveaux
--        2                    ,  2 ,                     1

select * from
( select companyname ,  Product.Id as productId
from Supplier
join Product
on Supplier.Id = Product.SupplierId
) t
pivot
( 
   count(productId)
   for companyname in ([Aux joyeux ecclésiastiques], [Bigfoot Breweries] , [Escargots Nouveaux])

) as pivot_table


































































select * from Supplier


