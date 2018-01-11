-- number of suppliers
select count(SupplierID) as 'NumberOfSuppliers'
from Suppliers

-- supplier name & location
select CompanyName, Address, City, Country
from Suppliers
order by Country asc

-- number of distinct supplier cities and countries
select count(City) as 'NumberOfCities', count(distinct Country) as 'NumberOfCountries'
from Suppliers

-- suppliers and their products
select s.CompanyName, p.ProductName
from Suppliers s
join Products p on s.SupplierID = p.SupplierID
order by s.CompanyName asc

-- how many products each supplier supplies
select s.CompanyName, count(p.ProductID) as '# of Products Supplied'
from Suppliers s
join Products p on s.SupplierID = p.SupplierID
group by s.SupplierID, s.CompanyName
order by '# of Products Supplied' asc, s.CompanyName asc

-- products, price & quantity
select ProductID, ProductName, UnitPrice, QuantityPerUnit
from Products
order by UnitPrice asc, ProductName asc

-- which customers ordered which products
select c.CustomerID, p.ProductName as 'Product Ordered'
from Customers c
join Orders o on c.CustomerID = o.CustomerID
join [Order Details] od on o.OrderID = od.OrderID
join Products p on od.ProductID = p.ProductID
--group by c.CustomerID
order by CustomerID asc

-- number of order sent by each shipper
select sh.CompanyName, count(o.OrderID) as 'NumberOfOrders'
from Orders o 
join Shippers sh on o.ShipVia = sh.ShipperID
group by sh.CompanyName
order by NumberOfOrders asc

-- customers that start with the letter 'A'
select ContactName as 'CustomersWithA'
from Customers
where ContactName like 'a%'

-- products priced between 10 and 20
select ProductName, UnitPrice
from Products
where UnitPrice between 10 and 20
order by UnitPrice asc, ProductName asc

-- select all customers that are in specific cities
select ContactName, City
from Customers
where City in ('Paris', 'London')
order by ContactName asc

-- average unit price
select avg(UnitPrice) as 'AverageUnitPrice'
from Products

select c.CustomerID, count(*) as 'NumOfOrders'
from Customers c
join Orders o on c.CustomerID = o.CustomerID
group by c.CustomerID

select c.CustomerID, count(p.ProductID) as 'NumOfProductsOrdered'
from Customers c
join Orders o on c.CustomerID = o.CustomerID
join [Order Details] od on o.OrderID = od.OrderID
join Products p on od.ProductID = p.ProductID
group by c.CustomerID
order by CustomerID asc

select *
from Products
where ProductID in 
	(select ProductID
	 from Products
	 where UnitPrice > 20)
order by UnitPrice asc

										



