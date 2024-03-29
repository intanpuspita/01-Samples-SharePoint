﻿<%@ Assembly Name="Contoso.SharePoint.ISBN_Field_Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f37fa848c21f2be9" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#"%>
<SharePoint:RenderingTemplate ID="ISBNFieldControl" runat="server">
  <Template>
    <asp:Label ID="ISBNPrefix" Text="ISBN" runat="server" />
    &nbsp;
    <asp:TextBox ID="TextField" runat="server"  />
  </Template>
</SharePoint:RenderingTemplate>
<SharePoint:RenderingTemplate ID="ISBNFieldControlForDisplay" runat="server">
  <Template>
    <asp:Label ID="ISBNValueForDisplay" runat="server" />
  </Template>
</SharePoint:RenderingTemplate>
