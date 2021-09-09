-- Comments

/*  
   DDL 
*/

create database mydemodb

use mydemodb

create table customer
(
    Customer_ID  numeric,
    Name varchar(100),
	Address varchar(1000) 
)


exec sp_rename  'customer','customer_new'

Alter table customer_new Add 
Status varchar(5)


Alter table customer_new 
--Alter column Customer_ID numeric NOT NULL
Add Primary key (Customer_ID)


create table customer_old
(
    Customer_ID  numeric,
    Name varchar(100),
	Address varchar(1000) 
)

drop table customer_old

select * from customer_new

truncate table customer_new











