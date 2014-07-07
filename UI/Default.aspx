<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="UI._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 51%;
        }
        .auto-style2 {
            font-size: xx-large;
            color: #000099;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
        }
        .auto-style6 {
            height: 23px;
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>Macoratti .net - Cadastro de Cliente</strong></td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: #99CCFF">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Código</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server" BackColor="#FFFFCC" Width="94px"></asp:TextBox>
                    <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="79px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Nome</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="631px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Endereço</td>
                <td>
                    <asp:TextBox ID="txtEndereco" runat="server" Width="631px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Telefone</td>
                <td>
                    <asp:TextBox ID="txtTelefone" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEmail" runat="server" Width="631px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Observação</td>
                <td>
                    <asp:TextBox ID="txtObservacao" runat="server" Width="631px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: #99CCFF">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">
                    <asp:GridView ID="gvClientes" runat="server" Height="117px" Width="636px">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: #99CCFF">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="btnIncluir" runat="server" Text="Incluir" Width="79px" />
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" Width="79px" />
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="79px" />
                    <asp:Button ID="btnSair" runat="server" Text="Sair" Width="79px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="2">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
