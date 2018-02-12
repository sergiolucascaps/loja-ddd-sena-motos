
var usuario = null;
var objUsuarios = new Usuarios();

$(function () {

    usuario = function () {

        var $_usuario = {
            postAction: {
                create: null
            },
            field: {
                name: null,
                cpf: null,
                email: null,
                dataNascimento: null,
                senha: null,
                senhaConfirmacao: null,
                imagem: null,
                imagemInput: null,
                imagemUpload: null,
                senhaHash: null,
            },
            element: {
                saveButton: null,
                returnButton: null
            }
        };

        function _initializeScreen() {
            objUsuarios.ChangeUpload();
            objUsuarios.FileselectUpload();
        }

        function _readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $($_usuario.field.imagemUpload).attr('src', e.target.result);
                    ($_usuario.field.imagem).val(e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }

        // public section
        return {
            init: function (options) {

                $_usuario.postAction.create = options.postAction.create;

                $_usuario.field.name = $(options.field.name);
                $_usuario.field.cpf = $(options.field.cpf);
                $_usuario.field.email = $(options.field.email);
                $_usuario.field.dataNascimento = $(options.field.dataNascimento);
                $_usuario.field.senha = $(options.field.senha);
                $_usuario.field.senhaConfirmacao = $(options.field.senhaConfirmacao);
                $_usuario.field.imagem = $(options.field.imagem);
                $_usuario.field.imagemInput = $(options.field.imagemInput);
                $_usuario.field.imagemUpload = $(options.field.imagemUpload);
                $($_usuario.field.imagemInput).change(function () { _readURL(this); });
                $_usuario.field.senhaHash = $(options.field.senhaHash);
                
                $_usuario.element.saveButton = $(options.element.saveButton);
                $_usuario.element.returnButton = $(options.element.returnButton);
            },

            initializeScreen: function () {
                _initializeScreen();
            }
        };
    }();
});