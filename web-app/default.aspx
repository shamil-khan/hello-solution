<%@ Page Language="C#"%>

<script runat="server">

    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        LinkEcho.Click += (s, e1) => TextResponse.Text = string.Format("({0:hh.mm.ss.ffffff}) - default - {1}", DateTime.Now, TextRequest.Text);
    }

</script>

<!DOCTYPE >
<html>
<head runat="server">
    <title>Shamil Khan - Test Application</title>
    <link href="css/common.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="navbar">
        <a href="silverlight-client.aspx">Silverlight Page</a>
        <a href="echo.aspx">Echo Page</a>
        <a href="/services/product-service.svc/products/10">Products 10</a>
        <a href="/services/product-service.svc/products/100">Products 100</a>
        <a href="/services/product-service.svc/product/1215">Product # 1215</a>
        <a href="/services/echo-service.svc/echo/hello">Echo - Hello</a>
    </div>
    <br />
    <br />
    <div>
        <asp:TextBox ID="TextRequest" Text="Hello" Width="200px" runat="server" />
        <asp:LinkButton ID="LinkEcho" Text="Echo 1" Width="120px" runat="server" />
        <asp:Label ID="TextResponse" Width="100%" runat="server" />
    </div>
    </form>
</body>
</html>
