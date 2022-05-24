const menu = document.querySelector("#menu");
const burger = document.querySelector("#menu-burg"); //itens do menu
console.log(burger);

burger.addEventListener("click", () => {
    menu.classList.toggle("open");
})