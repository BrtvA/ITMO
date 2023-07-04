let rowArray = [1, 2, 3, 4, 5, 6, 7, 8];
let columnArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
let time = ["09:30", "16:30", "21:10"];
let bsPrice = 300;

let rowSelect = document.querySelector('select[name=row]');
rowArray.forEach((item) => {
    rowSelect.innerHTML += `<option value="${item}">${item}</option>`;
});

let columnSelect = document.querySelector('select[name=column]');
columnArray.forEach((item) => {
    columnSelect.innerHTML += `<option value="${item}">${item}</option>`;
});

let timeSelect = document.querySelector('select[name=time]');
time.forEach((item) => {
    timeSelect.innerHTML += `<option value="${item}">${item}</option>`;
});

class Price{
    constructor(basePrice, timeSelect, popcornCheckBox, sodaCheckBox){
        this.basePrice = basePrice;
        this.timeSelect = timeSelect;
        this.popcornCheckBox = popcornCheckBox;
        this.sodaCheckBox = sodaCheckBox;
    }

    getTotalPrice(){
        let price = this.basePrice;

        if (timeSelect.value < "10:00"){
            price *= 0.9;
        } else if (timeSelect.value > "21:00"){
            price *= 1.1;
        }

        if (popcornCheckBox.checked){
            price += 120;
        }

        if (sodaCheckBox.checked){
            price += 100;
        }

        return price;
    }
}

function changePrice(){
    let tPrice = new Price(bsPrice, timeSelect,
                               popcornCheckBox, sodaCheckBox);
    let priceDiv = document.getElementById("price-div");
    priceDiv.innerHTML = `<p>${tPrice.getTotalPrice()} руб</p>`;
}

let popcornCheckBox = document.querySelector('input[name=popcorn]');
let sodaCheckBox = document.querySelector('input[name=soda]');

timeSelect.addEventListener("change", changePrice);
popcornCheckBox.addEventListener("change", changePrice);
sodaCheckBox.addEventListener("change", changePrice);

function putInLocalStorage(){
    let halls = document.querySelectorAll('input[name=hall]');
    let idx = 0;
    halls.forEach(function(item, index){
        if (item.checked){
            idx = index;
        }
    });
    sessionStorage.setItem("movie", "Человек-паук: Паутина вселенных");
    sessionStorage.setItem("hall", halls[idx].value);
    sessionStorage.setItem("row", rowSelect.value);
    sessionStorage.setItem("column", columnSelect.value);
    sessionStorage.setItem("time", timeSelect.value);
    sessionStorage.setItem("popcorn", popcornCheckBox.checked);
    sessionStorage.setItem("soda", sodaCheckBox.checked);
}

let buyButton = document.getElementsByClassName("red-button")[0];
buyButton.addEventListener("click", putInLocalStorage);

changePrice();