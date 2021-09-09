-- DML  
-- INSERT,  UPDATE, DELETE , Execution plans

select * from Product

set identity_insert product ON;
insert into product (Id, ProductName,SupplierId,UnitPrice,Package,IsDiscontinued)
values (83, 'Masala dosa',1,50.00,'1 box',0)
set identity_insert product OFF;

insert into product 
values ('Wheat dosa',2,50.00,'1 box',0),
('Idly',2,50.00,'1 box',0)


-- insert by selecting data
insert into product (ProductName, SupplierId)
select productname, SupplierId
from Product
where ProductName = 'Masala dosa'





select * from customer
select * from [order]

with result as

{ 
select salary, DENSE_RANK() over (order by salary desc) as denserank
}
select top 1 salary 
from result 
where result.denserank = 3 


select top 1 salaryfrom (select distinct top n salary from employees order by salary desc) order by salary 

 

 