<%@ Page Title="" Language="C#" MasterPageFile="~/AdminM.Master" AutoEventWireup="true" CodeBehind="paymentDetails.aspx.cs" Inherits="EmployeeManagement.paymentDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 252px;
            height: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:GridView ID="grdPaymentdetails" runat="server" OnSelectedIndexChanged="grdPaymentdetails_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Delete" ShowHeader="True" Text="Delete" />
        </Columns>
        
    </asp:GridView>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p class="auto-style7">
</p>
</asp:Content>
