﻿USE [BookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[updateauthor]    Script Date: 19/11/2015 03:21:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateauthor]
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier,
	@name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	update author
	set 
	 name = @name
	where id = @id
END
