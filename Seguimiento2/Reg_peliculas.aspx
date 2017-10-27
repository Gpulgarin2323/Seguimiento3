<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg_peliculas.aspx.cs" Inherits="Seguimiento2.Reg_peliculas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 37px;
        }
        .auto-style4 {
            height: 76px;
        }
    </style>
</head>
<body style="background-image:url('images/Fondo.png')">
    <form id="form1" runat="server">
    <div class="jumbotron registro">
    
        <table class="table table-striped">
            <tr>
                <td class="auto-style10">CODIGO DE LA PELICULA</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtcodPelicula" runat="server" MaxLength="10"></asp:TextBox>
                    
                </td>
                <td class="auto-style12">
                    
                    <asp:Button ID="bttregresar" runat="server" OnClick="bttregresar_Click" Text="REGRESAR" class="btn btn-success" />
                </td>
            </tr>
            <tr>
                <td>DESCRIPCION</td>
                <td>
                    <asp:TextBox ID="txtdescripcion" runat="server" Height="68px" Width="242px" MaxLength="50"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style13">GENERO</td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtgenero" runat="server" MaxLength="50"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">AUTOR</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtautor" runat="server" MaxLength="20"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style16">NOMBRE DE LA PELICULA</td>
                <td class="auto-style17">
                    <asp:TextBox ID="txtnombrePelicula" runat="server" MaxLength="30"></asp:TextBox>
                </td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style16">Precio</td>
                <td class="auto-style17">
                    <asp:TextBox ID="txtprecioPelicula" runat="server" MaxLength="13" ToolTip="Ingrese el precio de la pelicula"></asp:TextBox>
                </td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style4">FOTO PELICULA</td>
                <td class="auto-style9">
                    <asp:Image ID="pcbfoto" runat="server" Height="126px" Width="124px" />
                    <asp:FileUpload ID="tufoto" runat="server" CssClass="mb-0" />
                    
                    <asp:Button ID="bttsubirfoto" runat="server" OnClick="bttsubirfoto_Click" Text="SUBIR"  class="btn btn-danger" />

                </td>
                <td class="auto-style2">
                    
                    
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">VIDEO DE LA PELICULA</td>
                <td class="auto-style3">
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                    
                    <asp:Button ID="bttsubirpdf" runat="server" Text="SUBIR"   class="btn btn-danger" OnClick="bttsubirpdf_Click" />
                </td>
                <td class="auto-style3">
                    
                    
                    <asp:Button ID="BTAGREGAR" runat="server" OnClick="BTAGREGAR_Click" Text="AGREGAR PELICULA" class="btn btn-success" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style2">
                    
                    
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
