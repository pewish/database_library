USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[LoginProc]    Script Date: 18.12.2022 13:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LoginProc]
	@login int, @password int, @check int OUTPUT
AS
BEGIN
	IF EXISTS (SELECT id_sotr FROM Sotr WHERE id_sotr=@login AND id_sotr=@password)
	BEGIN
		DECLARE @position varchar(50), @fired varchar(10)
		IF EXISTS (SELECT position FROM Sotr WHERE id_sotr = @login)
		BEGIN
			IF (SELECT fired FROM Sotr WHERE id_sotr = @login) = 'нет'
			BEGIN
				SET @position = (SELECT position FROM Sotr WHERE id_sotr = @login)
				IF (@position = 'Директор') BEGIN
					SET @check = 1
					RETURN
				END
				IF (@position LIKE 'Библиотекарь%') BEGIN
					SET @check = 2
					RETURN
				END
				IF (@position = 'Специалист по учетно-хранительской деятельности') BEGIN
					SET @check = 3
					RETURN
				END
				ELSE
				SET @check = 5
			END
			IF (SELECT fired FROM Sotr WHERE id_sotr = @login) = 'да'
			BEGIN
				SET @check = 5
				RETURN
			END
		END
	END
	IF EXISTS (SELECT id_reader FROM Reader WHERE id_reader=@login AND id_reader=@password) BEGIN
		SET @check = 4
		RETURN
	END
END
