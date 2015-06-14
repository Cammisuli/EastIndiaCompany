function setTranslate(ele, value) {
    ele.css("-webkit-transform", "translate3d(" + value + "px,0,0)");
    ele.css("-moz-transform", "translate3d(" + value + "px,0,0)");
    ele.css("-ms-transform", "translate3d(" + value + "px,0,0)");
    ele.css("transform", "translate3d(" + value + "px,0,0)");
}

$(function () {
    //$("li.has-dropdown").mouseover(function () {
    //    var self = $(this);

    //    self.children("ul.dropdown").slideToggle();
    //});


    // mobile navigation
    var nav = $(".nav-items");
    //var navwidth = nav.width();
    //setTranslate(nav, -navwidth - 32);
    setTimeout(function() {
        nav.css("visibility", "visible");
    }, 300);
    var open = false;
    $(".lines-button").click(function () {
        $(this).toggleClass("ani");
        if (open) {
            setTranslate(nav, -1935);
            open = false;
        } else {
            setTranslate(nav, 0);
            open = true;
        }
    });
    
});
