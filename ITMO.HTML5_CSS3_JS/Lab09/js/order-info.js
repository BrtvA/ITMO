$(document).ready(function(){
    let movieName = sessionStorage["movie"];
    let hall = sessionStorage["hall"];
    let row = sessionStorage["row"];
    let column = sessionStorage["column"];
    let time = sessionStorage["time"];
    let isPopcorn = sessionStorage["popcorn"];
    let isSoda = sessionStorage["soda"];

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
        sessionStorage.clear();
        location.reload();
    })
})