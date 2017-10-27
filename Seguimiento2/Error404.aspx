<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error404.aspx.cs" Inherits="Seguimiento2.Error404" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/style.css" rel="stylesheet" type="text/css"  media="all" />
    <title></title>
    <style type="text/css">
        .nuevoEstilo1 {
            background-color: #008000;
            visibility: collapse;
            float: none;
            overflow: auto;
            display: table-cell;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
		<!--start-wrap--->
		<div class="wrap">
			<!---start-header---->
				<div class="header">
					<div class="logo">
						<h1><a href="#">Ohh pagina no encontrada</a></h1>
					</div>
				</div>
			<!---End-header---->
			<!--start-content------>
			<div class="content">
				<img src="images/error-img.png" title="error" />
				<p><span><label>O</label>hh.....</span>You Requested the page that is no longer There.</p>
				<asp:Button ID="Btnregresar" cssclass="btn btn-success" runat="server" Text="Regresa a la home"  OnClick="Btnregresar_Click" />
				<div class="copy-right">
					<p>&#169 All rights Reserved | Designed by <a href="http://w3layouts.com/">W3Layouts</a></p>
				</div>
   			</div>
			<!--End-Cotent------>
		</div>
		<!--End-wrap--->

    </form>
</body>
</html>
