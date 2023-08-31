<%@ Page Title="" Language="C#" MasterPageFile="~/AdminM.Master" AutoEventWireup="true" CodeBehind="CompletedProjects.aspx.cs" Inherits="EmployeeManagement.CompletedProjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:GridView ID="grdcompleteprojects" runat="server" OnSelectedIndexChanged="grdcompleteprojects_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="PAY" ShowHeader="True" Text="PAY" />
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
<p>
</p>
</asp:Content>
