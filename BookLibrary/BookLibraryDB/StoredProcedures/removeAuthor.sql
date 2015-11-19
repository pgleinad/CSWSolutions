USE [BookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[removeAuthor]    Script Date: 19/11/2015 03:20:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[removeAuthor]
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	delete from author
	where id = @id
END
