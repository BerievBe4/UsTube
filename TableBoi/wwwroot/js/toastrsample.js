function showToast(errorMessage) {
    if (errorMessage === "") {
        //...
    }
    else {
        toastr.options =
        {
            "debug": false,
            "positionClass": "toast-top-full-width",
            "onclick": null,
            "fadeIn": 300,
            "fadeOut": 100,
            "timeOut": 3000,
            "extendedTimeOut": 1000
        }
        var d = Date();
        toastr["error"](errorMessage);
    }
}

function decode_utf8(s) {
    return decodeURIComponent(escape(s));
}