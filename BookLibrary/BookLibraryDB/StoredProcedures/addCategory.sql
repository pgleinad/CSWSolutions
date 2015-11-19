﻿USE [BookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[addCategory]    Script Date: 19/11/2015 03:20:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addCategory]
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier,
	@name varchar(50),
	@description text
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	insert into Category(id, name, [description])
	values (@id, @name, @description)
END