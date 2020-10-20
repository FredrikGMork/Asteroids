"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/gameHub").build();

//var connectionID = Math.floor(Math.random() * 1000);
//Disable send button until connection is established
document.getElementById("joinLobby").disabled = true;
document.getElementById("getOnlineIds").disabled = true;

connection.on("LobbyUpdate", function () {
    //var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = " er logget på.";
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("lobbyList").appendChild(li);
});

connection.on("ReceiveOnlineId", function (onlineUsers) {
    var listToString = "Ingen verdi";
    if (onlineUsers[0] != null && onlineUsers[1] != null) {
        listToString = onlineUsers[0] + "\n " + onlineUsers[1];
    }
    console.log(listToString);

});
connection.logging = true;
connection.start().then(function () {
    document.getElementById("joinLobby").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("joinLobby").addEventListener("click", function (event) {
    // var user = document.getElementById("userInput").value;
    document.getElementById("getOnlineIds").disabled = false;
    connection.invoke("JoinLobby", connectionID).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

document.getElementById("getOnlineIds").addEventListener("click", function (event) {
    connection.invoke("GetOnlineIds").catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});