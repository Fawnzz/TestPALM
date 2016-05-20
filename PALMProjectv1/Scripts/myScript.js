

function Edit() {
    var par = $(this).parent().parent(); //tr
    var tdIssueId = par.children("td:nth-child(1)");
    var tdProjectId = par.children("td:nth-child(2)");
    var tdStatus = par.children("td:nth-child(3)");
    var tdPriority = par.children("td:nth-child(4)");
    var tdUser = par.children("td:nth-child(5)");
    var tdName = par.children("td:nth-child(6)");
    var tdDescription = par.children("td:nth-child(7)");
    var tdType = par.children("td:nth-child(8)");
    var tdAudience = par.children("td:nth-child(9)");
    var tdVersion = par.children("td:nth-child(10)");
    var tdPreviousVersion = par.children("td:nth-child(11)");
    var tdControls = par.children("td:nth-child(12)");

    var tdIssueIdData = tdIssueId.html();
    var tdProjectIdData = tdProjectId.html();
    var tdStatusData = tdStatus.html();
    var tdPriorityData = tdPriority.html();
    var tdUserData = tdUser.html();
    var tdNameData = tdName.html();
    var tdDescriptionData = tdDescription.html();
    var tdTypeData = tdType.html();
    var tdAudienceData = tdAudience.html();
    var tdVersionData = tdVersion.html();
    var tdPreviousVersionData = tdPreviousVersion.html();
    var tdControlsData = tdControls.html();

    //tdIssueId.html("<input type='text' id='txtName' value='" + tdIssueIdData + "'style='width:50px;'/>");
   // tdProjectId.html("<input type='text' id='txtPhone' value='" + tdProjectIdData + "'/>");
    tdStatus.html("<select id='slcStatus'><option value='1'>Pending</option><option value='2'>Reviewed</option></select>");
    if (tdPriority.parent('tr.danger').length) {
        tdPriority.html("<select id='slcPriority'><option value='1'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else if (tdPriority.parent('tr.warning').length) {
        tdPriority.html("<select id='slcPriority'><option value='1'>Low</option><option value='2' selected='selected'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else if (tdPriority.parent('tr.success').length) {
        tdPriority.html("<select id='slcPriority'><option value='1' selected='selected'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else tdPriority.html("<select id='slcPriority'><option value='1'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
  //  tdUser.html("<select id='slcStatus'><option value='1'>Pending</option><option value='2'>Reviewed</option></select>");
    tdName.html("<input type='text' id='txtName' value='" + tdNameData + "'style='width:150px;'/>");
    tdDescription.html("<input type='text' id='txtDescription' value='" + tdDescriptionData + "'style='width:200px;'/>");
    tdType.html("<input type='text' id='txtType' value='" + tdTypeData + "'style='width:100px;'/>");
    tdAudience.html("<select id='slcAudience'><option value='1'>Internal</option><option value='2'>All</option></select>");
   // tdVersion.html("<input type='text' id='txtEmail' value='" + tdVersionData + "'style='width:50px;'/>");
    // tdPreviousVersion.html("<input type='text' id='txtEmail' value='" + tdPreviousVersionData + "'style='width:50px;'/>");
    tdControls.html("<button class='btn btn-default btnSubmit' id='btnSubmit'>SUBMIT</button><button class='btn btn-default btnCancel' id='btnCancel'>CANCEL</buton>")
      
};

function Submit() {
    var par = $(this).parent().parent(); //tr
    var tdIssueId = par.children("td:nth-child(1)");
    var tdProjectId = par.children("td:nth-child(2)");
    var tdStatus = par.children("td:nth-child(3)");
    var tdPriority = par.children("td:nth-child(4)");
    var tdUser = par.children("td:nth-child(5)");
    var tdName = par.children("td:nth-child(6)");
    var tdDescription = par.children("td:nth-child(7)");
    var tdType = par.children("td:nth-child(8)");
    var tdAudience = par.children("td:nth-child(9)");
    var tdVersion = par.children("td:nth-child(10)");
    var tdPreviousVersion = par.children("td:nth-child(11)");
    var tdControls = par.children("td:nth-child(12)");

    var tdIssueIdData = tdIssueId.html();
    var tdProjectIdData = tdProjectId.html();
    var tdStatusData = tdStatus.html();
    var tdPriorityData = tdPriority.html();
    var tdUserData = tdUser.html();
    var tdNameData = tdName.html();
    var tdDescriptionData = tdDescription.html();
    var tdTypeData = tdType.html();
    var tdAudienceData = tdAudience.html();
    var tdVersionData = tdVersion.html();
    var tdPreviousVersionData = tdPreviousVersion.html();
    var tdControlsData = tdControls.html();

    //tdIssueId.html("<input type='text' id='txtName' value='" + tdIssueIdData + "'style='width:50px;'/>");
    // tdProjectId.html("<input type='text' id='txtPhone' value='" + tdProjectIdData + "'/>");
    tdStatus.html("<select id='slcStatus'><option value='1'>Pending</option><option value='2'>Reviewed</option></select>");
    if (tdPriority.parent('tr.danger').length) {
        tdPriority.html("<select id='slcPriority'><option value='1'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else if (tdPriority.parent('tr.warning').length) {
        tdPriority.html("<select id='slcPriority'><option value='1'>Low</option><option value='2' selected='selected'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else if (tdPriority.parent('tr.success').length) {
        tdPriority.html("<select id='slcPriority'><option value='1' selected='selected'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else tdPriority.html("<select id='slcPriority'><option value='1'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    //  tdUser.html("<select id='slcStatus'><option value='1'>Pending</option><option value='2'>Reviewed</option></select>");
    tdName.html("<input type='text' id='txtName' value='" + tdNameData + "'style='width:150px;'/>");
    tdDescription.html("<input type='text' id='txtDescription' value='" + tdDescriptionData + "'style='width:200px;'/>");
    tdType.html("<input type='text' id='txtType' value='" + tdTypeData + "'style='width:100px;'/>");
    tdAudience.html("<select id='slcAudience'><option value='1'>Internal</option><option value='2'>All</option></select>");
    // tdVersion.html("<input type='text' id='txtEmail' value='" + tdVersionData + "'style='width:50px;'/>");
    // tdPreviousVersion.html("<input type='text' id='txtEmail' value='" + tdPreviousVersionData + "'style='width:50px;'/>");
    tdControls.html("<button class='btn btn-default btnSubmit' id='btnSubmit'>SUBMIT</button><button class='btn btn-default btnCancel' id='btnCancel'>CANCEL</buton>")

};

function Cancel() { };

