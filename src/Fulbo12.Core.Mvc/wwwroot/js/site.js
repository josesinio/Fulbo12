// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function UrlBanderaCountryFlagsApi(abreviatura) {
    const apiCountryFlagsApi = "https://countryflagsapi.com/svg/";
    return apiCountryFlagsApi.concat(abreviatura);
}

function UrlBanderaFlagCdn(abreviatura) {
    const apiFlagCdn = "https://flagcdn.com/";
    return apiFlagCdn.concat(abreviatura, ".svg");
}
// SUERTE
function mostrar(idImg, idTextAbreviatura) {
    const img = document.getElementById(idImg);
    const abreviatura = document.getElementById(idTextAbreviatura).value;
    console.log("Abreviatura: " + abreviatura);
    img.src = UrlBanderaFlagCdn(abreviatura);
    console.log("Url: " + UrlBanderaFlagCdn(abreviatura));
    console.log("src = " + img.src)
    // if (img.style.display == "none")
    //     img.style.display = "block";
    console.log("display = " + img.style.display);
}