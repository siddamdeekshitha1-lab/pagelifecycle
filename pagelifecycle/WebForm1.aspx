<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pagelifecycle.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    <asp:Label ID="label1" runat="server"></asp:Label>
    <asp:Label ID="label2" runat="server"></asp:Label>
    <asp:Label ID="label3" runat="server"></asp:Label>
    <asp:Label ID="label4" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="txtusername" runat="server" OnTextChanged="txtusername_TextChanged"></asp:TextBox><br />
    <asp:Button ID="btnsubmit" runat="server" Text="SUBMIT" OnClick="btnsubmit_Click" /><br />
    <asp:RadioButton ID="rbtnTelugu" runat="server" GroupName="language" AutoPostBack="true" OnCheckedChanged="rbtnTelugu_CheckedChanged" />Telugu
    <asp:Label ID="lbltelugu" runat="server"></asp:Label><br />
    <asp:RadioButton ID="rbtnhindi" runat="server" GroupName="language" AutoPostBack="true" OnCheckedChanged="rbtnhindi_CheckedChanged" />Hindi
    <asp:Label ID="lblhindi" runat="server"></asp:Label><br />
    <asp:RadioButton ID="rbtnEnglish" runat="server" GroupName="language" AutoPostBack="true" OnCheckedChanged="rbtnEnglish_CheckedChanged" />English
    <asp:Label ID="lblenglish" runat="server"></asp:Label>
    <br />
    <asp:CheckBox ID="chkchess" runat="server" AutoPostBack="true" OnCheckedChanged="chkchess_CheckedChanged" />Chess
                <asp:Label ID="lblmesg" runat="server"></asp:Label><br />
    <asp:CheckBox ID="chkTennis" runat="server" AutoPostBack="true" OnCheckedChanged="chkTennis_CheckedChanged" />Tennis
                <asp:Label ID="lbltennis" runat="server"></asp:Label><br />
    <asp:CheckBox ID="chkcricket" runat="server" AutoPostBack="true" OnCheckedChanged="chkcricket_CheckedChanged" />Cricket
                <asp:Label ID="lblcricket" runat="server"></asp:Label><br />
            

</div>
    </form>
</body>
</html>
