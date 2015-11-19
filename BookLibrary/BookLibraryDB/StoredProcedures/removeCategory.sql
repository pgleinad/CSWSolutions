USE [BookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[removeCategory]    Script Date: 19/11/2015 03:21:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[removeCategory]
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	delete from Category
	where id = @id
END
