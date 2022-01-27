use AdventureWorks2017
----------------------������� �1-----------------------------
--������� ��� ���������� �� ������� Sales.Customer 
-------------------------------------------------------------
select*from Sales.Customer
----------------------������� �2-----------------------------
--������� ��� ���������� �� ������� Sales.Store ��������������� 
--�� Name � ���������� �������
-------------------------------------------------------------
select *from Sales.Store
order by Sales.Store.Name asc
----------------------������� �3-----------------------------
--������� �� ������� HumanResources.Employee ��� ����������
--� ������ �����������, ������� �������� ����� 1989-09-28
-------------------------------------------------------------
select Top(10)*from HumanResources.Employee
where BirthDate>'1989-09-28'
----------------------������� �4-----------------------------
--������� �� ������� HumanResources.Employee �����������
--� ������� ��������� ������ LoginID �������� 0.
--������� ������ NationalIDNumber, LoginID, JobTitle.
--������ ������ ���� ������������� �� JobTitle �� ��������
-------------------------------------------------------------
select NationalIDNumber,LoginID,JobTitle
from HumanResources.Employee
where HumanResources.Employee.LoginID like'%0'
order by JobTitle desc
----------------------������� �5-----------------------------
--������� �� ������� Person.Person ��� ���������� � �������, ������� ���� 
--��������� � 2008 ���� (ModifiedDate) � MiddleName ��������
--�������� � Title �� �������� �������� 
-------------------------------------------------------------
select *from Person.Person
where ModifiedDate Between '2008'and '2009' and
Person.MiddleName is not null and
Title is null
----------------------������� �6-----------------------------
--������� �������� ������ (HumanResources.Department.Name) ��� ����������
--� ������� ���� ����������
--������������ ������� HumanResources.EmployeeDepartmentHistory � HumanResources.Department
-------------------------------------------------------------
select Distinct HumanResources.Department.Name as hd
from HumanResources.Department
inner join HumanResources.EmployeeDepartmentHistory h
on HumanResources.Department.DepartmentID=h.DepartmentID
where EndDate is not null

----------------------������� �7-----------------------------
--������������ ������ �� ������� Sales.SalesPerson �� TerritoryID
--� ������� ����� CommissionPct, ���� ��� ������ 0
-------------------------------------------------------------
select*from Sales.SalesTerritory
select*from Sales.SalesPerson
SELECT Sales.SalesTerritory.Name, Group,SaleYTD FROM Sales.SalesTerritory
JOIN Sales.SalesTerritory as d
ON d.TerritoryID=Sales.SalesTerritory.TerritoryID