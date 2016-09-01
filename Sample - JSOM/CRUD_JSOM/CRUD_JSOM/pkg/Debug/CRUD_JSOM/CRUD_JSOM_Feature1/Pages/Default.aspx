<%-- The following 4 lines are ASP.NET directives needed when using SharePoint components --%>

<%@ Page Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" MasterPageFile="~masterurl/default.master" Language="C#" %>

<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%-- The markup and script in the following Content element will be placed in the <head> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <script type="text/javascript" src="../Scripts/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="/_layouts/15/sp.runtime.js"></script>
    <script type="text/javascript" src="/_layouts/15/sp.js"></script>
    <meta name="WebPartPageExpansion" content="full" />

    <!-- Add your CSS styles to the following file -->
    <link rel="Stylesheet" type="text/css" href="../Content/App.css" />

    <!-- Add your JavaScript to the following file -->
    <script type="text/javascript" src="../Scripts/App.js"></script>

    <style>
        .ms-listviewtable {
	        width:100%;
        }

        table.ms-listviewtable thead th{
	        background-color: peachpuff;
        }

        table.ms-listviewtable tbody {
	        background-color: rgb(249, 242, 235);
        }
    </style>
</asp:Content>

<%-- The markup in the following Content element will be placed in the TitleArea of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
    Ingredients (using JSOM)
</asp:Content>

<%-- The markup and script in the following Content element will be placed in the <body> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">

    <table style="border:0px;">
        <tr>
            <td>Ingredient Name (*)</td>
            <td><input type="text" id="in-name"/></td>
            <td></td>
        </tr>
        <tr>
            <td>Ingredient Type (*)</td>
            <td><input type="text" id="in-type"/></td>
            <td></td>
        </tr>
        <tr>
            <td>Quantity (*)</td>
            <td><input type="text" id="in-qty"/></td>
            <td></td>
        </tr>
        <tr>
            <td>UOM (*)</td>
            <td><input type="text" id="in-uom"/></td>
            <td></td>
        </tr>
        <tr><td style="height:10px"></td></tr>
        <tr>
            <td align="center"></td>
            <td align="center"><input type="button" id="btn-new" value="New"/><input type="button" id="btn-add" value="Add"/></td>
            <td align="center"><input type="button" id="btn-edit" value="Edit"/><input type="button" id="btn-savedit" value="Save" disabled="disabled"/><input type="button" id="btn-delete" value="Delete"/></td>
        </tr>
    </table>
    <div id="dvMessage"></div>
    <table id="tbl-data" class="ms-listviewtable">
    
    </table>

    <%--<div>
        <p id="message">
            <!-- The following content will be replaced with the user name when you run the app - see App.js -->
            initializing...
        </p>
    </div>--%>

</asp:Content>
