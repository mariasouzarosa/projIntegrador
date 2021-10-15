$(document).ready(function() {
    listarMunicipio();
});

 
function listarMunicipio(){
    $.get('https://localhost:5001/Municipio/Listar')
        .done(function(resposta) { 
            for(i = 0; i < resposta.length; i++) {
                $('#municipio').append($('<option></option>').val(resposta[i].codMuni).html(resposta[i].nome));
            }
        })
        .fail(function(erro, mensagem, excecao) { 
            alert(mensagem + ': ' + excecao);
        });
}

