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
