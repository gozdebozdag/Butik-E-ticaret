// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let navbar = document.querySelector('.navbar');

document.querySelector('#menu-btn').onclick = () => {
    navbar.classList.toggle('active');
}

let searchForms = document.querySelector('.search-form');

document.querySelector('#search-btn').onclick = () => {
    searchForms.classList.toggle('active');
}


