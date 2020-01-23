this is a cafeteria management system, linked to a SQL Server.

there are many concepts that have been used in this project, to give you an idea of different apporaches.


PROCEDURES:
FOR DELTEION:
create proc as [name]
as
@id int
begin
delete from [database].[dbo].[table_name] where [primary_key/identifier] = @id;
end;
/


FOR UPDATION:
create proc as [name]
as
@id int
@a varchar(50)
@b varchar(25)
as
update [database].[dbo].[table_name] set attri1 = @a, attri2 = @b where [primary_key/identified] = @id
end;
/

FOR BEST PRODUCT:
create proc as [name]
as
begin
select product_name,count(product_name) from [database].[dbo].[table_name]
order by count(product_name) desc;
end;
.

note that while inserting parameters in the database, the names of the variables must be same as in the procedure.
