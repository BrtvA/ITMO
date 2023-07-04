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
    console.log(isPopcorn);
    console.log(isSoda);
    if(isPopcorn == "true"){
        console.log("popcorn");
        additionalHTML += "<li><p>Попкорн (средний)</p></li>";
    }
    if (isSoda == "true"){
        console.log("soda");
        additionalHTML += "<li><p>Газировка (0.5 л)</p></li>";
    }
    console.log(additionalHTML);
    $("#additional").html(additionalHTML)

    $("#buy-btn").on("click", function(){
        localStorage.clear();
    })
})