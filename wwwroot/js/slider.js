
const slider = document.querySelector(".slider");
const slides = document.querySelectorAll(".slider img");
let prevbtn = document.querySelector(".prev");
let nextbtn = document.querySelector(".next");

let currentIndex = 0
function showSlide(index){
    if(index >= slides.length){
        currentIndex = 0;
    }else if(index < 0){
        currentIndex = slides.length - 1;

    }else{
        currentIndex = index;
    }

    slider.style.transform = `TranslateX(-${currentIndex * 100 }%)`;

}

nextbtn.addEventListener("click",() => showSlide(currentIndex + 1))
prevbtn.addEventListener("click",() => showSlide(currentIndex - 1))

setInterval(() => showSlide(currentIndex+1),7000)
