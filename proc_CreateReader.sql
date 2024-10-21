USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[CreateReader]    Script Date: 17.12.2022 13:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CreateReader]
	@FIOReader varchar(50), @birthday date, @num_phone varchar(30), @check int OUTPUT
AS
BEGIN
	DECLARE @id_reader int
	IF EXISTS (SELECT * FROM Reader WHERE num_phone = @num_phone) BEGIN
		SET @check = 1
		RETURN
	END
	BEGIN
		SELECT @id_reader = MAX(id_reader) FROM Reader
		SET @id_reader = @id_reader + 1
		INSERT INTO Reader VALUES(@id_reader, @FIOReader, @birthday, @num_phone)
		SET @check = 0
	END
END
