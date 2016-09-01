'use strict';

var context = SP.ClientContext.get_current();
var user = context.get_web().get_currentUser();

// This code runs when the DOM is ready and creates a context object which is needed to use the SharePoint object model
$(document).ready(function () {
    //getUserName();

    var spAppWebUrl = decodeURIComponent(getQueryStringParameter('SPAppWebUrl'));

    $("#searchButton").on("click", function () {
        var queryUrl = spAppWebUrl + "/_api/search/query?querytext='" + $("#searchTextBox").val() + "'";
        $.ajax({ url: queryUrl, method: "GET", headers: { "Accept": "application/json; odata=verbose" }, success: onQuerySuccess, error: onQueryError });
    });
});

function onQuerySuccess(data) {
    var results = data.d.query.PrimaryQueryResult.RelevantResults.Table.Rows.results;

    var innerHtml = '<table>';
   
    $.each(results, function() {
        innerHtml += '<tr>';
        $.each(this.Cells.results, function () {
            innerHtml += '<td>' + this.Value + '</td>';
        })
        innerHtml += '</tr>';
    });
    //innerHtml += '</table>';

    $("#resultsDiv").append(innerHtml);
}

function onQueryError(error) {
    $("#resultsDiv").append(error.statusText)
}

//function to get a parameter value by a specific key
function getQueryStringParameter(urlParameterKey) {
    var params = document.URL.split('?')[1].split('&');
    var strParams = '';

    for (var i = 0; i < params.length; i = i + 1) {
        var singleParam = params[i].split('=');
        if (singleParam[0] == urlParameterKey)
            return decodeURIComponent(singleParam[1]);
    }

}

//// This function prepares, loads, and then executes a SharePoint query to get the current users information
//function getUserName() {
//    context.load(user);
//    context.executeQueryAsync(onGetUserNameSuccess, onGetUserNameFail);
//}

//// This function is executed if the above call is successful
//// It replaces the contents of the 'message' element with the user name
//function onGetUserNameSuccess() {
//    $('#message').text('Hello ' + user.get_title());
//}

//// This function is executed if the above call fails
//function onGetUserNameFail(sender, args) {
//    alert('Failed to get user name. Error:' + args.get_message());
//}
