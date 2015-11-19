USE [BookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[removeBook]    Script Date: 19/11/2015 03:20:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[removeBook]
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	delete from book
	where id = @id
END
