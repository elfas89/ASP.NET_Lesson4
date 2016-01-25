<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Less_4.WebUserControl1" %>
Пол:
<asp:RadioButton ID="RadioButton1" runat="server" Text="Male" OnCheckedChanged="RadioButton1_CheckedChanged" />
<asp:RadioButton ID="RadioButton2" runat="server" Text="Female" OnCheckedChanged="RadioButton2_CheckedChanged" />
<br />
<asp:Button ID="Button1" runat="server" Text="Выбрать" OnClick="Button1_Click" />
<p><asp:Label ID="Label1" runat="server" Text=""></asp:Label></p>
