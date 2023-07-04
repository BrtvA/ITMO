$(document).ready(function(){
    let flag = false;
    $(".icon-menu").on("click", function(){
        let submenu = $("#submenu");
        if (flag){
            submenu.fadeOut(100);
        }else{
            submenu.fadeIn(100);
        }
        flag = !flag;
    })

    $(document).on("contextmenu", function(){
        return false;
    })

    $(document).on("mousedown", function(event){
        let contextMenu = $("#context-menu");
        if(event.which == 3){
            contextMenu.css({
                top: event.pageY,
                left: event.pageX,
            })
            contextMenu.fadeIn(100);
            return false;
        }
        
        if (!$(event.target).is("a")){
            contextMenu.fadeOut(100);
        }
    })

    $("#history-back, #history-go, #location-reload").on("click", function(event){
        var elId = $(event.currentTarget).attr("id");
        if(elId == "history-back"){
            window.history.back();
        } else if(elId == "history-go"){
            window.history.go(1);
        } else if(elId == "location-reload"){
            location.reload();
        }
    })
})