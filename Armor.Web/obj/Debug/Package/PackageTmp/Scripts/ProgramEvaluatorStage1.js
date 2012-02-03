$(function () {

    //Show and hide the sections as a user progresses through the survey.
    $("#Section1Button").bind("click", function (e) {

        var $marginLefty = $("#Section1");
        $marginLefty.animate({
            marginLeft: parseInt($marginLefty.css('marginLeft'), 10) == 0 ? -$marginLefty.outerWidth() : 0
        });
        $marginLefty.hide();

        var $marginLefty2 = $("#Section2");
        $marginLefty2.show();
        $marginLefty2.animate({
            marginLeft: parseInt($marginLefty2.css('marginLeft'), 10) == 0 ? $marginLefty2.outerWidth() : 0
        });
    });


    $("#Section2Button").bind("click", function (e) {
        //Slide Section2 out
        var $marginLefty = $("#Section2");
        $marginLefty.animate({
            marginLeft: parseInt($marginLefty.css('marginLeft'), 10) == 0 ? -$marginLefty.outerWidth() : 0
        });
        $marginLefty.hide();

        //Slide Section3 in
        var $marginLefty2 = $("#Section3");
        $marginLefty2.show();
        $marginLefty2.animate({
            marginLeft: parseInt($marginLefty2.css('marginLeft'), 10) == 0 ? $marginLefty2.outerWidth() : 0
        });

    });

    $("#Section3Button").bind("click", function (e) {
        //Slide Section3 out
        var $marginLefty = $("#Section3");
        $marginLefty.animate({
            marginLeft: parseInt($marginLefty.css('marginLeft'), 10) == 0 ? -$marginLefty.outerWidth() : 0
        });
        $marginLefty.hide();

        //Slide Section4 in
        var $marginLefty2 = $("#Section4");
        $marginLefty2.show();
        $marginLefty2.animate({
            marginLeft: parseInt($marginLefty2.css('marginLeft'), 10) == 0 ? $marginLefty2.outerWidth() : 0
        });

    });

    $("#Section4Button").bind("click", function (e) {
        //Slide Section4 out
        var $marginLefty = $("#Section4");
        $marginLefty.animate({
            marginLeft: parseInt($marginLefty.css('marginLeft'), 10) == 0 ? -$marginLefty.outerWidth() : 0
        });
        $marginLefty.hide();

        //Slide Section5 in
        var $marginLefty2 = $("#Section5");
        $marginLefty2.show();
        $marginLefty2.animate({
            marginLeft: parseInt($marginLefty2.css('marginLeft'), 10) == 0 ? $marginLefty2.outerWidth() : 0
        });

    });

});