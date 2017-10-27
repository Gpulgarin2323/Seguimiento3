<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Seguimiento2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
     <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
</head>
<body style="background-image:url('images/Fondo.png')">
    <form id="form1" runat="server">


        <div class="jumbotron boxlogin">
             <label for="username" class="form-control-label">Username*</label>
                        
            <asp:TextBox ID="txtusuario" runat="server" class="form-control" TabIndex="1" ToolTip="Ingrese ususario"></asp:TextBox>
             <label for="password" class="form-control-label">Password*</label>
             <asp:TextBox ID="txtcontraseña" runat="server" class="form-control" TextMode="Password" TabIndex="2" ToolTip="Ingrese contraseña"></asp:TextBox>

                <br />
             <asp:Label ID="lblmensajeusua" runat="server" Enabled="False" Text="Label" Visible="False"></asp:Label>

                <div class="registro">
                  <div class="btn">
                 <asp:Button ID="BTTiniciar" runat="server" OnClick="BTTiniciar_Click" Text="INICIAR SESION" class="btn btn-success" TabIndex="3" ToolTip="Iniciar sesion" Width="150px" />
                      <br />
                      <br />
             <asp:Button ID="BTTregistrar" runat="server" OnClick="BTTregistrar_Click" Text="REGISTRAR" class="btn btn-danger" />
                      </div>
                    </div>
        </div>
    </form>
</body>
</html>
