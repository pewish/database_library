USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[AddAdmission]    Script Date: 21.12.2022 17:36:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AddAdmission]
	@id_book int, @id_sotr int, @id_reader int, @add_date date, @check int OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Book WHERE id_book = @id_book)
	BEGIN
		IF EXISTS(SELECT * FROM Admission WHERE id_book = @id_book)
		BEGIN
			SET @check = 1
			RETURN
		END
		IF (SELECT availability FROM Book WHERE id_book = @id_book) = 'да'
		BEGIN
			SET @check = 2
			RETURN
		END
		IF (SELECT id_reader FROM Giving WHERE id_book = @id_book) IN 
		(SELECT id_reader from Reader WHERE id_reader = @id_reader) BEGIN
			DECLARE @id_add int
			SELECT @id_add = MAX(id_add) FROM Admission
			SET @id_add = @id_add + 1
			INSERT INTO Admission VALUES(@id_add, @id_book, @id_sotr, @id_reader, @add_date)
			UPDATE Book SET availability = 'да' WHERE id_book = @id_book
			SET @check = 0
		END ELSE SET @check = 4
	END
	ELSE
	SET @check = 3
END
