USE [BookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[updateBook]    Script Date: 19/11/2015 03:22:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateBook]
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
	update book
	set 
	 name = @name,
	 authorId= @authorId,
	 categoryId = @categoryId
	where id = @id
END