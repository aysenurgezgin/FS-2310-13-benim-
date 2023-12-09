let slideIndex = 0;

function showSlides() {
    const slides = document.querySelectorAll('.slide');
    if (slideIndex >= slides.length) {
        slideIndex = 0;
    } else if (slideIndex < 0) {
        slideIndex = slides.length - 1;
    }

    const transformValue = -slideIndex * 100 + '%';
    document.querySelector('.slider-content').style.transform = `translateX(${transformValue})`;
}

function plusSlides(n) {
    slideIndex += n;
    showSlides();
}

// Otomatik kaydırma için
setInterval(() => {
    plusSlides(1);
}, 3000); // Her 3 saniyede bir resmi değiştir