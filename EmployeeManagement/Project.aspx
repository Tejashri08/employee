<%@ Page Title="" Language="C#" MasterPageFile="~/Homemaster.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="EmployeeManagement.Project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            height: 42px;
        }
        .auto-style14 {
            height: 50px;
        }
        .auto-style15 {
            height: 39px;
        }
        .auto-style16 {
            height: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style13">
                <asp:Label ID="lblProjectName" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="txtProjectName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="lblTechnology" runat="server" Text="Technology"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:DropDownList ID="drpTechnology" runat="server" Height="16px" AutoPostBack="True" OnSelectedIndexChanged="drpTechnology_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Label ID="lblStartDate" runat="server" Text="Start Date"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblEndDate" runat="server" Text="End Date"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style16">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
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
    <p>
    </p>
</asp:Content>
