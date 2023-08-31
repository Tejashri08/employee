<%@ Page Title="" Language="C#" MasterPageFile="~/TeamleaderM.Master" AutoEventWireup="true" CodeBehind="TeamLeader.aspx.cs" Inherits="EmployeeManagement.TeamLeader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            height: 57px;
            width: 505px;
            text-align: center;
        }
        .auto-style8 {
            height: 53px;
            text-align: right;
        }
        .auto-style9 {
            height: 47px;
            text-align: center;
        }
        .auto-style10 {
            height: 54px;
            width: 505px;
            text-align: center;
        }
        .auto-style11 {
            height: 49px;
            width: 505px;
            text-align: center;
            margin-left: 40px;
        }
        .auto-style12 {
            height: 52px;
            text-align: center;
        }
        .auto-style13 {
            height: 57px;
            width: 332px;
            text-align: center;
        }
        .auto-style14 {
            height: 54px;
            width: 332px;
            text-align: center;
        }
        .auto-style15 {
            height: 49px;
            width: 332px;
            text-align: center;
        }
        .auto-style16 {
            height: 57px;
            width: 314px;
            text-align: center;
        }
        .auto-style17 {
            height: 54px;
            width: 314px;
            text-align: center;
        }
        .auto-style18 {
            height: 49px;
            width: 314px;
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
            <td class="auto-style8" colspan="3">
                <asp:Label ID="lblTLName" runat="server" Text="TL Name"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="3">
                <asp:Label ID="lblProjectName" runat="server" Text="Project Name"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Label ID="lblPN1" runat="server" Text="PN"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:Label ID="lblitr1" runat="server" Text="Iteration1"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:Button ID="btnActive1" runat="server" BackColor="#6666FF" OnClick="btnActive1_Click" Text="Active" />
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="lblPN2" runat="server" Text="PN"></asp:Label>
            </td>
            <td class="auto-style17">
                <asp:Label ID="lblitr2" runat="server" Text="Iteration2"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:Button ID="btnActive2" runat="server" BackColor="#6666FF" Enabled="False" OnClick="btnActive2_Click" Text="Active" />
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Label ID="lblPN3" runat="server" Text="PN"></asp:Label>
            </td>
            <td class="auto-style18">
                <asp:Label ID="lblitr3" runat="server" Text="Iteration3"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:Button ID="btnActive3" runat="server" BackColor="#6666FF" Enabled="False" OnClick="btnActive3_Click" Text="Active" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12" colspan="3">
                <asp:Button ID="btnLogout" runat="server" BackColor="#66FFFF" Height="38px" OnClick="btnLogout_Click" Text="Logout" Width="123px" />
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
    <p>
    </p>
</asp:Content>
