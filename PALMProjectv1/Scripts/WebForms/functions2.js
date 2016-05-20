function EditIssue() {
    var par = $(this).parent().parent(); //tr
    var tdStatus = par.children("td:nth-child(3)");
    var tdPriority = par.children("td:nth-child(4)");
    var tdName = par.children("td:nth-child(6)");
    var tdDescription = par.children("td:nth-child(7)");
    var tdType = par.children("td:nth-child(8)");
    var tdAudience = par.children("td:nth-child(9)");
    var tdControls = par.children("td:nth-child(12)");


    var tdStatusData = tdStatus.html();
    var tdPriorityData = tdPriority.html();
    var tdNameData = tdName.html();
    var tdDescriptionData = tdDescription.html();
    var tdTypeData = tdType.html();
    var tdAudienceData = tdAudience.html();
    var tdControlsData = tdControls.html();

    //tdIssueId.html("<input type='text' id='txtName' value='" + tdIssueIdData + "'style='width:50px;'/>");
    // tdProjectId.html("<input type='text' id='txtPhone' value='" + tdProjectIdData + "'/>");
    tdStatus.html("<select id='slcStatusEdit'><option value='1'>Pending</option><option value='2'>Reviewed</option></select>");
    if (tdPriority.parent('tr.danger').length) {
        tdPriority.html("<select id='slcPriorityEdit'><option value='1'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else if (tdPriority.parent('tr.warning').length) {
        tdPriority.html("<select id='slcPriorityEdit'><option value='1'>Low</option><option value='2' selected='selected'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else if (tdPriority.parent('tr.success').length) {
        tdPriority.html("<select id='slcPriorityEdit'><option value='1' selected='selected'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    }
    else tdPriority.html("<select id='slcPriorityEdit'><option value='1'>Low</option><option value='2'>Medium</option><option value='3' selected='selected'>High</option></select>");
    //  tdUser.html("<select id='slcStatus'><option value='1'>Pending</option><option value='2'>Reviewed</option></select>");
    tdName.html("<input type='text' id='txtNameEdit' value='" + tdNameData + "'style='width:150px;'/>");
    tdDescription.html("<input type='text' id='txtDescriptionEdit' value='" + tdDescriptionData + "'style='width:200px;'/>");
    tdType.html("<input type='text' id='txtTypeEdit' value='" + tdTypeData + "'style='width:100px;'/>");
    tdAudience.html("<select id='slcAudienceEdit'><option value='1'>Internal</option><option value='2'>All</option></select>");
    // tdVersion.html("<input type='text' id='txtEmail' value='" + tdVersionData + "'style='width:50px;'/>");
    // tdPreviousVersion.html("<input type='text' id='txtEmail' value='" + tdPreviousVersionData + "'style='width:50px;'/>");
    tdControls.html("<button class='btn btn-default btnSubmit' id='btnSubmit'>SUBMIT</button><!--<button class='btn btn-default btnCancel' id='btnCancel'>CANCEL</buton>-->");
    $(".btnSubmit").bind("click", SubmitIssue);
};

function SubmitIssue() {
    var par = $(this).parent().parent(); //tr
    var tdIssueId = par.children("td:nth-child(1)");
    var tdProjectId = par.children("td:nth-child(2)");
    var tdUser = par.children("td:nth-child(5)");
    var tdVersion = par.children("td:nth-child(10)");
    var tdPreviousVersion = par.children("td:nth-child(11)");
    var tdControls = par.children("td:nth-child(12)");

    var tdIssueIdData = tdIssueId.html();
    var tdProjectIdData = tdProjectId.html();
    var tdVersionData = tdVersion.html();
    var tdPreviousVersionData = tdPreviousVersion.html();
    var slcStatus = document.getElementById("slcStatusEdit");
    var tdStatusData = slcStatus.options[slcStatus.selectedIndex].value;
    var slcPriority = document.getElementById("slcPriority");
    var tdPriorityData = slcPriority.options[slcPriority.selectedIndex].value;
    var txtName = document.getElementById("txtNameEdit");
    var tdNameData = txtName.value;

    var tdUserData = tdUser.html();
    var txtDescription = document.getElementById("txtDescriptionEdit");
    var tdDescriptionData = txtDescription.value;
    var txtType = document.getElementById("txtTypeEdit");
    var tdTypeData = txtType.value;
    var slcAudience = document.getElementById("slcAudienceEdit");
    var tdAudienceData = slcAudience.options[slcAudience.selectedIndex].value;

    alert("IssueID: " + tdIssueIdData + " ProjectID: " + tdProjectIdData + " Status: " + tdStatusData + " Priority: " + tdPriorityData + "User: " + tdUserData + "Name: " + tdNameData + "Description: " + tdDescriptionData + "Type: " + tdTypeData + "Audience: " + tdAudienceData + "Version: " + tdVersionData + "PreviousVersion: " + tdPreviousVersionData);
    $.ajax({
        type: "POST",
        url: "../IssueHome.aspx/EditIssue",
        contentType: "application/json; charset=utf-8",
        data: "{issueid:" + JSON.stringify(tdIssueIdData) + ",projectid:" + JSON.stringify(tdProjectIdData) + ",status:" + JSON.stringify(tdStatusData) + ",priority:" + JSON.stringify(tdPriorityData) + ",user:" + JSON.stringify(tdUserData) + ",name:" + JSON.stringify(tdNameData) + ",description:" + JSON.stringify(tdDescriptionData) + ",type:" + JSON.stringify(tdTypeData) + ",audience:" + JSON.stringify(tdAudienceData) + ",version:" + JSON.stringify(tdVersionData) + ",previous_version:" + JSON.stringify(tdPreviousVersionData) + "}",
        success: function (msg) {
            par.html("<div class='col-md-12 text-center'>success</div>");
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }
    });

};
function IssueComments() {
    var par = $(this).parent().parent(); //tr
    var tdName = par.children("td:nth-child(6)");
    var tdNameData = tdName.html();
    var tdIssueId = par.children("td:nth-child(1)");
    var tdIssueIdData = tdIssueId.html();

    document.getElementById("comments-title").innerHTML = "Comments for <span style='font-weight:800'>" + tdNameData + "</span>" + " Issue";
    $(".modal-body").attr('id', tdIssueIdData);
    alert(tdIssueIdData);

    $.ajax({
        type: "POST",
        url: "../IssueHome.aspx/GetComments",
        contentType: "application/json; charset=utf-8",
        data: "{issueid:" + JSON.stringify(tdIssueIdData) + "}",
        success: function (msg) {
            alert("Data passed successfuly");
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }
    });

};
function DeleteIssue() {
    var par = $(this).parent().parent(); //tr
    var tdIssueId = par.children("td:nth-child(1)");
    var tdIssueIdData = tdIssueId.html();

    alert(tdIssueIdData);
    $.ajax({
        type: "POST",
        url: "../IssueHome.aspx/DeleteIssue",
        contentType: "application/json; charset=utf-8",
        data: "{ issueid:" + JSON.stringify(tdIssueIdData) + "}",
        success: function (msg) {
            par.html("<div class='col-md-12 text-center'>success</div>");
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }
    });

};
function CancelIssue() {
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
function CreateIssue() {



    var slcStatus = document.getElementById("slcStatus");
    var status = slcStatus.options[slcStatus.selectedIndex].value;
    var slcPriority = document.getElementById("slcPriority");
    var priority = slcPriority.options[slcPriority.selectedIndex].value;

    var txtName = document.getElementById("txtName");
    var name = txtName.value;
    var txtDescription = document.getElementById("txtDescription");
    var description = txtDescription.value;
    var txtType = document.getElementById("txtType");
    var type = txtType.value;
    var slcAudience = document.getElementById("slcAudience");
    var audience = slcAudience.options[slcAudience.selectedIndex].value;


    alert("Status: " + status + " Priority: " + priority + " " + "Name: " + name + "Description: " + description + "Type: " + type + "Audience: " + audience);
    $.ajax({
        type: "POST",
        url: "../IssueHome.aspx/CreateIssue",
        contentType: "application/json; charset=utf-8",
        data: "{ status:" + JSON.stringify(status) + ",priority:" + JSON.stringify(priority) + ",name:" + JSON.stringify(name) + ",description:" + JSON.stringify(description) + ",type:" + JSON.stringify(type) + ",audience:" + JSON.stringify(audience) + "}",
        success: function (msg) {
            document.getElementById("createModal").innerHTML("<div class='col-md-12 text-center'>Issue created successfully.</div>");
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }
    });

};



$(function () {
    $(".btnEditIssue").bind("click", EditIssue);
    $(".btnCancelIssue").bind("click", CancelIssue);
    $(".btnDeleteIssue").bind("click", DeleteIssue);
    $(".btnCreateIssue").bind("click", CreateIssue);
    $(".btnIssueComments").bind("click", IssueComments);
});