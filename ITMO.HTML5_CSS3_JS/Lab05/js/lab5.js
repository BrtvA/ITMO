var string1 = "aaa";
var string2 = "bbb";
var pi = 3.14;
var fStr = "FF";

alert(string1 + string2);
alert(pi * fStr);

var tableBody=document.getElementById("table-number-body");
var tableContent = "";
for (var i = 1; i <= 10; i++){
    tableContent += '<tr>';
    for (var j = 1; j <= 10; j++){
        tableContent +='<td>' + (i*j) + '</td>';
    }
    tableContent += '</tr>';
}
tableBody.innerHTML = tableContent;

var movieArray = ["Довод", "Интерстеллар"];
console.log(movieArray);
movieArray.pop();
console.log(movieArray);
movieArray.push("Интерстеллар");
console.log(movieArray);
movieArray.shift("Довод");
console.log(movieArray);
movieArray.unshift("Довод");
console.log(movieArray);