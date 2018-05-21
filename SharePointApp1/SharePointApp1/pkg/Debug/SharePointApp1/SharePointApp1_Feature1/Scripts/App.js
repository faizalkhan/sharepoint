'use strict';

var context = SP.ClientContext.get_current();
var user = context.get_web().get_currentUser();

var hostweburl = decodeURIComponent(getQueryStringParameter("SPHostUrl"));
var appweburl = decodeURIComponent(getQueryStringParameter("SPAppWebUrl"));
function getQueryStringParameter(paramToRetrieve) {
    var params =   document.URL.split("?")[1].split("&");
    var strParams = "";
    for (var i = 0; i < params.length; i = i + 1) {
        var singleParam = params[i].split("=");
        if (singleParam[0] == paramToRetrieve)
            return singleParam[1];
    }
}


// This code runs when the DOM is ready and creates a context object which is needed to use the SharePoint object model
$(document).ready(function () {
    getItems();
    getUserName();
});

// This function prepares, loads, and then executes a SharePoint query to get the current users information
function getUserName() {
    context.load(user);
    context.executeQueryAsync(onGetUserNameSuccess, onGetUserNameFail);
}

// This function is executed if the above call is successful
// It replaces the contents of the 'message' element with the user name
function onGetUserNameSuccess() {
    $('#message').text('Hello ' + user.get_title());
}

// This function is executed if the above call fails
function onGetUserNameFail(sender, args) {
    alert('Failed to get user name. Error:' + args.get_message());
}
var uid = "";
var form_Digest;
var form_DigestSaveData;
var del;
var save;
var obj;
var delitem;
function getFormDigest(value, obj) {
    debugger;
    var appweburl = decodeURIComponent(getQueryStringParameter('SPAppWebUrl'));
    $.ajax({
        url: appweburl + "/_api/contextinfo",
        type: "POST",
        headers: {
            "accept": "application/json;odata=verbose",
            "contentType": "text/xml"
        },
        success: function (data) {
            var requestdigest = data;
            var formDigest = data.d.GetContextWebInformation.FormDigestValue;
            if (obj == 'delitem')
            {
                deleteitem(value, formDigest);
            }
            else if (obj == 'edit') {

                edit(value, formDigest);          
            }
            else if (obj == 'update') {
           
                update(value, formDigest);
          
            }
            else if (value == 'save')
            {
        
                createListItem(formDigest);
            }
            else if (value == 'get') {

                getItems(formDigest);
            }


     
        },
        error: function (err) {
            alert(JSON.stringify(err));
        }
    });
}

function createListItem(formDigest) {

    //Fetch the values from the input elements  
    var eName = $('#txtempname').val();
    var eDesg = $('#txtdesignation').val();
    var eEmail = $('#txtemail').val();
    var eMobile = $('#txtmobile').val();
    var eBloodGroup = $('#txtbloodgrp').val();
    var eComAddress = $('#txtaddress').val();
    var eEmergency = $('#txtemergency').val();
 
    
    var executor = new SP.RequestExecutor(appweburl);

    executor.executeAsync({
   

  // $.ajax({
       async: true, // Async by default is set to “true” load the script asynchronously  
        // URL to post data into sharepoint list  

        url: appweburl + "/_api/SP.AppContextSite(@target)/web/lists/getbytitle('EmployeeList')/items?@target='" + hostweburl + "'",
        method: "POST", //Specifies the operation to create the list item  
        body: JSON.stringify({
            '__metadata': {
                'type': 'SP.Data.EmployeeListListItem' // it defines the ListEnitityTypeName  
            },
            //Pass the parameters
            'EmployeeName': eName,
            'Designation': eDesg,
            'Email': eEmail,
            'Mobile': eMobile,
            'BloodGroup': eBloodGroup,
            'CommunicationAddress': eComAddress,
            'EmergencyContact': eEmergency
        }),
        headers: {
            "accept": "application/json;odata=verbose", //It defines the Data format   
            "content-type": "application/json;odata=verbose", //It defines the content type as JSON  
            "X-RequestDigest": formDigest,
        
        },
        contentType: 'application/json',
        success: function(data) {
            swal("Item created successfully", "success"); // Used sweet alert for success message  
            debugger;
           

            $('.modal').modal('hide');
            location.reload();
        },
        error: function (error) {
            console.log(JSON.stringify(error));
            console.log(error);

        }

    })

}

