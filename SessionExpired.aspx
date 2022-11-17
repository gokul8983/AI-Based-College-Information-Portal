<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SessionExpired.aspx.cs" Inherits="SessionExpire" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        form {
            border: 4px solid #f1f1f1;
        }

        /* Add some padding and a grey background color to containers */
        .container {
            padding: 20px;
            background-color: #f1f1f1;
        }

        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Session Expired</h2>
            <p>Please Login Again</p>
        </div>

        <div class="container">
            <a href="index.html">Login Again</a>
        </div>
    </form>
</body>
</html>
