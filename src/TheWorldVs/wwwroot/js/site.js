/* using pure js
(function () {
    //var ele = document.getElementById("username");
    // UTF-8 JavaScript
    //ele.innerHTML = "Sebastian Gulczyñski";

    var main = document.getElementById("main");
    main.onmouseenter = function () {
        // API Chrome wymaga u¿ycia notacji tablicowej
        main.style["background-color"] = "#888";
    };
    main.onmouseleave = function () {
        main.style["background-color"] = "";
    };
})();
*/

/* using jQquery */
// w tak prostym przyk³adzie jq za³atwia nam obs³ugê utf-8 w js i zmianê stylów css
/*
(function () {
    var ele = $("#username");
    ele.text = "Sebastian Gulczyñski";

    var main = $("#main");
    main.on("mouseenter", function () {
        main.css("background-color", "#888");
    });
    main.on("mouseleave", function () {
        main.css("background-color", "#eee");
    });

    var menuItems = $("ul.menu li a");
    menuItems.on("click", function () {
        var me = $(this);
        alert(me.text());
    });
})();
*/

(function () {
    // zwraca wrapped set
    var $sidebarAndWrapper = $("#sidebar,#wrapper");

    // nie potrzebujemy ju¿ etykiet, u¿ywamy ikon z font-awesome

    // pocz¹tkowa etykieta
    //$("#sidebarToggle").text("Hide Sidebar");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");

        // mo¿na siê bawiæ w wyszukanie elementu i u¿ywanie addClass() i removeClass()
        // jesteœmy wewn¹trz on() i mamy ³atwy dostêp do przycisku
        //var $icon = $("#sidebarToggle i.fa");

        // this to w tym wypadku klikniêty przycisk

        // mo¿emy siê dostaæ do podrzêdnego elementu this za pomoc¹ kontekstu
        //$("i", this)
        // lub u¿ywaj¹c find()
        //$(this).find("i")

        // font-awesome
        // zamiast
        //glyphicon glyphicon-chevron-left (right)
        // u¿ywamy
        //fa fa-angle-left (right)
        
        $("i", this).toggleClass("fa-angle-left");
        $("i", this).toggleClass("fa-angle-right");

        // u¿ywamy ikon z font-awesome
        /*
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $(this).text("Show Sidebar");
        } else {
            $(this).text("Hide Sidebar");
        }
        */
    });
})();
