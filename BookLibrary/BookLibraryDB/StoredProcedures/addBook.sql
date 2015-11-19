USE [BookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[addBook]    Script Date: 19/11/2015 03:19:31 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[addBook]
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier,
	@name varchar(50),
	@authorId uniqueidentifier,
	@categoryId uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	insert into book (id, name, authorId, categoryId)
	values (@id, @name, @authorId, @categoryId)
END