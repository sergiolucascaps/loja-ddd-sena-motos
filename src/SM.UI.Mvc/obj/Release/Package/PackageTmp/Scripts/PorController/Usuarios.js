function Usuarios() { }

// Protótipos
Usuarios.prototype.ChangeUpload = function () { ChangeUpload(); }
Usuarios.prototype.FileselectUpload = function () { FileselectUpload(); }
Usuarios.prototype.RestoreUserImage = function (target, source) { RestoreUserImage(target, source); }


// Funções trabalhadoras - Não modificar

function ChangeUpload() {
    $(document).on('change', '.btn-file :file', function () {
        var input = $(this),
            label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
        input.trigger('fileselect', [label]);
    });
}

function FileselectUpload() {
    $('.btn-file :file').on('fileselect', function (event, label) {

        var input = $(this).parents('.input-group').find(':text'),
            log = label;

        if (input.length) {
            input.val(log);
        } else {
            if (log) alert(log);
        }

    });
}

function RestoreUserImage(target, source) {
    if (source != undefined && source.value.trim() != '')
        target.src = source.value;
}