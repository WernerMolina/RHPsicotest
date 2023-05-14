﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function closeModal(event) {
    let modal = document.querySelector("#modal");

    modal.classList.add("d-none");
}

function startTest() {
    let example = document.querySelector("#example");
    let test = document.querySelector("#test");

    example.classList.add("d-none");
    test.classList.remove("d-none");

    window.scroll(0, 0);
}