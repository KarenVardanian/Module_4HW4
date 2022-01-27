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
select SalesPerson.Bonus, COUNT(CommissionPct)
from Sales.SalesPerson
JOIN Sales.SalesTerritory as d
ON d.TerritoryID=Sales.SalesPerson.TerritoryID
group by SalesPerson.Bonus
having COUNT(CommissionPct)>2
----------------------������� �8-----------------------------
--������� ��� ���������� � ����������� (HumanResources.Employee) 
--������� ����� ����� ������� ���-�� 
--������� (HumanResources.Employee.VacationHours)
-------------------------------------------------------------
select Top(1) BusinessEntityID,NationalIDNumber,LoginID,OrganizationNode,OrganizationLevel,JobTitle,
BirthDate,Max(HumanResources.Employee.VacationHours)
from HumanResources.Employee
group by BusinessEntityID,NationalIDNumber,LoginID,OrganizationNode,OrganizationLevel,JobTitle,BirthDate

----------------------������� �9-----------------------------
--������� ��� ���������� � ����������� (HumanResources.Employee) 
--������� ����� ������� (HumanResources.Employee.JobTitle)
--'Sales Representative' ��� 'Network Administrator' ��� 'Network Manager'
-------------------------------------------------------------
select*from HumanResources.Employee
where JobTitle in('Sales Representative','Network Administrator' , 'Network Manager')
----------------------������� �10-----------------------------
--������� ��� ���������� � ����������� (HumanResources.Employee) � 
--�� ������� (Purchasing.PurchaseOrderHeader). ���� � ���������� ���
--������� �� ������ ���� ������� ����!!!
-------------------------------------------------------------
select*from HumanResources.Employee as e
join Purchasing.PurchaseOrderHeader as p
on e.BusinessEntityID=p.EmployeeID
where (p.EmployeeID is not null) or( p.EmployeeID is not null)

where e.BusinessEntityID=(select*from HumanResources.Employee)
select*from HumanResources.Employee as e
where e.BusinessEntityID>=(select PurchaseOrderHeader.EmployeeID from Purchasing.PurchaseOrderHeader)
order by (Employee.BusinessEntityID) 

select  *,(Select * from HumanResources.Employee) from Purchasing.PurchaseOrderHeader