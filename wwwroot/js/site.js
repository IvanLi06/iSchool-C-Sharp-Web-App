// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
    $("#pepTabs").tabs();
    $('#hideMe').fadeIn(1200);
    $(".person").each(function () {
        var modal = $(this).find(".modal");
        var button = $(this).find(".button"); //finds modal and button in file
        modal.dialog({ // dialog settings
            autoOpen: false,
            width: 400,
            height: 450,
            modal: true
        });
        button.on('click', function (e) { //onclick open dialog 
            e.preventDefault();
            modal.dialog("open");
            autoOpen: true; 
            modal: true;    
            width: 'auto';  
        });
    });
});

$(function () {
    $('.underAcc').each(function () { //degree accordians
        $(this).accordion({
            collapsible: true,
            heightStyle: "content",
            active: false
        });
    });
    $('.graduateAcc').each(function () {
        $(this).accordion({
            collapsible: true,
            heightStyle: "content",
            active: false
        });
    });
    $('.certAcc').each(function () {
        $(this).accordion({
            collapsible: true,
            heightStyle: "content",
            active: false
        });
    });
    $('#hideMe').fadeIn(1200);
});

$(function () {
    $('.minorAcc').each(function () {//minor accordian
        $(this).accordion({
            collapsible: true,
            heightStyle: "content",
            active: false
        });
    });
    $('.course-button').on('click', function (e) { //zebra modal plugin to display course information
        e.preventDefault();
        var courseTitle = $(this).text();
        var minorTitle = $(this).closest('.minorAcc').find('h1').text();
        $.Zebra_Dialog('<strong>' + courseTitle + '</strong><br>' + 'Title: ' + minorTitle);
    });
    $('#hideMe').fadeIn(1200);
});

$(function () {
    $('#coopTable, #employmentTable').DataTable();
    $('#hideMe').fadeIn(1200);
});

