<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_Planilla.aspx.cs" Inherits="Calculo_Planilla.Frm_Planilla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        Cálculo de Planilla
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre del Colaborador: ">

            </asp:Label>
            <asp:TextBox ID="Obj_Colaborador" runat="server">

            </asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Horas Trabajadas: ">

            </asp:Label>
            <asp:TextBox ID="Obj_Horas_Trabajadas" runat="server">

            </asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Horas Extras: ">

            </asp:Label>
            <asp:TextBox ID="Obj_Horas_extras" runat="server">

            </asp:TextBox>
            <br />
            <hr />
            <asp:Label ID="Label4" runat="server" Text="Costo por Hora: ">

            </asp:Label>
            <asp:TextBox ID="Obj_Costo_Hora" runat="server">

            </asp:TextBox>

            <br />
            <hr />
            <asp:Button ID="Obj_Calcular" runat="server" Text="Calcular" OnClick="Obj_Calcular_Click" />
            <br />
            <hr />

            <asp:Label ID="Label5" runat="server" Text="Salario Bruto: ">

            </asp:Label>
            <asp:TextBox ID="Obj_Salario_Bruto" runat="server">

            </asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Deducciones: ">

            </asp:Label>
            <asp:TextBox ID="Obj_Deducciones" runat="server">

            </asp:TextBox>
            <br />
            <hr />
            <asp:Label ID="Label7" runat="server" Text="Salario Neto: ">

            </asp:Label>
            <asp:TextBox ID="Obj_Salario_Neto" runat="server">

            </asp:TextBox>
            <br />
            <hr />
        </div>
    </form>
</body>
</html>
