

let divSomee = document.querySelector('[style*="opacity: 0.9; z-index: 2147483647; position: fixed; left: 0px; bottom: 0px; height: 65px; right: 0px; display: block; width: 100%; background-color: #202020; margin: 0px; padding: 0px;"]');
let divSomee2 = document.querySelector('[style*="opacity: 0.9; z-index: 2147483647; position: fixed; left: 0px; bottom: 0px; height: 65px; right: 0px; display: block; width: 100%; background-color: #202020; margin: 0px; padding: 0px;"]');
let divSomee3 = document.querySelector('[style*="height: 65px;"]');

if (divSomee != null){
    divSomee.style.display = "none";
}
if (divSomee2 != null){
    divSomee2.style.display = "none";
}
if (divSomee3 != null){
    divSomee3.style.display = "none";
}


function startTest() {
    let example = document.querySelector("#example");
    let test = document.querySelector("#test");

    example.classList.add("d-none");
    test.classList.remove("d-none");

    window.scroll(0, 0);
}
