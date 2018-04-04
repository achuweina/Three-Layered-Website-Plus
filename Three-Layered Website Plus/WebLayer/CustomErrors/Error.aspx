<% Response.StatusCode = Convert.ToInt32(Request.QueryString["code"]); %>
<!DOCTYPE html>
<html>
<head>
    <title>Error - <%: Response.StatusCode %>: <%: Response.Status %></title>
</head>
<body>
We are sorry an error happened and the response code: <b><%: Response.StatusCode %></b> was returned.
</body>
</html>