function getItems(formDigest) {
  
    $.ajax({  
  
        async: true,  // Async by default is set to “true” load the script asynchronously
        url: appweburl + "/_api/SP.AppContextSite(@target)/web/lists/getbytitle('EmployeeList')/items?@target='" + hostweburl + "'",
        method: "GET",  //Specifies the operation to fetch the list item
  
        headers: {  
            "accept": "application/json;odata=verbose",   //It defines the Data format
            "content-type": "application/json;odata=verbose",  //It defines the content type as JSON
            "X-RequestDigest": formDigest,
  
        },  
        success: function (data) {

        
            data = data.d.results;  
            //Iterate the data
            $.each(data, function(index, value) {  
  
                var html = "<tr><td>" + value.EmployeeName + "</td><td>" + value.Designation + "</td><td>" + value.Email + "</td><td>" + value.BloodGroup + "</td><td>" + value.CommunicationAddress + "</td><td>" + value.EmergencyContact + "</td><td>" + value.Mobile + "</td><td><a href='#' data-target='#ModalForUpdateEmployee' data-toggle='modal' onclick='getFormDigest(" + value.Id + ", " + '"edit"' + ")'><img src='../Images/003-edit-document.png'></a></td><td><a href='#' onclick='getFormDigest(" + value.Id + ", " + '"delitem"' + ")'><img src='../Images/001-delete.png'></a></td></tr>";
                $('.table tbody').append(html);  //Append the HTML

            });  
  
            var table = $('#subsiteList').DataTable();  //initialize the dat 
        },  
        error: function(error) {  
            console.log(JSON.stringify(error));  
  
        }  
  
    })  
  
  
}


function deleteitem(value, formDigest) {

   $.ajax({
       
        
        url: appweburl + "/_api/SP.AppContextSite(@target)/web/lists/GetByTitle('EmployeeList')/items('" + value + "')?@target='" + hostweburl + "'",
        method: "POST",
        headers: {
            "accept": "application/json;odata=verbose",
            "content-type": "application/json;odata=verbose",
            "X-RequestDigest": formDigest,
            "IF-MATCH": "*",
            "X-HTTP-Method": "DELETE"
        },
        
        success: function (data) {

            swal("Deleted!", "Item Deleted successfully", "success");

            if ($.fn.DataTable.isDataTable('#subsiteList')) {
                $('#subsiteList').DataTable().destroy();
            }
            $('#subsiteList tbody').empty();


            getItems();
        },
        error: function (error) {
            console.log(JSON.stringify(error));

        }
        
    })


}


function edit(value, formDigest) {
    debugger;
    $.ajax({

        async: true,
     

        url: appweburl + "/_api/SP.AppContextSite(@target)/web/lists/GetByTitle('EmployeeList')/items('" + value + "')?@target='" + hostweburl + "'",
        method: "GET",

        headers: {
            "accept": "application/json;odata=verbose",
            "content-type": "application/json;odata=verbose",
            "X-RequestDigest": formDigest,

        },
        success: function (data) {
            console.log(data);
            console.log(data.d.EmployeeName);
            var eName = $('#txtempnames').val(data.d.EmployeeName);           
            var eDesg = $('#txtdesignations').val(data.d.Designation);
            var eEmail = $('#txtemails').val(data.d.Email);
            var eMobile = $('#txtmobiles').val(data.d.Mobile);
            var eBloodGroup = $('#txtbloodgrps').val(data.d.BloodGroup);
            var eComAddress = $('#txtaddresss').val(data.d.CommunicationAddress);
            var eEmergency = $('#txtemergencys').val(data.d.EmergencyContact);



        },
        error: function (error) {
            console.log(JSON.stringify(error));

        }


    })

    uid = value;
    obj = "update";
}
 
function update(uid, formDigest) {
    debugger;
    var eName = $('#txtempnames').val();
    var eDesg = $('#txtdesignations').val();
    var eEmail = $('#txtemails').val();
    var eMobile = $('#txtmobiles').val();
    var eBloodGroup = $('#txtbloodgrps').val();
    var eComAddress = $('#txtaddresss').val();
    var eEmergency = $('#txtemergencys').val();
    var urls = appweburl + "/_api/SP.AppContextSite(@target)/web/lists/GetByTitle('EmployeeList')/items('" + uid + "')?@target='" + hostweburl + "'";
    console.log(urls);
    $.ajax({

        
        url:urls,
   
        method: "POST",
        data: JSON.stringify({
            '__metadata': {
                'type': 'SP.Data.EmployeeListListItem'
            },
            'EmployeeName': eName,
            'Designation': eDesg,
            'Email': eEmail,
            'Mobile': eMobile,
            'BloodGroup': eBloodGroup,
            'CommunicationAddress': eComAddress,
            'EmergencyContact': eEmergency
        }),
        headers: {
            "accept": "application/json;odata=verbose",
            "content-type": "application/json;odata=verbose",
            "X-RequestDigest": formDigest,
            "IF-MATCH": "*",
            "X-HTTP-Method": "MERGE"
        },
        success: function (data) {
            swal("Item Updated successfully", "success");

            if ($.fn.DataTable.isDataTable('#subsiteList')) {
                $('#subsiteList').DataTable().destroy();
            }
            $('#subsiteList tbody').empty();


            getItems();
            $('.modal').modal('hide');
            location.reload();

        },
        error: function (error) {
            console.log(JSON.stringify(error));

        }

    })


}
