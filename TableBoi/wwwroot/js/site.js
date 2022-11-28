// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#addTask').click(function (e) {
    var addTaskFormData = $('#AddForm').serialize();
    $('#spinner').show();

    $.ajax({
        type: 'POST',
        url: '/Home/AddOrEdit',
        data: addTaskFormData,
        success: function (response) {
            if (response.success === true) {
                window.location.href = '/Home/Index';
            }
        },
        statusCode: {
            400: function () {
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
                toastr["error"]("Проверьте правильность введенных данных!");
            },
            500: function () {
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
                toastr["error"]("Произошла ошибка сервера. Попробуйте попозже!");
            }
        }
    })
});

$('#editTask').click(function (e) {
    var editTaskFormData = $('#EditForm').serialize();
    $('#spinner').show();

    $.ajax({
        type: 'POST',
        url: '/Home/AddOrEdit',
        data: editTaskFormData,
        success: function (response) {
            if (response.success === true) {
                window.location.href = '/Home/Index';
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
                toastr["error"]("Проверьте правильность введенных данных!");
            }
        },
        statusCode: {
            400: function () {
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
                toastr["error"]("Проверьте правильность введенных данных!");
            },
            500: function () {
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
                toastr["error"]("Произошла ошибка сервера. Попробуйте попозже!");
            }
        }
    })
})

function editTask(taskId) {
    $.ajax({
        type: 'GET',
        url: '/Home/AddOrEdit',
        data: { TaskId: taskId },
        dataType: 'JSON',
        success: function (responce) {
            var parsedJson = $.parseJSON(responce);
            $('#Id').attr('value', parsedJson['Id']);
            $('#taskName').attr('value', parsedJson['TaskName']);
            $('#taskDescription').attr('value', parsedJson['TaskDescription']);
        },
    });
}

$('#deleteTask').click(function (e) {
    var taskId = document.getElementById('taskId').value;
    $('#spinner').show();

    $.ajax({
        type: 'DELETE',
        url: '/Home/DeleteTask',
        data: { id: taskId },
        success: function (response) {
            if (response.success === true) {
                window.location.href = '/Home/Index';
            }
        }
    })
});

function confirmDelete(taskId) {
    document.getElementById('taskId').value = taskId;
}
