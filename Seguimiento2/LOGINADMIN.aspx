<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGINADMIN.aspx.cs" Inherits="Seguimiento2.LOGINADMIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 306px;
        }
        .auto-style2 {
            width: 276px;
        }
    </style>
    
</head>
<body style="background-image:url('images/Fondo.png')">
    <form id="form1" runat="server">
        <div class="container">
    <div class="jumbotron boxlogin">
             <div class="registro">
                 <label for="username" class="form-control-label">Username Admin*</label>
                 <asp:TextBox ID="txtadmin" class="form-control" runat="server"></asp:TextBox>
          </div>
                 <div class="registro">
                        <label for="password" class="form-control-label">Password*</label>
                    <asp:TextBox ID="txtpass" class="form-control" runat="server"></asp:TextBox>

                 </div>   
            
             <div class="registro" >
                 <asp:Label ID="lblmensaje" runat="server"></asp:Label>
             </div>
                    
                <div class="registro">
                     <div class="btn">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INGRESAR" class="btn btn-success" />
                    
                    <asp:Button ID="Button2" runat="server" Text="VOLVER" class="btn btn-danger" OnClick="Button2_Click" />
                </div>

                </div>
                    
    
    </div>
        </div>
    </form>
</body>
</html>
