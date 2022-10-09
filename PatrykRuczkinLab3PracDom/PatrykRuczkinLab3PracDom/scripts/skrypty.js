
//Pobranie aktualnej godziny i wyświetlenie jej
function Run() {
    const date = new Date();
    console.log(date);
    const day = date.getDate();
    const month = date.getMonth() + 1;
    const year = date.getFullYear();

    const hour = date.getHours();
    const minute = date.getMinutes();
    const second = date.getSeconds();

    document.getElementById("days").innerText = day;
    document.getElementById("months").innerText = month;
    document.getElementById("years").innerText = year;

    document.getElementById("hours").innerText = hour;
    document.getElementById("minutes").innerText = minute;
    document.getElementById("seconds").innerText = second;

}

//Inicjalizacja 
function Init() {
    window.setInterval(Run, 1);
}