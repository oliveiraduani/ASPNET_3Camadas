<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ILoginCadastro.aspx.vb" Inherits="UI.ILoginCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Login</title>
    <style type ="text/css"> 
        .auto-style1 { 
            width: 81%;
            height: 255px;
        }
        .auto-style2 { 
            font-size: xx-large ;
            color: #0026ff;
        }
        .auto-style4 { 
            height: 23px;
        }
        .auto-style5 {

        }
        .auto-style6 {
            height: 23px;
            width:128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>MR Computadores - Cadastro Login</strong></td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: #f3c065">&nbsp;</td>
            </tr>
            <tr> 
                <td class="auto-style5">Id &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server" BackColor="#FFFFCC" Width="94px"></asp:TextBox>

                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
