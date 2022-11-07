// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const apiBandera = "https://countryflagsapi.com/svg/";
function UrlBandera(idTextAbreviatura) {
    var  textAbreviatura = document.getElementById(idTextAbreviatura);
    return apiBandera.concat(textAbreviatura.value)
}

function mostrar(img, abreviatura) {
    img = document.getElementById(img);
    img.src = UrlBandera(abreviatura);

    if (img.style.display == "block")
        img.style.display = "none";
    else
        img.style.display = "block";
}