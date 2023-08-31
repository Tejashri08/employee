<%@ Page Title="" Language="C#" MasterPageFile="~/AdminM.Master" AutoEventWireup="true" CodeBehind="Payslip.aspx.cs" Inherits="EmployeeManagement.Payslip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            height: 46px;
        }
        .auto-style9 {
            width: 368px;
            height: 39px;
        }
        .auto-style10 {
            height: 39px;
            width: 251px;
        }
        .auto-style11 {
            width: 368px;
            height: 31px;
        }
        .auto-style12 {
            height: 31px;
            width: 251px;
        }
        .auto-style13 {
            width: 368px;
            height: 34px;
        }
        .auto-style14 {
            height: 34px;
            width: 251px;
        }
        .auto-style15 {
            width: 368px;
            height: 30px;
        }
        .auto-style16 {
            height: 30px;
            width: 251px;
        }
        .auto-style17 {
            width: 368px;
            height: 40px;
        }
        .auto-style18 {
            height: 40px;
            width: 251px;
        }
        .auto-style19 {
            height: 60px;
        }
        .auto-style20 {
            width: 682px;
            height: 41px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style20">
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style8" colspan="2">
                <asp:Label ID="lblPaymentSlip" runat="server" Text="Payment Slip"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="lblProjectName" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="lblTeamLeader" runat="server" Text="Team Leader"></asp:Label>
            </td>
            <td class="auto-style12">
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblAmount" runat="server" Text="Amount"></asp:Label>
            </td>
            <td class="auto-style18">
                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style19" colspan="2">
                <asp:Button ID="btnPAY" runat="server" Text="PAY" OnClick="btnPAY_Click" />
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
