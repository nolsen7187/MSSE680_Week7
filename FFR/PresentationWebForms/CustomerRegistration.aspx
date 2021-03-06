﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="PresentationWebForms.CustomerRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style1
        {
            width: 153px;
        }
        .auto-style2
        {
            width: 394px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 60%; margin-right: 0px;">
        <tr>
            <td class="auto-style1">First Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="FirstNameTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Last Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="LastNameTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">City:</td>
            <td class="auto-style2">
                <asp:TextBox ID="CityTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">State:</td>
            <td class="auto-style2">
                <asp:TextBox ID="StateTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Street:</td>
            <td class="auto-style2">
                <asp:TextBox ID="StreetTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Zip:</td>
            <td class="auto-style2">
                <asp:TextBox ID="ZipTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Address:</td>
            <td class="auto-style2">
                <asp:TextBox ID="AddressTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Phone:</td>
            <td class="auto-style2">
                <asp:TextBox ID="PhoneTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Email:</td>
            <td class="auto-style2">
                <asp:TextBox ID="EmailTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
        <asp:Button ID="CustomerButton" runat="server" OnClick="Button1_Click" Text="Register" />
            </td>
            <td class="auto-style2">
                <asp:Label ID="SuccessLabel" runat="server" ForeColor="Red" Width="275px"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
