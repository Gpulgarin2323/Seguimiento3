/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2014 (12.0.2269)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [registro]
GO
/****** Object:  Table [dbo].[banco]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banco](
	[username] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[numerocuenta] [nvarchar](50) NOT NULL,
	[saldo] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bancos]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bancos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[bancos] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_bancos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra_pelicula]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra_pelicula](
	[pelicula] [varchar](50) NULL,
	[precio] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[departamento] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[bancos] [varchar](50) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[referencia] [varchar](50) NULL,
 CONSTRAINT [PK_compra_pelicula] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[peliculas]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[peliculas](
	[codpeliculas] [varchar](10) NULL,
	[descripcion] [varchar](50) NULL,
	[genero] [varchar](50) NULL,
	[autor] [varchar](20) NULL,
	[nombre] [varchar](30) NULL,
	[foto] [varbinary](max) NULL,
	[precio] [varchar](20) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
ALTER TABLE [dbo].[peliculas] ADD  DEFAULT ('50000') FOR [precio]
GO
/****** Object:  StoredProcedure [dbo].[agregar_comprapelicula]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregar_comprapelicula](
@NombrePelicula varchar(50),
@precio varchar(13),
@nombre varchar(20),
@apellidos varchar (30),
@direccion varchar (30),
@ciudad varchar (30),
@departamento varchar(50),
@telefono varchar(50),
@banco varchar(20),
@referencia varchar(50)

)

as

insert into compra_pelicula ([pelicula]
      ,[precio]
      ,[nombre]
      ,[apellidos]
      ,[direccion]
      ,[ciudad]
      ,[departamento]
      ,[telefono]
      ,[bancos]
	  ,[referencia]
	  )
values (@NombrePelicula,@precio,@nombre,@apellidos,@direccion,@ciudad,@departamento,@telefono,@banco,@referencia)
GO
/****** Object:  StoredProcedure [dbo].[agregar_peliculas]    Script Date: 27/09/2017 5:04:26 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[alta_usuarios]    Script Date: 27/09/2017 5:04:26 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[buscar_usuario]    Script Date: 27/09/2017 5:04:26 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[consulta_bancos]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[consulta_bancos]
as
		
	 select * from bancos

	 
GO
/****** Object:  StoredProcedure [dbo].[consulta_peliculaapagar]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consulta_peliculaapagar]
@referencia varchar (30)

as
      			
	 select * from compra_pelicula where referencia=@referencia
GO
/****** Object:  StoredProcedure [dbo].[consulta_peliculas]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consulta_peliculas]

@nombre varchar (30)

as
      			
	 select * from peliculas where nombre=@nombre
GO
/****** Object:  StoredProcedure [dbo].[consulta_peliculasddl]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[consulta_peliculasddl]
as
		
	 select * from peliculas

	 
GO
/****** Object:  StoredProcedure [dbo].[consulta_precio]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[consulta_precio]

@nombre varchar (30)

as
		
	 select precio from peliculas WHERE nombre=@nombre
GO
/****** Object:  StoredProcedure [dbo].[eliminar_peliculas]    Script Date: 27/09/2017 5:04:26 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[eliminar_usuarios]    Script Date: 27/09/2017 5:04:26 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[ver_usuarios]    Script Date: 27/09/2017 5:04:26 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[ver_usuariosbanco]    Script Date: 27/09/2017 5:04:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ver_usuariosbanco](
@user varchar(20),
@pass varchar(30)
)
as 
select * from banco
where username=@user and pass=@pass
GO
