<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web-service-try.aspx.cs" Inherits="ASP.NET_pages.web_service_try" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"/>
    <title></title>
    <style>
        .search_categories{
            cursor: pointer;
            width: 30%;
            font-size: 13px;
            padding: 10px 8px 10px 14px;
            background: #fff;
            border: 1px solid #ccc;
            border-radius: 6px;
            overflow: hidden;
            position: relative;
        }
        
        .search_categories select{
            cursor: pointer;
            background: transparent;
            line-height: 1;
            border: 0;
            padding: 0;
            border-radius: 0;
            width: 100%;
            position: relative;
            z-index: 10;
            font-size: 1em;
        }

        .first{
            height: 60vh;
            background-color: antiquewhite;
        }

        .second{
            height: 40vh;
            background-color: #2f2f2f;
            color: #fff;
        }

        .text{
            margin-top: 15%;
            font-size: 18px;
        }

        .prices{
            padding-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center class="first">
            <a style="float: right; padding-right: 7px;" href="https://nsemeniuk.000webhostapp.com/">Main page</a>
            <p style="padding-top: 100px; font-size: 18px;">Please, select product:</p>
            <div class="search_categories">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Font-Size="Medium">
                    <asp:ListItem>Gold</asp:ListItem>
                    <asp:ListItem>Silver</asp:ListItem>
                    <asp:ListItem>Platinum</asp:ListItem>
                    <asp:ListItem>Palladium</asp:ListItem>
                    <asp:ListItem>Rhodium</asp:ListItem>
                    <asp:ListItem>Crude oil</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="text">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
        </center>
        <center class="second">
            <div class="prices">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </center>
    </form>
</body>
</html>
