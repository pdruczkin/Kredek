//dane zawierające czas
let seconds = 0;
let minutes = 2;
let hours = 0;

//Czy minutnik jest włączony
let isOn = false;

//Zmienna zawierająca interwał
let interval = null;


//funkcja pobierająca dane od użytkownika
function GetData() {
    seconds = document.getElementById('seconds').value;
    minutes = document.getElementById('minutes').value;
    hours = document.getElementById('hours').value;

    if (seconds > 60) {
        seconds = 0;
    }
    if (minutes > 60) {
        minutes = 0;
    }
    if (hours > 24) {
        hours = 0;
    }

}


//Odliczanie czasu
function Run() {
    seconds--;

    if (seconds < 0) {
        minutes--;
        seconds = seconds + 60;
        if (minutes < 0) {
            hours--;
            minutes = minutes + 60;
            if (hours < 0) {
                seconds = 0;
                minutes = 0;
                hours = 0;
                ChangeTimerStatus();
                Shake(5);
            }
        }
    }

    PrintTime();
}


//Wyświetlanie
function PrintTime() {

    document.getElementById('seconds').value = seconds;
    document.getElementById('minutes').value = minutes;
    document.getElementById('hours').value = hours;
}


//Zmiana statusu minutnika
function ChangeTimerStatus() {
    if (isOn) {
        isOn = false;
        window.clearInterval(interval);
        ChangeButton();

    }
    else {
        isOn = true;
        GetData();
        interval = window.setInterval(Run, 1000);
        ChangeButton();

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


//Dodanie odpowiedniego listenera dla alarmu
function AddEventListener() {
    document.getElementById("alarm").addEventListener("click", Hide);
}

//Drganie alarmu
function Shake(sec)
{
    document.getElementById("alarm").style.display = "inline";
    window.setTimeout(Hide, 1000 * sec);
}

//Ukrycie alarmu
function Hide()
{
    document.getElementById("alarm").style.display = "none";
}


//Reset stanu aplikacji
function Reset() {
    window.clearInterval(interval);
    seconds = 0;
    minutes = 0;
    hours = 0;

    isOn = false;
    window.clearInterval(interval);
    ChangeButton();

    PrintTime();
}