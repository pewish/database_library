USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[AddGiving]    Script Date: 21.12.2022 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AddGiving]
	@id_book int, @id_sotr int, @id_reader int, @add_date date, @check int OUTPUT
AS
BEGIN
	SET @check = 0
	IF EXISTS (SELECT * FROM Book WHERE id_book = @id_book)
	BEGIN
		IF EXISTS(SELECT * FROM Giving WHERE id_book = @id_book)
		BEGIN
			SET @check = 1
			RETURN
		END
		IF (SELECT availability FROM Book WHERE id_book = @id_book) = 'нет'
		BEGIN
			SET @check = 2
			RETURN
		END
		IF (SELECT del FROM Book WHERE id_book = @id_book) = 'да'
		BEGIN
			SET @check = 3
			RETURN
		END
		DECLARE @id_giving int
		SELECT @id_giving = MAX(id_giving) FROM Giving
		SET @id_giving = @id_giving + 1
		INSERT INTO Giving VALUES(@id_giving, @id_book, @id_sotr, @id_reader, @add_date)
		UPDATE Book SET availability = 'нет' WHERE id_book = @id_book
	END
	ELSE
	SET @check = 4
END
