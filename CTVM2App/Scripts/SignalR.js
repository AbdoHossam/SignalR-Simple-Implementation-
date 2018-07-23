(function () {
    $.connection.hub.start()
        .done(function () {
            console.log("It Worked!");
            $.connection.myHub.server.announce("Connected!");
        })
        .fail(function () { alert("ERROR!!!"); });
             $.connection.myHub.client.announce = function (message) {
        $("#weclome-messages").append(message + "<br />");
        }
})() 