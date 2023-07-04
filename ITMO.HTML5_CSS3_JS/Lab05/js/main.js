function changePrice(){
    document.getElementById("price-div").innerHTML = '<a href="#">300 руб</a>';
    console.log("click");
    priceBtn.removeEventListener("click", changePrice);
}

var priceBtn=document.getElementById("buy-btn");
priceBtn.addEventListener("click", changePrice);