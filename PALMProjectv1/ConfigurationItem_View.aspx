<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfigurationItem_View.aspx.cs" Inherits="Palm.ConfigurationItem_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>PALM - Configuration Item</title>
    
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,100,300,700,900' rel='stylesheet' type='text/css'>
    <script src="Scripts/jquery-2.2.0.js"></script>
    <script src="Scripts/functions.js?version=3"></script>
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
                        

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

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
                                        <a href="FakeLogin.aspx">Log Out</a>
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
                                Configuration Items Module<small></small>
                            </h1>

                            <button type="button" class="palmButton btn btn-info btn-lg" data-toggle="modal" data-target="#myCreateModal">New CI</button>
                            
                            <asp:Button ID="btnOld" runat="server" CssClass="palmButton btn btn-info btn-lg" Text="View Disabled CI" OnClick="btnOld_Click" />
                                           
                        </div>
                    </div>
                    
                      <div class="col-md-6">
                        <div id="chartContainer" style="height: 291px; width: 100%;"class="page-header col-xs-12 text-center">
                            
                        </div>
                    </div>

                </div>

                <div id="editDiv" visible="false" runat="server" >
                    <br />
                    <asp:Table ID="tblEdit" runat="server">
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblciid" runat="server" Text="Configuration Item ID:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtCiid" runat="server" Width="121" ReadOnly="True"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblVersion" runat="server" Text="Version:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtVersion" runat="server" Width="121" ReadOnly="True"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblDescrip" runat="server" Text="Description:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtDescrip" runat="server" Width="121"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblCategory" runat="server" Text="Category:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtCategory" runat="server" Width="121"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell>
                                   <asp:Label ID="lblDate" runat="server" Text="DueDate:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtDueDate" runat="server" TextMode="Date" Width="121"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblUser" runat="server" Text="User ID:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtUser" runat="server" Width="121" ReadOnly="True"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblStatus" runat="server" Text="Status:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:DropDownList ID="lstStatus" runat="server">
                                       <asp:ListItem Text="Open" Value="1"></asp:ListItem>
                                       <asp:ListItem Text="Closed" Value="2"></asp:ListItem>
                                       <asp:ListItem Text="Deffered" Value="3"></asp:ListItem>
                                       <asp:ListItem Text="Cancelled" Value="4"></asp:ListItem>
                                   </asp:DropDownList></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblPriority" runat="server" Text="Priority:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:DropDownList ID="lstPriority" runat="server">
                                                <asp:ListItem Text="low" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="medium" Value="2"></asp:ListItem>
                                                <asp:ListItem Text="high" Value="3"></asp:ListItem>
                                             </asp:DropDownList></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblAudience" runat="server" Text="Audience:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:DropDownList ID="lstAudience" runat="server">
                                                    <asp:ListItem Text="Interal" Value="Internal" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Text="All" Value="All"></asp:ListItem>
                                              </asp:DropDownList></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell></asp:TableCell>
                               <asp:TableCell><asp:Button ID="btnEditCI" CssClass="palmButton btn btn-block" runat="server" Text="Edit" OnClick="btnEditCI_Click" /></asp:TableCell>
                           </asp:TableRow>
                       </asp:Table>
                    
                </div>

                <div id="commentDiv" visible="false" runat="server">
                    <asp:Table ID="tblComment" runat="server">
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblComCIID" runat="server" Text="Configuration Item ID:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtComCIID" runat="server" Width="121" ReadOnly="True"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblComVer" runat="server" Text="Version:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtComVer" runat="server" Width="121" ReadOnly="True"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell><asp:Label ID="lblComment" runat="server" Text="Comment:"></asp:Label></asp:TableCell>
                               <asp:TableCell><asp:TextBox ID="txtComment" TextMode="MultiLine" runat="server" Width="121"></asp:TextBox></asp:TableCell>
                           </asp:TableRow>
                           
                           <asp:TableRow>
                               <asp:TableCell></asp:TableCell>
                               <asp:TableCell><asp:Button ID="btnAddCom" CssClass="palmButton btn btn-block" runat="server" Text="Add Comment" OnClick="btnAddCom_Click" /></asp:TableCell>
                           </asp:TableRow>
                       </asp:Table>
                </div>

               <div id="gv" class="row mymargin table-responsive">
                   <asp:GridView ID="gvGetNewCI" CssClass="table table-hover" runat="server"  AutoGenerateColumns="False" DataSourceID="dsPALMCI" OnRowCommand="gvGetNewCI_RowCommand" AllowPaging="True" PageSize="6">
                       <Columns>
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button ID="btnComments" CssClass="palmButton btn btn-block" runat="server" Text="View Comments" CommandName="ViewCIComment" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                               </ItemTemplate>
                           </asp:TemplateField>
                           <asp:BoundField DataField="CIID" HeaderText="CIID" SortExpression="CIID">
                           </asp:BoundField>
                           <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" >
                           </asp:BoundField>
                           <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category">
                           </asp:BoundField>
                           <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate" DataFormatString="{0:d}">
                           </asp:BoundField>
                           <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID">
                           </asp:BoundField>
                           <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status">
                           </asp:BoundField>
                           <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority">
                           </asp:BoundField>
                           <asp:CheckBoxField DataField="Reviewed" HeaderText="Reviewed" SortExpression="Reviewed">
                           </asp:CheckBoxField>
                           <asp:BoundField DataField="Audience" HeaderText="Audience" SortExpression="Audience">
                           </asp:BoundField>
                           <asp:BoundField DataField="Version" HeaderText="Version" SortExpression="Version">
                           </asp:BoundField>
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="palmButton btn btn-block" style="width:100%" CommandName="EditCI" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"  />
                                   <asp:Button ID="btnComment" runat="server" Text="Comment" CssClass="palmButton btn btn-block" style="width:100%" CommandName="CommentCI" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                               </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button ID="btnReview" runat="server" Text="Reviewed" CssClass="palmbutton btn btn-default" style="width:100%"  CommandName="ReviewCI" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                   <asp:Button ID="btnDisable" runat="server" Text="Disable" CssClass="btn btn-danger" style="width:100%"  CommandName="DisableCI" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                   <asp:Button ID="btnVersion" runat="server" Text="All Versions" CssClass="btn btn-default" style="width:100%"  CommandName="CIVersions" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                               </ItemTemplate>
                           </asp:TemplateField>
                       </Columns>
                   </asp:GridView>
                   <asp:SqlDataSource ID="dsPALMCI" runat="server" ConnectionString="<%$ ConnectionStrings:PALM3ConnectionString2 %>" SelectCommand="spGetLatestVersionCI" SelectCommandType="StoredProcedure">
                       <SelectParameters>
                           <asp:SessionParameter Name="projectid" SessionField="ProjectID" Type="Int32" />
                       </SelectParameters>
                   </asp:SqlDataSource>
               </div>

                <%--<asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button ID="btnComments" CssClass="palmButton btn btn-block" runat="server" Text="View Comments" CommandName="ViewCIComment" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                               </ItemTemplate>
                           </asp:TemplateField>--%>
             <%--<asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="palmButton btn btn-block" style="width:100%" CommandName="EditCI" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"  />
                                   <asp:Button ID="btnComment" runat="server" Text="Comment" CssClass="palmButton btn btn-block" style="width:100%" CommandName="CommentCI" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                               </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button ID="btnDisable" runat="server" Text="Disable" CssClass="btn btn-danger" style="width:100%"  CommandName="DisableCI" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                               </ItemTemplate>
                           </asp:TemplateField>--%>
            </div>
        </div>
    </div>
    
    </form>

    <!-- Create Modal -->
<div id="myCreateModal" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content palmModal">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Create Configuration Item</h4>
      </div>
      <div class="modal-body" id="createModal">

          DESCRIPTION: <input type='text' id='txtCreateDescrip' value=''style='width:300px;'/><br /><br />
          CATEGORY: <input type='text' id='txtCreateCat' value=''style='width:300px;'/><br /><br />
          Date: <input type="date" id='txtCreateDate' value=''style='width:300px;'/><br /><br />
          STATUS: <select id='slcCreateStatus'><option value='1'>Open</option><option value='2'>Closed</option><option value='3'>Deffered</option><option value='4'>Cancelled</option></select><br /><br />
          PRIORITY:<select id='slcCreatePriority'><option selected='selected' value='1'>Low</option><option value='2'>Medium</option><option value='3'>High</option></select><br /><br />
          AUDIENCE: <select id='slcCreateAudience'><option value='1'>Internal</option><option value='2'>All</option></select>
      </div>
      <div class="modal-footer">
          <button type="button" class="btn btn-default btnCreateCI">Create</button>
          <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
      </div>
    </div>

  </div>
</div>




</body>
</html>
