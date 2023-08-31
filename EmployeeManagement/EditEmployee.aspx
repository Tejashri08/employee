<%@ Page Title="" Language="C#" MasterPageFile="~/Homemaster.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="EmployeeManagement.EditEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style19 {
            height: 39px;
            width: 363px;
            text-align: right;
        }
        .auto-style13 {
            height: 39px;
        }
        .auto-style20 {
            height: 33px;
            width: 363px;
            text-align: right;
        }
        .auto-style14 {
            height: 33px;
        }
        .auto-style21 {
            height: 35px;
            width: 363px;
            text-align: right;
        }
        .auto-style15 {
            height: 35px;
        }
        .auto-style22 {
            height: 36px;
            width: 363px;
            text-align: right;
        }
        .auto-style16 {
            height: 36px;
        }
        .auto-style23 {
            height: 30px;
            width: 363px;
            text-align: right;
        }
        .auto-style17 {
            height: 30px;
        }
        .auto-style18 {
            height: 51px;
            text-align: center;
        }
        .auto-style24 {
            height: 164px;
            width: 363px;
            text-align: right;
        }
        .auto-style26 {
            height: 62px;
            width: 363px;
            text-align: right;
        }
        .auto-style27 {
            height: 62px;
        }
        .auto-style28 {
            height: 164px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style19">
                <asp:Label ID="lblPosition" runat="server" Text="Position"></asp:Label>
            </td>
            <td class="auto-style13">
                &nbsp;</td>
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
                <asp:DropDownList ID="drpCity" runat="server" AutoPostBack="True">
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
            <td class="auto-style24">
                <asp:Label ID="lblProfilePhoto" runat="server" Text="ProfilePhoto"></asp:Label>
            </td>
            <td class="auto-style28">
                <asp:Image ID="imgProfile" runat="server" Height="132px" Width="214px" />
                <asp:Label ID="lbldemo" runat="server" Text="demo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                &nbsp;</td>
            <td class="auto-style17">
                <asp:FileUpload ID="FileUploadProfile" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style26">
            </td>
            <td class="auto-style27">
                <asp:Button ID="btnViewImage" runat="server" Height="32px" OnClick="btnViewImage_Click" Text="ViewImage" Width="179px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style18" colspan="2">
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
