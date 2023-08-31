<%@ Page Title="" Language="C#" MasterPageFile="~/AdminM.Master" AutoEventWireup="true" CodeBehind="AssignProject.aspx.cs" Inherits="EmployeeManagement.AssignProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 291px;
            height: 49px;
            text-align: right;
        }
        .auto-style9 {
            height: 49px;
        }
        .auto-style10 {
            width: 291px;
            height: 40px;
            text-align: right;
        }
        .auto-style11 {
            height: 40px;
        }
        .auto-style12 {
            height: 40px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style8">
                <asp:Label ID="lblProjectName" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:DropDownList ID="drpProjectName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpProjectName_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="lblProjectManager" runat="server" Text="Project Manager"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="drpProjectManager" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style12" colspan="2">
                <asp:Button ID="btnAssign" runat="server" Height="35px" Text="Assign" Width="90px" OnClick="btnAssign_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Height="36px" OnClick="Button2_Click" Text="Clear" Width="87px" />
            </td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
