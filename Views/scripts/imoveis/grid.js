$(document).ready(function() {
    listarGrid();
    $('#crescente').click(OrdenarCrescente);
    $('#decrescente').click(OrdenarDecrescente);
});
 
function listarGrid(){
    $.get('https://localhost:5001/Proprietario/Listar')
        .done(function(resposta) { 
            for(i = 0; i < resposta.length; i++) {
                let dados = resposta[i];
                
                $('#grid').append($('<tr></tr>').attr('id', dados.cpfProp));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.cpfProp));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.nome));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.telefone));
            }
        })
        .fail(function(erro, mensagem, excecao) { 
            alert(mensagem + ': ' + excecao);
        });
}

function OrdenarCrescente(){
    $.get('https://localhost:5001/Proprietario/OrdenarCrescente')
        .done(function(resposta) { 
            $('#grid tr').remove();
            for(i = 0; i < resposta.length; i++) {
                let dados = resposta[i];
                
                $('#grid').append($('<tr></tr>').attr('id', dados.cpfProp));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.cpfProp));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.nome));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.telefone));
            }
        })
        .fail(function(erro, mensagem, excecao) { 
            alert(mensagem + ': ' + excecao);
        });
}

function OrdenarDecrescente(){
    $.get('https://localhost:5001/Proprietario/OrdenarDecrescente')
        .done(function(resposta) { 
            $('#grid tr').remove();
            for(i = 0; i < resposta.length; i++) {
                let dados = resposta[i];
                
                
                $('#grid').append($('<tr></tr>').attr('id', dados.cpfProp));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.cpfProp));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.nome));
                $('#' + dados.cpfProp).append($('<td></td>').html(dados.telefone));
            }
        })
        .fail(function(erro, mensagem, excecao) { 
            alert(mensagem + ': ' + excecao);
        });

}