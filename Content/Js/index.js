$(document).ready(function () {
    $('#search-icon').on('click', ()=>{
        $('#nav-list li').each((index, item)=>{
            setTimeout(()=>{
                item.classList.add('scale-animation')
            }, index*30)
            
        })
        $('.nav-container')[0].classList.remove('bg-dark')
        $('.search-section')[0].classList.add('show')
        $('.search-section')[0].classList.add('fadein-left')
    })

    $(document).click(function (e) {
        const container = $('.nav-container');
    
        if (!container.is(e.target) && container.has(e.target).length === 0)
        {
            $($('#nav-list li').get().reverse()).each((index, item)=>{
                setTimeout(()=>{
                    item.classList.remove('scale-animation')
                }, index*30)
                
            })
            $('.nav-container')[0].classList.add('bg-dark')
            $('.search-section')[0].classList.remove('show')
            $('.search-section')[0].classList.remove('fadein-left ')
        }
    })
    
})