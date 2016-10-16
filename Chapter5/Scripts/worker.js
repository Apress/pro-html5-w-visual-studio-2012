/* This file implements the web worker */
onconnect = sendResponse("The worker has started");

onmessage = function (event) {
    sendResponse("Msg received: " + event.data);
}

function sendResponse(message) {
    postMessage(message);
}
