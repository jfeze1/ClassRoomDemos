﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BasicControls.aspx.cs" Inherits="WebApp.samplePages.BasicControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Basic Controls</h1>
    <div class="row">
        <div class="col-sm-offset-1 col-sm-10">
            <div class="alert alert-info">
                <blockquote style="font-style:italic">
                    This page will demonstrate some basic controls of a web page. We will investigate the CheckBox, textBox, RadioButtonList, DropDownList,
                    Label, Literal, and Submit Buttons(Button and Link Button)
                    The formatting of the controls will be done in &lt; table &gt; tag.
                    We will investigate event driven logic and how it differs from the top down logic on Razor/form page
                </blockquote>
            </div>
        </div>
    </div>
    <br />
    <table align="center" style="width: 80%">
        <tr>
            <td align="right">TextBox:</td>
            <td>
                <asp:TextBox ID="TextBoxNumberChoice" runat="server"></asp:TextBox>
                <asp:Button ID="SubmitButtonChoice" runat="server" Text="Submit Choice" CssClass="btn btn-primary" OnClick="SubmitButtonChoice_Click"/> &nbsp; (Enter a number from 1 to 4)
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label1" runat="server" Text="Choice: CheckBox"></asp:Label>
            </td>
            <td><asp:RadioButtonList ID="RadioButtonListListChoice" runat="server"
                RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Value="1">COM1008&nbsp;</asp:ListItem>
                <asp:ListItem Value="3">CPSC1517&nbsp;</asp:ListItem>
                <asp:ListItem Value="2">DMIT1508&nbsp;</asp:ListItem>
                <asp:ListItem Value="4">DMIT2018&nbsp;</asp:ListItem>
                </asp:RadioButtonList></td>
            
        </tr>
        <tr>
            <td align="right"><asp:Literal ID="Literal1" runat="server" Text="RadioButtonList"></asp:Literal></td>
            <td><asp:CheckBox ID="CheckBoxChoice" runat="server" /></td>
        </tr>
        <tr>
            <td align="right"><asp:Label ID="DisplayDataReadOnly" runat="server" Text="Display Label"></asp:Label></td>

            
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td align="right"><asp:Label ID="Label4" runat="server" Text="View Collection"></asp:Label></td>
            <td>
                <asp:DropDownList ID="CollectionList" runat="server"></asp:DropDownList>
                <asp:LinkButton ID="LinkButtonSubmitChoice" runat="server" OnClick="LinkButtonSubmitChoice_Click">Submit Collection Choice</asp:LinkButton>
            </td>
            
        </tr>
        <tr>
            <td colspan="2" align="right">&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="MessageLabel" runat="server"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
