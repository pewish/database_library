USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[AddBooking]    Script Date: 21.12.2022 17:39:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AddBooking]
	@id_book int, @id_reader int, @booking_date date, @check int OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Book WHERE id_book = @id_book)
	BEGIN
		IF EXISTS(SELECT * FROM Booking WHERE id_book = @id_book)
		BEGIN
			SET @check = 1
			RETURN
		END
		IF (SELECT del FROM Book WHERE id_book = @id_book) = 'да'
		BEGIN
			SET @check = 2
			RETURN
		END
		IF (SELECT availability FROM Book WHERE id_book = @id_book) = 'нет'
		BEGIN
			SET @check = 4
			RETURN
		END
		INSERT INTO Booking VALUES(@id_reader, @id_book, @booking_date)
		UPDATE Book SET availability = 'нет' WHERE id_book = @id_book
		SET @check = 0
	END ELSE 
	SET @check = 3
END
