/* using pure js
(function () {
    //var ele = document.getElementById("username");
    // UTF-8 JavaScript
    //ele.innerHTML = "Sebastian Gulczy�ski";

    var main = document.getElementById("main");
    main.onmouseenter = function () {
        // API Chrome wymaga u�ycia notacji tablicowej
        main.style["background-color"] = "#888";
    };
    main.onmouseleave = function () {
        main.style["background-color"] = "";
    };
})();
*/

/* using jQquery */
// w tak prostym przyk�adzie jq za�atwia nam obs�ug� utf-8 w js i zmian� styl�w css
/*
(function () {
    var ele = $("#username");
    ele.text = "Sebastian Gulczy�ski";

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

    // pocz�tkowa etykieta
    $("#sidebarToggle").text("Hide Sidebar");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $(this).text("Show Sidebar");
        } else {
            $(this).text("Hide Sidebar");
        }
    });
})();
