<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FakeLogin.aspx.cs" Inherits="PALMProjectv1.FakeLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>PALM - Configuration Item</title>
    
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,100,300,700,900' rel='stylesheet' type='text/css'>
    <script src="Scripts/jquery-2.2.0.js"></script>
    <script src="Scripts/functions.js?version=2"></script>
    <link href="~/css/bootstrap.css?version=2" rel="stylesheet" runat="server"/>
    <link href="~/css/style.css?version=2" rel="stylesheet" runat="server"/>
    <script src="Scripts/bootstrap.min.js"></script>

    <script src="Scripts/jquery.canvasjs.min.js"></script>
  <% 
                                            
                                    int low = PalmBusinessLayer.ConfigurationItemsDB.GetLow();
                                    int medium = PalmBusinessLayer.ConfigurationItemsDB.GetMedium();
                                    int high = PalmBusinessLayer.ConfigurationItemsDB.GetHigh();
                                    
      %>
       
    <script type="text/javascript">
        window.onload = function () {
            var chart = new CanvasJS.Chart("chartContainer",
            {
                title: {
                    text: "PRIORITY TRACKER",
                    fontFamily: "Roboto",
                    fontWeight: 300
                },
                animationEnabled: true,
                legend: {
                    verticalAlign: "bottom",
                    horizontalAlign: "center"
                },
                data: [
                {
                    indexLabelFontSize: 20,
                    indexLabelFontWeight: 100,
                    indexLabelFontFamily: "Roboto",
                    indexLabelFontColor: "black",
                    indexLabelLineColor: "darkgrey",
                    indexLabelPlacement: "outside",
                    type: "pie",
                    showInLegend: true,
                    toolTipContent: "{y} - <strong>#percent%</strong>",
                    dataPoints: [
                        { y: <%=low%>, legendText: "<%=low%>", exploded: true,indexLabel: "LOW" },
                        { y: <%=high%>, legendText: "<%=high%>", exploded: true, indexLabel: "HIGH" },
                        { y: <%=medium%>, legendText: "<%=medium%>", exploded: true,indexLabel: "MEDIUM" },
                       
                    ]
                }
                ]
            });
            chart.render();
        }
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                 <nav class="navbar navbar-default2" role="navigation">
                    <div class="navbar-header">
                        

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; v

                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                            <span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
                        </button> <a class="navbar-brand" href="#"><img src="img/logo.png"  width="94px"/></a>
                    </div>

                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav">
                            <li class="active">
                                <a href="Project_Home.aspx">PROJECT</a>
                            </li>
                            <li>
                                <a href="IssueHome.aspx">ISSUES</a>
                            </li>
                            <li>
                                <a href="CreateRisk.aspx">RISKS</a>
                            </li>
                            <li>
                                <a href="CR_Home.aspx">CHANGE REQUESTS</a>
                            </li>
                            <li>
                                <a href="QAMain.aspx">QUALITY ASSURANCE</a>
                            </li>
                            <li>
                                <a href="ConfigurationItem_View.aspx">CONFIGURATION ITEMS</a>
                            </li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-off"></span>   <strong class="caret"></strong></a>
                                <ul class="dropdown-menu">
                                    <li>
                                        <a href="#">Profile</a>
                                    </li>
                                    <li>
                                        <a href="#">Your Comments</a>
                                    </li>
                                    <li>
                                        <a href="#">Change Password</a>
                                    </li>
                                    <li class="divider">
                                    </li>
                                    <li>
                                   
                                    </li>
                                    
                                  
                                </ul>
                            </li>
                        </ul>
                     
                    </div>

                </nav>
              

            </div>
        </div>
    </div>
    
        <div>

            <asp:Table ID="tblLogin" runat="server">
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="lblUser" runat="server" Text="User ID:"></asp:Label></asp:TableCell><asp:TableCell>
                        <asp:DropDownList ID="lstUser" runat="server">
                            <asp:ListItem Text="2029602" Value="2029602"></asp:ListItem>
                            <asp:ListItem Text="2004154" Value="2004154"></asp:ListItem>
                            <asp:ListItem Text="1010101" Value="1010101"></asp:ListItem>
                        </asp:DropDownList></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="lblRole" runat="server" Text="Role:"></asp:Label></asp:TableCell><asp:TableCell>
                        <asp:DropDownList ID="lstRole" runat="server">
                            <asp:ListItem Text="CI Manager" Value="CIManager"></asp:ListItem>
                            <asp:ListItem Text="Client" Value="Client"></asp:ListItem>
                        </asp:DropDownList></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="lblProject" runat="server" Text="Project ID:"></asp:Label></asp:TableCell><asp:TableCell>
                        <asp:DropDownList ID="lstProject" runat="server">
                            <asp:ListItem Text="1001" Value="1001"></asp:ListItem>
                            <asp:ListItem Text="1002" Value="1002"></asp:ListItem>
                            <asp:ListItem Text="1003" Value="1003"></asp:ListItem>
                        </asp:DropDownList></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
     
        </div>


    </form>

</body>
</html>
