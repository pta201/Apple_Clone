const swiper = new Swiper('.swiper', {
  pagination: {
    el: '.swiper-pagination',
  },

  // Responsive
  breakpoints: {
      320: {
        slidesPerView: 2,
        spaceBetween: 10
      },
      600: {
        slidesPerView: 2,
        spaceBetween: 30
      },
      992: {
        slidesPerView: 5,
        spaceBetween: 30
      }
  },
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  }
})