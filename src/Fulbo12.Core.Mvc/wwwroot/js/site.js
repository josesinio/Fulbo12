// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const apiBandera = "https://countryflagsapi.com/svg/";
function UrlBandera(abreviatura) {
    return apiBandera.concat(abreviatura)
}

function mostrar() {
    var obejeto = document.getElementById('bandera')
    if (obejeto.style.display == "block")
        obejeto.style.display = "none";
    else
        obejeto.style.display = "block";
}