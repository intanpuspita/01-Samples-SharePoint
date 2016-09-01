'use strict';

var context = SP.ClientContext.get_current();
var user = context.get_web().get_currentUser();
var hostWebUrl;
var appWebUrl;
var context = SP.ClientContext.get_current();

// This code runs when the DOM is ready and creates a context object which is needed to use the SharePoint object model
$(document).ready(function () {
    getUserName();

    hostWebUrl = decodeURIComponent(manageQueryStringParameter('SPHostUrl'));
    appWebUrl = decodeURIComponent(manageQueryStringParameter('SPAppWebUrl'));

    listAllIngredients();

    $("#btn-new").on("click", function () {
        Clear();
    });

    $("#btn-add").on("click", function () {
        addIngredients();
        listAllIngredients();
    });

    $("#btn-edit").on("click", function () {
        onClickUpdate();
    });

    $("#btn-savedit").on("click", function () {
        updateIngredients();
        listAllIngredients();
    });

    $("#btn-delete").on("click", function () {
        deleteIngredients();
        listAllIngredients();
    });
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

function manageQueryStringParameter(paramToRetrieve) {
    var params =
    document.URL.split("?")[1].split("&");
    var strParams = "";
    for (var i = 0; i < params.length; i = i + 1) {
        var singleParam = params[i].split("=");
        if (singleParam[0] == paramToRetrieve) {
            return singleParam[1];
        }
    }
}

function success() {
    $("#dvMessage").text("Operation Completed Successfully");

    Clear();
}

function Clear() {
    $("#in-name").val('');
    $("#in-type").val('');
    $("#in-qty").val('');
    $("#in-uom").val('');

    $("#btn-new").prop('disabled', false);
    $("#btn-add").prop('disabled', false);
    $("#btn-edit").prop('disabled', false);
    $("#btn-delete").prop('disabled', false);
    $("#btn-savedit").prop('disabled', true);

    $('.chckbox:checked').removeAttr('checked');
    $('.chckbox').prop('disabled', false);
}

function fail() {
    $("#dvMessage").text("Operation failed  " + arguments[1].get_message());
}

function listAllIngredients() {
    //Creating the Client Content object using the Url
    var ctx = new SP.ClientContext(appWebUrl);
    var appCtxSite = new SP.AppContextSite(ctx, hostWebUrl);

    //Get the Web site
    var web = appCtxSite.get_web();

    //Get the List using its name
    var list = web.get_lists().getByTitle("Ingredients");

    //The Query Object. This is used to query for data in the list
    var query = new SP.CamlQuery();
    
    query.set_viewXml('<View><RowLimit>10</RowLimit></View>');
    var items = list.getItems(query);

    //Retrieve the properties of a client object from the server
    ctx.load(list);
    ctx.load(items);


    var table = $("#tbl-data");
    var innerHtml = "<thead><tr><th></th><th>Ingredients Name</th><th>Ingredients Type</th><th>Quantity</th><th>UOM</th></tr></thead>";
    
    //Execute the Query Asynchronously
    ctx.executeQueryAsync(
        Function.createDelegate(this, function () {
            var itemInfo = '';
            var enumerator = items.getEnumerator();
            while (enumerator.moveNext())
            {
                var currentListItem = enumerator.get_current();
                innerHtml += '';
                innerHtml += "<tr><td align='center'><input type='checkbox' class='chckbox' value='" + currentListItem.get_item('ID') + "'></td><td>" + currentListItem.get_item('Title') + '</td><td>' + currentListItem.get_item('Ingredient_x0020_Type')
                    + '</td><td>' + currentListItem.get_item('Quantity') + '</td><td>' + currentListItem.get_item('UOM') + '</td></tr>';
            }
            table.html(innerHtml);
        }),
        Function.createDelegate(this, fail)
    );
}

function addIngredients() {
    //Creating the Client Content object using the Url
    var ctx = new SP.ClientContext(appWebUrl);
    var appCtxSite = new SP.AppContextSite(ctx, hostWebUrl);

    //Get the Web site
    var web = appCtxSite.get_web();

    //Get the List using its name
    var list = web.get_lists().getByTitle("Ingredients");

    //Object for creating Item in the List
    var listCreationInformation = new SP.ListItemCreationInformation();

    var listItem = list.addItem(listCreationInformation);

    listItem.set_item("Title", $("#in-name").val());
    listItem.set_item("Ingredient_x0020_Type", $("#in-type").val());
    listItem.set_item("Quantity", $("#in-qty").val());
    listItem.set_item("UOM", $("#in-uom").val());
    listItem.update();

    ctx.load(listItem);
    //Execute the batch asynchronously
    ctx.executeQueryAsync(
        Function.createDelegate(this, success),
        Function.createDelegate(this, fail)
    );
}

function onClickUpdate() {
    var ID = $('.chckbox:checked').val();

    //Creating the Client Content object using the Url
    var ctx = new SP.ClientContext(appWebUrl);
    var appCtxSite = new SP.AppContextSite(ctx, hostWebUrl);

    //Get the Web site
    var web = appCtxSite.get_web();

    //Get the List using its name
    var list = web.get_lists().getByTitle("Ingredients");
    
    var itemList = list.getItemById(ID);
    ctx.load(itemList);

    //Execute the Query Asynchronously
    ctx.executeQueryAsync(
        Function.createDelegate(this, function () {
            $("#in-name").val(itemList.get_item('Title'));
            $("#in-type").val(itemList.get_item('Ingredient_x0020_Type'));
            $("#in-qty").val(itemList.get_item('Quantity'));
            $('#in-uom').val(itemList.get_item('UOM'));

            $('.chckbox').prop('disabled', true);

            $("#btn-new").prop('disabled', true);
            $("#btn-add").prop('disabled', true);
            $("#btn-edit").prop('disabled', true);
            $("#btn-delete").prop('disabled', true);
            $("#btn-savedit").prop('disabled', false);
        }),
        Function.createDelegate(this, fail)
    );
}

function updateIngredients() {
    var ID = $('.chckbox:checked').val();

    //Creating the Client Content object using the Url
    var ctx = new SP.ClientContext(appWebUrl);
    var appCtxSite = new SP.AppContextSite(ctx, hostWebUrl);

    //Get the Web site
    var web = appCtxSite.get_web();

    //Get the List using its name
    var list = web.get_lists().getByTitle("Ingredients");
    ctx.load(list);

    var listItemToUpdate = list.getItemById(ID);
    ctx.load(listItemToUpdate);

    listItemToUpdate.set_item("Title", $("#in-name").val());
    listItemToUpdate.set_item("Ingredient_x0020_Type", $("#in-type").val());
    listItemToUpdate.set_item("Quantity", $("#in-qty").val());
    listItemToUpdate.set_item("UOM", $("#in-uom").val());
    listItemToUpdate.update();

    ctx.executeQueryAsync(
        Function.createDelegate(this, success),
        Function.createDelegate(this, fail)
    );
}

function deleteIngredients() {
    var ID = $('.chckbox:checked').val();

    //Creating the Client Content object using the Url
    var ctx = new SP.ClientContext(appWebUrl);
    var appCtxSite = new SP.AppContextSite(ctx, hostWebUrl);

    //Get the Web site
    var web = appCtxSite.get_web();

    //Get the List using its name
    var list = web.get_lists().getByTitle("Ingredients");
    ctx.load(list);

    var listItemToDelete = list.getItemById(ID);
    ctx.load(listItemToDelete);

    listItemToDelete.deleteObject();

    ctx.executeQueryAsync(
        Function.createDelegate(this, success),
        Function.createDelegate(this, fail)
    );
}