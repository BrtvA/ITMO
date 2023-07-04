$(document).ready(function(){
    $(".icon-menu").on("click", function(event){
        let submenu = $(".submenu");
        if (submenu.css("display") == "none"){
            submenu.fadeIn(300);
        }else{
            submenu.fadeOut(300);
        }
    })

    $(document).on("contextmenu", function(){
        return false;
    })

    $(document).on("mousedown", function(event){
        if(event.which == 3){
            $("#context-menu").css({
                top: event.pageY,
                left: event.pageX,
            })
            $("#context-menu").addClass("active")
            return false;
        }
        
        if (!$(event.target).is("a")){
            $("#context-menu").removeClass("active")
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