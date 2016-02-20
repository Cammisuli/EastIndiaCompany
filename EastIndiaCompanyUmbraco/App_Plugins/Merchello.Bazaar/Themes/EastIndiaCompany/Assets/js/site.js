﻿function setTranslate(ele, value) {
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
    
    var navmenu = $('section.nav .bottom');
    var navimg = $('section.nav .middle .logo img');
    $(window).bind('scroll', function () {
        if ($(window).scrollTop() > ($('.nav').height() - navmenu.height())) {
            navmenu.addClass('fixed');
            navimg.addClass('fixed');
        } else {
            navmenu.removeClass('fixed');
            navimg.removeClass('fixed');

        }
    });

    // site reveal
    window.sr = ScrollReveal();
    sr.reveal('.home-link');
});
