<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectManagerM.Master" AutoEventWireup="true" CodeBehind="ProjectManagerAssignP.aspx.cs" Inherits="EmployeeManagement.ProjectManagerAssignP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            height: 57px;
        }
        .auto-style11 {
            height: 53px;
        }
        .auto-style12 {
            height: 61px;
        }
        .auto-style13 {
            height: 57px;
            width: 334px;
            text-align: right;
        }
        .auto-style14 {
            height: 53px;
            width: 334px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <table class="auto-style9">
        <tr>
            <td class="auto-style13">
                <asp:Label ID="lblProjetcs" runat="server" EnableViewState="False" Text="Projetcs"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:DropDownList ID="drpProjetcs" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="lblTeamLeader" runat="server" Text="Team Leader"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="drpTeamLeader" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style12" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAssign" runat="server" Height="32px" OnClick="btnAssign_Click" Text="Assign" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Height="29px" Text="Clear" Width="87px" />
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
