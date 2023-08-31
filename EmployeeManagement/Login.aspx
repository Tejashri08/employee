<%@ Page Title="" Language="C#" MasterPageFile="~/Homemaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeeManagement.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            height: 46px;
        }
        .auto-style14 {
            height: 40px;
        }
        .auto-style15 {
            height: 46px;
            width: 482px;
        }
        .auto-style16 {
            height: 40px;
            width: 482px;
        }
        .auto-style17 {
            height: 45px;
            width: 482px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style15">
                <asp:Label ID="lblPosition" runat="server" Text="Position"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:DropDownList ID="drpPosition" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
