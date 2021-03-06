USE [registro]
GO
/****** Object:  User [sapeliculasdb]    Script Date: 6/09/2017 8:57:42 p.m. ******/
CREATE USER [sapeliculasdb] FOR LOGIN [sapeliculasdb] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sapeliculasdb]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [sapeliculasdb]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [sapeliculasdb]
GO
ALTER ROLE [db_datareader] ADD MEMBER [sapeliculasdb]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [sapeliculasdb]
GO
/****** Object:  Table [dbo].[peliculas]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[peliculas](
	[codpeliculas] [varchar](10) NULL,
	[descripcion] [varchar](50) NULL,
	[genero] [varchar](50) NULL,
	[autor] [varchar](20) NULL,
	[nombre] [varchar](30) NULL,
	[foto] [varbinary](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [varchar](10) NOT NULL,
	[nom] [varchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[pass] [varchar](20) NOT NULL,
 CONSTRAINT [pk_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[agregar_peliculas]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregar_peliculas](
@codpeliculas varchar(20),
@descripcion varchar(50),
@genero varchar(50),
@autor varchar (20),
@nombre varchar (30),
@foto varbinary (max)

)

as

insert into peliculas
values (@codpeliculas,@descripcion,@genero,@autor,@nombre,@foto)


GO
/****** Object:  StoredProcedure [dbo].[alta_usuarios]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[alta_usuarios](
@id varchar(20),
@nom varchar(30),
@email varchar(50),
@pass varchar (20)
)

as

insert into usuarios
values (@id,@nom,@email,@pass)


GO
/****** Object:  StoredProcedure [dbo].[buscar_usuario]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[buscar_usuario]
@id varchar(10)
as
   select * from usuarios where 
   id=@id


GO
/****** Object:  StoredProcedure [dbo].[consulta_peliculas]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consulta_peliculas]

@nombre varchar (30)

as
      			
	 select * from peliculas where nombre=@nombre
GO
/****** Object:  StoredProcedure [dbo].[eliminar_peliculas]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   CREATE PROCEDURE [dbo].[eliminar_peliculas]


@codpeliculas varchar(10)


as
   DELETE FROM peliculas
   where codpeliculas=@codpeliculas
GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuarios]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminar_usuarios]


@id varchar(10)


as
   DELETE FROM usuarios 
   where id=@id

GO
/****** Object:  StoredProcedure [dbo].[ver_usuarios]    Script Date: 6/09/2017 8:57:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ver_usuarios](
@nom varchar(20),
@pass varchar(30)
)
as 
select * from usuarios
where nom=@nom and pass=@pass

GO
USE [registro]
GO
/****** Object:  StoredProcedure [dbo].[consulta_bancos]    Script Date: 20/09/2017 1:08:35 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[consulta_bancos]
as
		
	 select * from bancos
GO

USE [registro]
GO
/****** Object:  StoredProcedure [dbo].[consulta_precio]    Script Date: 20/09/2017 1:08:35 p.m. ******/
USE [registro]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[consulta_precio]
		@nombre = N'pruebas'

SELECT	'Return Value' = @return_value

GO