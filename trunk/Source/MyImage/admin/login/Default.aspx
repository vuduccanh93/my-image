<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_login_Default" Title="Untitled Page" %>
<%@ Register Src="../wuc/wucLogin.ascx" TagName="Login" TagPrefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
	<meta http-equiv="refresh" content="600" />
    <!--[if IE]><p><lin k href="inc/css/ie.css" rel="stylesheet" type="text/css" /></p><![endif]-->
    <link href="../inc/css/web.css" rel="stylesheet" type="text/css" />    
</head>
<body>
    <form id="mainform" runat="server">
      <div id="header">
          <div id="header-wrapper"></div>    
      </div>
      <div id="space"></div>
      <div id="content">
          <div id="content-wrapper">
              <uc1:Login ID="Login" runat="server" />
          </div>
      </div>
      <div id="footer">
          <div id="footer-wrapper"></div>
      </div>
    </form>
</body>
</html>
