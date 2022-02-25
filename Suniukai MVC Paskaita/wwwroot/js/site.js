// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function pridetiPrekeKrepseliui() {
    alert("Pridedu preke")
    let kiekis = localStorage.getItem("krepselis");
    if (kiekis == null) kiekis = "0";
    localStorage.setItem("krepselis", Number.parseInt(kiekis) + 1);
    kiekPrekiuKrepselyje();
}
function kiekPrekiuKrepselyje() {
    document.getElementById("kiekis").innerHTML = localStorage.getItem("krepselis");
}
kiekPrekiuKrepselyje();