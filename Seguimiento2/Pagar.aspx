<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagar.aspx.cs" Inherits="Seguimiento2.Pagar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />

    <link href="css/Compras.css" rel="stylesheet" />
    <title>Pagar</title>
</head>
<body>
    <form id="form1" runat="server">

<div class="jumbotron boxlogin">
    <h1 class="text-center">Pagar</h1>
           
            <!-- Button -->
            <div class="col-md-12">
                <label class="col-md-4 control-label" for="btnpagar"></label>
                <div class="btn">
                   
                    <asp:Button ID="btnpagar" runat="server" CssClass="btn btn-primary btnperso align-content-center" TabIndex="9" Text="haz clic aqui para pagar" OnClick="btnpagar_Click" />
                </div>
            </div>
        </div>
 
    </form>
</body>
</html>
