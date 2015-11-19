declare @author1 uniqueidentifier = NEWID();
declare @author2 uniqueidentifier = NEWID();
declare @author3 uniqueidentifier = NEWID();
declare @author4 uniqueidentifier = NEWID();
declare @author5 uniqueidentifier = NEWID();

insert into author (id, name)
values (@author1,'autor 1')
,(@author2,'autor 2')
,(@author3,'autor 3')
,(@author4,'autor 4')
,(@author5,'autor 5');

declare @category1 uniqueidentifier = NEWID();
declare @category2 uniqueidentifier = NEWID();
declare @category3 uniqueidentifier = NEWID();
declare @category4 uniqueidentifier = NEWID();
declare @category5 uniqueidentifier = NEWID();

insert into Category (id, name, [description])
values (@category1, 'category 1', 'description 1')
,(@category2, 'category 2', 'description 2')
,(@category3, 'category 3', 'description 3')
,(@category4, 'category 4', 'description 4')
,(@category5, 'category 5', 'description 5');



insert into Book (id, name, authorId, categoryId)
values (NEWID(), 'book 1', @author1, @category1)
,(NEWID(), 'book 2', @author2, @category2)
,(NEWID(), 'book 3', @author3, @category3)
,(NEWID(), 'book 4', @author4, @category4)
,(NEWID(), 'book 5', @author5, @category5)  