<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Seguimiento2.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    </head>
<body style="background-image:url('images/Fondo.png')">
    <form id="form1" runat="server">
    <div class="container col-lg-6 registro">
        <div class="jumbotron">
    
            <table class="table table-striped">
                <tr>
                    <td class="auto-style2">ID (identificacion)</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtid" runat="server" MaxLength="10"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="REVid" runat="server" ControlToValidate="txtid" ErrorMessage="SOLO VALORES NUMERICOS SIN SUPERAR LOS 10 DIGITOS" Font-Size="Large" SetFocusOnError="True" ValidationExpression="[1-9][0-9]+"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">NOMBRE (usuario)</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtnombre" runat="server" MaxLength="30"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="REVnombre" runat="server" ControlToValidate="txtnombre" ErrorMessage="EL NOMBRE NO PUEDE PASAR DE LOS 30 CARACTERES Y TENER UN MINIMO DE 3 CARACTERES SIN USAR ESPACIOS" SetFocusOnError="True" ValidationExpression="([A-Z]|[a-z]|[0-9])([A-Z]|[a-z]|[0-9])([A-Z]|[a-z]|[0-9])+"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">E-mail</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtemail" runat="server" MaxLength="50" ></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="REVemail" runat="server" ControlToValidate="txtemail" ErrorMessage="EMAIL INVALIDO " SetFocusOnError="True" ValidationExpression="(([A-Z]|[a-z]|[0-9]|[-]|[.])+)@([a-z|A-Z|0-9]+).([a-z|A-Z|0-9]+).([a-z|A-Z|0-9]+)"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">CONTRASEÑA</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtcontraseña" runat="server" MaxLength="50"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="REVcontraseña" runat="server" ControlToValidate="txtcontraseña" ErrorMessage="DEBE TENER MINIMO 4 CARACTERES Y UN MAXIMO DE 50" SetFocusOnError="True" ValidationExpression="([a-z]|[A-Z]|[0-9])([a-z]|[A-Z]|[0-9])([a-z]|[A-Z]|[0-9])([a-z]|[A-Z]|[0-9])+"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        
                        <asp:Button ID="BTTconfirm" runat="server" OnClick="BTTconfirm_Click" Text="CONFIRMAR" cssclass="btn btn-success" />
                    </td>
                    <td class="auto-style4">
                        
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CANCELAR" cssclass="btn btn-danger" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style9">
                        <asp:Label ID="lblcomunicado" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
             </div>
        </div>
    </form>
</body>
</html>

