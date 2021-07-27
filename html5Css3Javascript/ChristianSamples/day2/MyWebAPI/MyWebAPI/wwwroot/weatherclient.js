﻿document.addEventListener("DOMContentLoaded", function () {
     document.getElementById("usexmlhttp").onclick = newcallsample;
 });

function oldcallsample() {
    var request = new XMLHttpRequest();
    request.open("GET", "WeatherForecast");
    request.onreadystatechange = function () {
        if (request.readyState === 4) {
            var response = JSON.parse(request.responseText);
            console.log(response);
        }
    };
    request.send();
}

async function newcallsample() {
    var response = await fetch("WeatherForecast");
    var weather = await response.json();
    console.log(weather);
}