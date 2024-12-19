// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//$(document).ready(function () {

//    // Attach click event to the button
//    $("#restart").click(function () {
//        var myModddddal = new bootstrap.Modal(document.getElementById('exampleModalCenter'));
//        // Get the modal by ID and initialize it
//        myModddddal.hide();
//        //$('#exampleModalCenter').hide();

//        generateNewCard();
//    });
//});

$(document).on("click", "#restart", function () {
    $('#exampleModalCenter').modal('hide'); // Use Bootstrap's modal method
    //$('#exampleModalCenter').hide();
    generateNewCard();
    //$('#Searchloader').show();
 

})

$(document).on("click", "#ends", function () {
    $('#exampleModalCenter').modal('hide'); // Use Bootstrap's modal method
 
 

})

 