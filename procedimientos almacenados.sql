USE dbinmobiliaria
GO
--login
CREATE PROCEDURE USP_Usuario_Loguear
@pusuario varchar(50),
@pclave varchar(100)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT u.usuario_id,p.apellido,p.nombre,p.email,u.usuario,u.nivel,u.estado
			FROM dbo.Usuario as u
			INNER JOIN dbo.Persona as p
			ON u.persona_id=p.persona_id
			WHERE (u.usuario=@pusuario OR p.email=@pusuario) AND u.clave=@pclave
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

CREATE PROCEDURE USP_Persona_I
@pdni char(8),
@pnombre varchar(150),
@papellido varchar(250),
@psexo char(1),
@pemail varchar(250),
@pcelular char(9),
@pdireccion text,
@pfechanacimiento date
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Persona
			VALUES (@pdni,@pnombre,@papellido,@psexo,@pemail,@pcelular,@pdireccion,@pfechanacimiento)
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO


CREATE PROCEDURE USP_Persona_E
@pdni char(8),
@pnombre varchar(150),
@papellido varchar(250),
@psexo char(1),
@pemail varchar(250),
@pcelular char(9),
@pdireccion text,
@pfechanacimiento date
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Empleado
			VALUES (@pdni,@pnombre,@papellido,@psexo,@pemail,@pcelular,@pdireccion,@pfechanacimiento)
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

CREATE PROCEDURE USP_Inmueble_A
@pdni char(8),
@pnombre varchar(150),
@papellido varchar(250),
@pcelular char(9),
@ptipoinmueble varchar(150),
@pdireccion text
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Inmueble
			VALUES (@pdni,@pnombre,@papellido,@pcelular,@ptipoinmueble,@pdireccion)
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

--procedimiento almacenado de LISTAR en la tabla persona
CREATE PROCEDURE USP_Persona_S
AS
BEGIN
	SELECT * FROM Persona
END
GO

--procedimiento almacenado de LISTAR en la tabla empleado
CREATE PROCEDURE USP_Empleado_S
AS
BEGIN
	SELECT * FROM Empleado
END
GO

--procedimiento almacenado de LISTAR en la tabla persona
CREATE PROCEDURE USP_Inmobiliaria_S
AS
BEGIN
	SELECT * FROM Inmueble
END
GO
