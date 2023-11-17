function changeAddFavoritesButton(id) {
    document.getElementById("filter_btn_" + id).value = "Added to List!";
    document.getElementById("filter_btn_" + id).style.backgroundColor = 'dodgerblue';
    document.getElementById("filter_btn_" + id).style.color = 'white';
}

function changeCompletedButton(id) {
    debugger
    document.getElementById("filter_btn2_" + id).value = "Completed!";
    document.getElementById("filter_btn2_" + id).style.backgroundColor = 'red';
    document.getElementById("filter_btn2_" + id).style.color = 'white';
}

function changeRemoveButton(id) {
    document.getElementById("filter_btn_" + id).value = "Sighting Removed!";
    document.getElementById("filter_btn_" + id).style.backgroundColor = 'red';
    document.getElementById("filter_btn_" + id).style.color = 'white';
}

function changeRemoveCompletedButton(id) {
    document.getElementById("filter_btn_" + id).value = "Activity Removed from Completed!";
    document.getElementById("filter_btn_" + id).style.backgroundColor = 'red';
    document.getElementById("filter_btn_" + id).style.color = 'white';
}

//Results Collapse Function
var coll = document.getElementsByClassName("collapsible");
var i;

