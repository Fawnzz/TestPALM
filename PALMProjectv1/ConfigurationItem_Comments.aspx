<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfigurationItem_Comments.aspx.cs" Inherits="PALMProjectv1.ConfigurationItem_Comments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>PALM - Configuration Item</title>
    
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,100,300,700,900' rel='stylesheet' type='text/css'>
    <script src="Scripts/jquery-2.2.0.js"></script>
    <link href="~/css/bootstrap.min.css" rel="stylesheet" runat="server"/>
    <link href="~/css/style.css" rel="stylesheet" runat="server"/>
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
                                        <a href="#">Log Out</a>
                                    </li>
                                    
                                  
                                </ul>
                            </li>
                        </ul>
                     
                       
                        
                    </div>

                </nav>
                <div class="row mymargin">
                    <div class="col-md-6">
                        <div class="col-xs-12 text-center">
                            <h1 style="height:300px; line-height:300px">
    Configuration
                            </h1>
                                           
                        </div>
                    </div>
                      <div class="col-md-6">
                        <div id="chartContainer" style="height: 291px; width: 100%;"class="page-header col-xs-12 text-center">
                            
                        </div>
                    </div>

                </div>
                <div>
                    <asp:Button ID="btnBack" CssClass="palmButton btn btn-default btn-lg" runat="server" Text="Return" OnClick="btnBack_Click"/>
                </div>
               <div id="gvDisabledCI" class="row mymargin table-responsive">
                   <asp:GridView ID="gvGetOldCI" CssClass="table table-hover" runat="server" AutoGenerateColumns="False" DataSourceID="dsPALMCI">
                       <Columns>
                           <asp:BoundField DataField="CIID" HeaderText="CIID" SortExpression="CIID">
                           </asp:BoundField>
                           <asp:BoundField DataField="Version" HeaderText="Version" SortExpression="Version" >
                           </asp:BoundField>
                           <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID">
                           </asp:BoundField>
                           <asp:BoundField DataField="Comment" HeaderText="Comment" SortExpression="Comment" />
                       </Columns>
                   </asp:GridView>
                   <asp:SqlDataSource ID="dsPALMCI" runat="server" ConnectionString="<%$ ConnectionStrings:PALM3ConnectionString2 %>" SelectCommand="spViewCIComments" SelectCommandType="StoredProcedure">
                       <SelectParameters>
                           <asp:SessionParameter DefaultValue="" Name="ciid" SessionField="CIID" Type="Int32" />
                       </SelectParameters>
                   </asp:SqlDataSource>
               </div>
                
            </div>
            
        </div>
    </div>
    
    </form>
</body>
</html>
