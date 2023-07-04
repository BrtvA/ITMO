$(document).ready(function(){
    let movieName = localStorage["movie"];
    let hall = localStorage["hall"];
    let row = localStorage["row"];
    let column = localStorage["column"];
    let time = localStorage["time"];
    let isPopcorn = localStorage["popcorn"];
    let isSoda = localStorage["soda"];

    $("#movie-name").html(movieName)
    $("#hall").html(hall.toUpperCase())
    $("#place-row").html(`ряд ${row}`)
    $("#place-column").html(`место ${column}`)
    $("#time").html(time)

    let additionalHTML = "";
    if(isPopcorn == "true"){
        additionalHTML += "<li><p>Попкорн (средний)</p></li>";
    }
    if (isSoda == "true"){
        additionalHTML += "<li><p>Газировка (0.5 л)</p></li>";
    }
    $("#additional").html(additionalHTML)

    $(".red-button").on("click", function(){
        localStorage.clear();
        location.reload();
    })
})