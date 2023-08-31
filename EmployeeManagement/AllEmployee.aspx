<%@ Page Title="" Language="C#" MasterPageFile="~/Homemaster.Master" AutoEventWireup="true" CodeBehind="AllEmployee.aspx.cs" Inherits="EmployeeManagement.AllEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:GridView ID="grdAllEmployee" runat="server" OnSelectedIndexChanged="grdAllEmployee_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="View" ShowHeader="True" Text="View" />
        </Columns>
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
</asp:Content>
