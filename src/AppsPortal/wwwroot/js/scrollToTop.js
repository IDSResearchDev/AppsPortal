(function () {


    $(document).ready(function () {

        //Check to see if the window is top if not then display button
        //document.getElementsByClassName('.circle').style.display = 'block';
        //document.getElementsByClassName('.circle').style.display = 'none';
        

        $(window).scroll(function () {
            if ($(this).scrollTop() > 300) {
                $('.circle').fadeIn();
            } else {
                $('.circle').fadeOut();
            }
        });

        //Click event to scroll to top
        $('.circle').click(function () {
            $('html, body').animate({ scrollTop: 0 }, 800);
            return false;
        });

    });
})();