(function () {
    var chat = $.connection.Chat;
    $.connection.hub.start()
        .done(function () {
            writeToPage("It Worked!");
            chat.server.announceToEverybody("Connected!");

        })
        .fail(function () { writeToPage("Error Connecting to SignalR "); });
    chat.client.announce = function (message) {
        writeToPage(message);
    }
    var writeToPage = function (message) {
        $("#weclome-messages").append(message + "<br />");
    }
    $("#click-me").on("click", function () {
        chat.server.getServerDateTime()
            .done(function (data) {
                writeToPage(data)
            })
            .fail(function (e) {
                writeToPage(e);
            });
    })
})() 