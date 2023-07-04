var text = document.getElementById("change");
function changeStyle(){
    text.style.textDecoration = "underline";
    text.style.fontWeight = "bold";
}

var clickA = document.getElementById("clickA");
var hoverA = document.getElementById("hoverA");
clickA.addEventListener("click", changeStyle);
hoverA.addEventListener("mouseover", changeStyle);