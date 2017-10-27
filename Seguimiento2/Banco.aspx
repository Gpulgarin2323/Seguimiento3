<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Banco.aspx.cs" Inherits="Seguimiento2.Banco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/login.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>banco</title>
</head>
<body style="background-image: url('images/banco-01.jpg')">
    <form id="form1" runat="server">
        <div>
            <!-- Text input-->
<div class="form-group">
 <div class="jumbotron boxlogin">
     <div>
        <h1 class="text-xl-center"> Banco</h1>
         </div>
             <label for="username" class="form-control-label">Usuario*</label>
  <div class="col-xs-4">
       <asp:TextBox ID="txtusuario"  placeholder="Ingrese usuario" class="form-control input-md" runat="server"></asp:TextBox>
        </div>
     <br />
     <label for="password" class="form-control-label">Contraseña*</label>
     <div class="col-xs-4">
         <asp:TextBox ID="txtpass" placeholder="Ingrese contraseña" class="form-control input-md" runat="server"></asp:TextBox>
         </div>
      <br />
      
     <asp:Button ID="btnentrar" runat="server" class="btn btn-success" Text="entrar" OnClick="btnentrar_Click" />
    </div>
        </div>
            </div>
    </form>
</body>
</html>
