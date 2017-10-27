<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MODIFICACION.aspx.cs" Inherits="Seguimiento2.MODIFICACION" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2 {
            width: 163px;
        }
        .auto-style4 {
            width: 203px;
        }
        .auto-style5 {
            width: 179px;
        }
        .auto-style6 {
            width: 219px;
        }
        .auto-style7 {
            width: 220px;
        }
    </style>
</head>
<body style="background-image:url('images/Fondo.png')">
    <form id="form1" runat="server">
    <div class="jumbotron registro">
    
        <table class="table table-striped">
            <tr>
                <td class="auto-style2">ID</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtid" runat="server" MaxLength="10" TabIndex="1"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtbid" runat="server" MaxLength="10" TabIndex="6"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txteliusuario" runat="server" MaxLength="10" TabIndex="7"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="REGRESAR" class="btn btn-success"  />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">NOMBRE</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtnom" runat="server" TabIndex="2"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblnom" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="SALIR" class="btn btn-danger" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">E-MAIL</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtemail" runat="server" TabIndex="3"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblemail" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">PASS</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtpass" runat="server" TabIndex="4"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblpass" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">CODPELICULA</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtcodpelicula" runat="server" MaxLength="10" TabIndex="8"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Label ID="lblbusqueda" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">
                    
                     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AGREGAR USUARIOS" class="btn btn-success" Width="196px" TabIndex="5" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="BUSCAR USUARIOS" class="btn btn-danger" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="ELIMINAR USUARIOS" class="btn btn-success" Width="202px" /> 
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="ELIMINAR PELICULA" class="btn btn-danger" /> 
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

