<%@ Page Title="" Language="C#" MasterPageFile="~/Homemaster.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeManagement.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            height: 39px;
        }
        .auto-style14 {
            height: 33px;
        }
        .auto-style15 {
            height: 35px;
        }
        .auto-style16 {
            height: 36px;
        }
        .auto-style17 {
            height: 30px;
        }
        .auto-style18 {
            height: 51px;
            text-align: center;
        }
        .auto-style19 {
            height: 39px;
            width: 363px;
            text-align: right;
        }
        .auto-style20 {
            height: 33px;
            width: 363px;
            text-align: right;
        }
        .auto-style21 {
            height: 35px;
            width: 363px;
            text-align: right;
        }
        .auto-style22 {
            height: 36px;
            width: 363px;
            text-align: right;
        }
        .auto-style23 {
            height: 30px;
            width: 363px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style19">
                <asp:Label ID="lblPosition" runat="server" Text="Position"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:DropDownList ID="drpPosition" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style22">
                <asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style19">
                <asp:Label ID="lblContury" runat="server" Text="Contury"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:DropDownList ID="drpContury" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpContury_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style22">
                <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:DropDownList ID="drpState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpState_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:DropDownList ID="drpCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpCity_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style17">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:Label ID="lblProfilePhoto" runat="server" Text="ProfilePhoto"></asp:Label>
            </td>
            <td class="auto-style17">
                <asp:FileUpload ID="FileUploadProfile" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style18" colspan="2">
                <asp:Button ID="btnRegister" runat="server" Height="35px" Text="Register" Width="84px" OnClick="btnRegister_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Height="36px" Text="Clear" Width="95px" OnClick="btnClear_Click" />
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
