// Script By: Sergio Lucas


// *************** Criação da Funcionalidade de Mensagens (com toastr) no sistema todo. *****************

// Classe Mensagem
function Mensagem() { }

Mensagem.prototype.MostrarMensagem = function (des_mensagem = '', des_titulo = '', tipo_mensagem = 'info', flg_obriga_resposta = false) {
    toastr.options = {
        closeButton: true,
        debug: false,
        newestOnTop: true,
        progressBar: true,
        rtl: false,
        positionClass: 'toast-top-right',
        preventDuplicates: false,
        onclick: null,
        showDuration: 300,
        hideDuration: 1000,
        timeOut: flg_obriga_resposta ? 0 : 5000,
        extendedTimeOut: flg_obriga_resposta ? 0 : 1000,
        showEasing: 'swing',
        hideEasing: 'linear',
        showMethod: 'fadeIn',
        hideMethod: 'fadeOut',
        tapToDismiss: flg_obriga_resposta ? true : false
    };
    des_mensagem += flg_obriga_resposta ? '<br /><br /><button type="button" class="btn btn-outline-danger" style="color:black">OK</button>' : '';

    switch (tipo_mensagem) {
        case 'error':
            des_titulo != undefined && des_titulo != '' ? toastr.error(des_mensagem, des_titulo) : toastr.error(des_mensagem);
            break;
        case 'success':
            des_titulo != undefined && des_titulo != '' ? toastr.success(des_mensagem, des_titulo) : toastr.success(des_mensagem);
            break;
        case 'info':
            des_titulo != undefined && des_titulo != '' ? toastr.info(des_mensagem, des_titulo) : toastr.info(des_mensagem);
            break;
        case 'warning':
            des_titulo != undefined && des_titulo != '' ? toastr.warning(des_mensagem, des_titulo) : toastr.info(des_mensagem);
            break;
        default:
            des_titulo != undefined && des_titulo != '' ? toastr.info(des_mensagem, des_titulo) : toastr.info(des_mensagem);
    }
}

// *************** Criação da Funcionalidade Wait no sistema todo *****************

function limpaModal() {
    $("#conteudoModal, #tituloModal, #hddFooter").html("");
}

function WaitOn() {
    $("#conteudo").append('<div class="progress_img_container" id="progress_img_container"><div class="img_container" id="img_container"><img id="imgProgress" src="/images/Wait.gif" /><label id="lblCarregandoProgress" class="carregando">Processando<\/label><\/div><\/div>');
}
function WaitOff() { $("#progress_img_container").remove(); }

// *************** Criação da Funcionalidade de remoção de filhos hidden para qualquer elemento informado *****************

function removerFilhosHiddenDeUmElemento(elemento) {
    $(elemento).children().each(function () {
        if (this.attributes.getNamedItem('hidden') != null)
            this.attributes.removeNamedItem('hidden');
    });
}

// *************** Criação da Funcionalidade de buscas ajax no Sistema *****************

function buscaDados(item) {
    var url = item.formAction + '/' + item.id;
    var mHeader = $('#tituloModal');
    var mBody = $('#conteudoModal');
    var mFooter = $('#footerModal');
    $.ajax({
        url: url,
        type: this.method,
        data: $(this).serialize(),
        success: function (result) {
            // Preenchimento do Body da Modal
            mBody.html(result);

            // Preenchimento do Header da Modal
            if ($('#hddTitulo')[0] != undefined) {
                var titulo =
                    $('#hddTitulo').length > 0 ? (
                        $('#hddTitulo')[0].textContent != undefined && $('#hddTitulo')[0].textContent.length > 0 ? $('#hddTitulo')[0].textContent :
                            ($('#hddTitulo').val() != undefined && $('#hddTitulo').val().trim() != '' ? $('#hddTitulo').val() : '')
                    ) : '';

                mHeader.html(titulo);
            }

            // Preenchimento do Footer da modal
            var conteudo = '';
            if ($('#hddFooter')[0] != undefined) { conteudo = $('#hddFooter')[0].outerHTML; }
            var btnVoltar = '<div class="col-md-2" style="float: right;"> <button type="button" class="btn btn-default btn-md" onclick="limpaModal();" data-dismiss="modal">Fechar</button> </div>';
            mFooter.html(btnVoltar + conteudo);

            // Remove os filhos que estiverem com atributo Hidden
            removerFilhosHiddenDeUmElemento(mFooter);

            // Mostrar Modal
            $('#myModal').modal('show');
        },
        error: function (result) {
            $('#myModal').modal('hide');
            objMensagem = objMensagem != undefined ? objMensagem : new Mensagem();
            objMensagem.MostrarMensagem('Problema ao buscar dados. Tente novamente!', 'Oops !', 'error', true);
        }
    });
    return false;
}
