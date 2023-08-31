<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectManagerM.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="EmployeeManagement.Projects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="grdprojects" runat="server" OnSelectedIndexChanged="grdprojects_SelectedIndexChanged">
        </asp:GridView>
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
