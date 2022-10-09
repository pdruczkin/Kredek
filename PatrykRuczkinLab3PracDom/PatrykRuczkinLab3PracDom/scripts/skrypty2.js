//dane zawierające czas
let centiseconds = 0;
let seconds = 0;
let minutes = 0;

//dane zawierający czas nadający się do wyświetlenia
let centisecondsDisplay = "";
let secondsDisplay = "";
let minutesDisplay = "";

//Zmienna zawierająca interwał
var interval = null;

//Czy stoper jest włączony
let isOn = false;

// Zmiana koloru dla przycisku
function SetColor(button) {
    let property = document.getElementById(button);
    if (isOn) {
        property.style.backgroundColor = "#0066ff";
    }
    else {
        property.style.backgroundColor = "#7FFF44";
    }
}

//Zmiana przycisku
function ChangeButton() {
    if (isOn) {
        document.getElementById('button_start_stop').innerHTML = "";
        document.getElementById('button_start_stop').innerHTML += '<span class="material-icons" >stop</span>';
        SetColor('button_start_stop');
    } else {
        document.getElementById('button_start_stop').innerHTML = "";
        document.getElementById('button_start_stop').innerHTML += '<span class="material-icons" >play_arrow</span>';
        SetColor('button_start_stop');

    }
}

//Zmiana statusu Stopera (włączony/wyłączony)
function ChangeTimerStatus() {
    if (isOn) {
        isOn = false;
        window.clearInterval(interval);
        ChangeButton();

    }
    else {
        isOn = true;
        interval = window.setInterval(Run, 10);
        ChangeButton();

    }
}

//Reset stopera
function Reset() {
    window.clearInterval(interval);
    centiseconds = 0;
    seconds = 0;
    minutes = 0;

    isOn = false;
    window.clearInterval(interval);
    ChangeButton();

    PrintTime();
}

//Wyświetlanie danych
function PrintTime() {
    if (centiseconds < 10) {
        centisecondsDisplay = "0" + centiseconds;
    } else {
        centisecondsDisplay = centiseconds;
    }

    if (seconds < 10) {
        secondsDisplay = "0" + seconds;
    } else {
        secondsDisplay = seconds;
    }

    if (minutes < 10) {
        minutesDisplay = "0" + minutes;
    } else {
        minutesDisplay = minutes;
    }

    document.getElementById('centiseconds').innerHTML = centisecondsDisplay;
    document.getElementById('seconds').innerHTML = secondsDisplay;
    document.getElementById('minutes').innerHTML = minutesDisplay;

}

//Zliczanie odpowiednich jednostek czasu
function Run() {
    centiseconds++;

    if (centiseconds % 100 === 0) {
        centiseconds = 0;
        seconds++;

        if (seconds % 60 === 0) {
            seconds = 0;
            minutes++;

            if (minutes % 60 === 0) {
                minutes = 0;
            }

        }

    }


    PrintTime();
}
