--update tablename  set columns = '' 
--where condition

select * from Product

update Product set UnitPrice = 19.00
where ProductName = 'Chai'


select * from [Order]

update [Order] set OrderDate = GETDATE()
where OrderNumber  = 542378

select * from Product
select * from Supplier

select productName, UnitPrice from Product
join Supplier on Product.SupplierId = Supplier.Id
where Supplier.CompanyName = 'Exotic Liquids'

--  i have supplier name (company name) for all the products increase the unit by 5

update Product
set UnitPrice = UnitPrice + 5
from 
Product join  Supplier
on Product.SupplierId = Supplier.Id
where Supplier.CompanyName = 'Exotic Liquids'

-- DELETE 
select * from Product where ProductName = 'Masala dosa'

delete from Product where ProductName = 'Masala dosa'

--truncate 


-- MERGE 
-- source and destination 
-- if the records are new it is inserted
-- if the records are not matching it is deleted 
-- if the records exists (matching) then it is updated 

--Merge <target_table> using <source_table>
--on merge_condition
--when matched
--then <update statement>
--when not matched
--then insert
--when not matched by source 
--then delete

select top 20 * from product 
order by UnitPrice


-- stored procedures

go
CREATE or ALTER procedure spLowCostProduct (
@lowprice as decimal = 5,
@highPrice as decimal)
As 
Begin
 declare @supplierId int; 
 set @supplierId  = 2; 
  select top 10 * from product  where UnitPrice between @lowprice and @highPrice  order by UnitPrice  
End


-- Creating output parameters in SQL stored procs



Go
create or alter procedure spSupplierProductCount 
(
   @companyName as nvarchar(max),
   @phonenumber as nvarchar(max) output 
)
As
Begin
   select @phonenumber= phone from Supplier where CompanyName = @companyName
End;


-- If else
go
create or alter procedure spSupplierForACountry
(@countryname as nvarchar(max))
as 
begin
if(@countryname = 'UK')
  begin
     select companyname from supplier where Country = @countryname
  end 

end;

declare @phone nvarchar(max) 
exec spSupplierProductCount 'Exotic Liquids', @phone output 
select @phone as 'phone number'
PRINT @phone



-- CURSORS -is a DB object which enables us to traverse trough the rows of selected result.  
-- Declare
-- Open
-- Fetch 
-- Close
-- Dealocate 

Declare cursor_supplier cursor
for select
companyname
from Supplier

declare @company_name nvarchar(250)

open cursor_supplier 

fetch next from cursor_supplier into @company_name;

while @@FETCH_STATUS=0
   begin try
        print @company_name
		fetch next from cursor_supplier into @company_name;
   end try
   begin catch
       print 'Error occurred' 
   end catch 

close cursor_supplier;
deallocate cursor_supplier;


--   Views 
--  Virtual Tables 

select * from product
select * from Supplier


go
create or alter view productsandcompany
as
select productname , companyname , country
from product
join Supplier
on Product.SupplierId = Supplier.Id


select * from productsandcompany
order by CompanyName, Country


-- Triggers
-- Special stored procedure
-- Types of Triggers
-- DML Triggers (Insert , update and Delete) 
-- DDL Trigers (Create , Alter and Drop) 
-- Logon Trigger 

-- DML Triggers
--  AFTER 
--- INSTEAD 


-- DML AFTER Trigger examples

go
create trigger tgRefreshProduct
on product
after Insert, update 
As
Begin 
declare @currentdate datetime
set @currentdate = GETDATE()
 insert into [Order] values (@currentdate,'60001',85,500.00);
End; 

insert into Product values ('chineese soup',1,250.00,'1 box',0)

update product set ProductName = 'Asian soup'  where ProductName = 'chineese soup'

--  Instead of Triggers
go
create trigger tgProductandCompany
on [dbo].[productsandcompany]
instead of insert 
as
begin
 insert into product values ('Westren dish',1,250.00,'2 boxes',0)
end;

--  INDEXES
--   B - TREE  Balanced Tree

-- Clustered index
create table PriorityCustomer
( 
   id int not null primary key,
   name varchar(250) not null,
   phone varchar(12) null

)

INSERT INTO [dbo].[productsandcompany]
           ([productname]
           ,[companyname]
           ,[country])
     VALUES
           ('new westren main course',null,null)
GO


-- Non clustered index

create nonclustered index index_name 
on PriorityCustomer(name)




select 
row_number() over (order by productname) as productnumber,
productname, supplierid, unitprice
from Product

select  
row_number() over (order by productname) as productnumber,
productname,
row_number()  over (partition by CompanyName order by CompanyName) as companynumber,
CompanyName
supplierid, unitprice
from  Product
join Supplier
on Product.SupplierId = Supplier.Id
--order by productnumber, companynumber
select DENSE_RANK() over (order by supplierId) as sup_id , ProductName from Product


--- slect nth highest number

-- 2nd higest
select max(unitprice) from product
where unitprice < (select max(unitprice) from product)

-- nth unitproce   this example for 3rd higest 
select top 1 unitprice from 
(select distinct top 3 unitprice from product
order by UnitPrice desc) result
order by UnitPrice

-- apply dense rank
with cte_result as 
(
select distinct unitprice, DENSE_RANK() over (order by unitprice desc) as ranking from Product
)
select top 1 unitprice from cte_result
where ranking =2































































