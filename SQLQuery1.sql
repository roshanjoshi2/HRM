
CREATE TABLE Employee(

ID int identity primary key not null,
[Name] nvarchar (200) not null,
[Address] nvarchar(300),
Gender char(1) not null,
DOB datetime

)




insert into Employee
values('Roshan Joshi','sankhamul','M','1999/08.17')

insert into Employee
values('Sita Joshi','sankhamul','F','1999/08.17')


select * from Employee

--delete from Employee where ID=3

