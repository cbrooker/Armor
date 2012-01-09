$(function () {

    //Show and hide the sections as a user progresses through the survey.
    $("#Section1Button").bind("click", function (e) {
        //Slide Section1 out
        var $marginLefty = $("#Section1");
        $marginLefty.animate({
            marginLeft: parseInt($marginLefty.css('marginLeft'), 10) == 0 ? -$marginLefty.outerWidth() : 0
        });
        $marginLefty.hide();

        //Slide Section2 in
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

});