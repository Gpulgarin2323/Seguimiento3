<%@ page language="C#" autoeventwireup="true" codebehind="ComprarPelicula.aspx.cs" inherits="Seguimiento2.ComprarPelicula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/bootstrap.css" rel="stylesheet" />

    <link href="css/Compras.css" rel="stylesheet" />
    <title>Comprar Pelicula</title>
</head>
<body style="background-image: url('images/Fondo.png')">
    <form id="form1" runat="server">

        <div class="container jumbotron">
            <div class="row">
                <div class="col-xs-12 text-center col-md-6">

                    <h1>Comprar Pelicula</h1>


            <asp:ScriptManager ID="MyScriptManager" runat="server" />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <!-- Select Basic -->
                    <div class="col-md-4">
                        <label class="col-md-4 control-label" for="ddlpeliculas">Peliculas</label>
                        <div class="col-md-4">
                            <asp:DropDownList ID="ddlpeliculas" runat="server" AutoPostBack="true" TabIndex="1" OnSelectedIndexChanged="ddlpeliculas_SelectedIndexChanged" ToolTip="Seleccione la pelicula a comprar" Height="30px" Width="170px">
                            </asp:DropDownList>
                        </div>
                    </div>


                    <!-- Text input-->
                    <div class="col-md-4">
                        <label class="col-md-4 control-label" for="txtprecio">Precio</label>
                        <div class="col-md-4">

                            <asp:TextBox ID="txtprecio" Enabled="false" runat="server"></asp:TextBox>

                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="ddlpeliculas" EventName="SelectedIndexChanged" />
                </Triggers>
            </asp:UpdatePanel>
            <!-- Text input-->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="txtnombre">Nombre</label>
                <div class="col-md-4">
                     <asp:TextBox ID="txtnombres" runat="server" TabIndex="2" MaxLength="25" ToolTip="ingrese nombres"></asp:TextBox>

                </div>
            </div>
            <!-- Text input-->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="txtapellidos">Apellidos</label>
                <div class="col-md-4">
                     <asp:TextBox ID="txtapellidos" runat="server" TabIndex="3" MaxLength="30" ToolTip="ingrese apellidos"></asp:TextBox>

                </div>
            </div>

            <!-- Text input-->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="txtdireccion">Dirección</label>
                <div class="col-md-4">
                     <asp:TextBox ID="txtdireccion" runat="server" TabIndex="4" MaxLength="30" ToolTip="ingrese direccion"></asp:TextBox>

                </div>
            </div>

            <!-- Text input-->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="txtciudad">Ciudad</label>
                <div class="col-md-4">
                     <asp:TextBox ID="txtciudad" runat="server" TabIndex="5" MaxLength="15" ToolTip="ingrese ciudad de recidencia"></asp:TextBox>

                </div>
            </div>

            <!-- Text input-->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="txtdepartamento">Departamento</label>
                <div class="col-md-4">
                     <asp:TextBox ID="txtdepartamento" runat="server" TabIndex="6" MaxLength="15" ToolTip="ingrese departamento"></asp:TextBox>

                </div>
            </div>

            <!-- Text input-->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="txttelefono">Teléfono</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txttelefono" runat="server" TabIndex="7" MaxLength="11" ToolTip="ingrese telefono o celular"></asp:TextBox>

                </div>
            </div>


            <!-- Select Basic -->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="ddlbancos">Bancos</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlbancos" runat="server" TabIndex="8" Height="18px" Width="148px">
                    </asp:DropDownList>
                </div>
            </div>
                    </div>
                
                <div class="col-xs-12 text-center col-md-6">
                    <h1>Datos de pago</h1>

                    <!-- Text input-->

                    <div class="col-md-8">
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Número de cuenta"></asp:Label>
                            <asp:TextBox ID="txtnumerocuenta" runat="server"></asp:TextBox>
                            <div class="row">
                                <!-- Text input-->
                                <div class="col-md-6">

                                    <asp:Label ID="Label2" runat="server" Text="fecha vencimiento"></asp:Label>
                                    <asp:DropDownList ID="ddlfecha" runat="server"></asp:DropDownList>
                                </div>
                                <div class="col-md-6">

                                    <asp:Label ID="Label3" runat="server" Text="año de vencimiento"></asp:Label>
                                    <asp:DropDownList ID="ddlano" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                            <asp:Label ID="Label4" CssClass="control-label" runat="server" Text="codigo de seguridad"></asp:Label>
                            <asp:TextBox ID="txtcodigoseguridad" runat="server"></asp:TextBox>

            <!-- Button -->
            <div class="col-md-4">
                <label class="col-md-4 control-label" for="btnpagar"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnpagar" runat="server" CssClass="btn btn-primary btnperso" TabIndex="9" Text="Pagar" OnClick="btnpagar_Click" Width="100px" />
                </div>
            </div>
        </div>
                        </div>

                    </div>
                </div>
        </div>
    </form>
</body>
</html>
