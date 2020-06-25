// prompt('Prompts a message to the user.');
// alert('Displays a message box');


// With JQuery
$(document).ready(function() {
    $("#name").blur(function() {
        $("#output").html($(this).val());
    });

    $("#clear").click(function() {
        $("#output").html('');
        $("#name").val('');
    })
});

//// Without JQuery
// (function() {
//     var output = document.getElementById('output');

//     var name = document.getElementById('name');
//     name.onblur = function() {
//         output.innerHTML = name.value;
//     };

//     var clear = document.getElementById('clear');
//     clear.onclick = function() {
//         name.value = '';
//         output.innerHTML = '';
//     }
// })();