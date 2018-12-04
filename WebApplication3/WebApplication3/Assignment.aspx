<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment.aspx.cs" Inherits="WebApplication3.Assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfAssid" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Write the Assignment:"></asp:Label>

                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtAss" runat="server" TextMode ="MultiLine"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td colspan ="2">
                        <asp:Button ID="Butsave" runat="server" Text="Save" />
                        <asp:Button ID="Butdel" runat="server" Text="Delete" />
                        <asp:Button ID="Butclear" runat="server" Text="Clear" />
                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td colspan ="2">
                        <asp:Label ID="LabelforSuccessMsg" runat="server" Text=""></asp:Label>
                    </td>
                    <tr>
                    <td>

                    </td>
                    <td colspan ="2">
                        <asp:Label ID="LabelforErrorMsg" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                </tr>
                
            </table>
            <br />
            <asp:GridView ID="GvAss" runat="server"></asp:GridView>
            <Columns>
                <asp:BoundField DataField =" Name"
            </Columns>
        </div>
    </form>
    
</body>
</html>
