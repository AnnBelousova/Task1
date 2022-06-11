# Task2

create table Customers (
	Id int,
    Name varchar(25)
    );
create table Orders (
	Id int,
    CustomerId int
    );
insert into Customers 
	values 
    (
	1, "Max"
    ),
    (
	2, "Pavel"
    ),
    (
	3, "Ivan"
    ),
    (
	4, "Leonid"
    );
insert into Orders 
values 
	(
	1, 2
	),
	(
	2, 4
	);


select distinct(customers.Name) as Customers
from customers
join orders
where customers.Id not in (select orders.CustomerId from orders)
