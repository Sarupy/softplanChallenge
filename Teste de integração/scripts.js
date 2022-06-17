$( document ).ready(function() {
    //Carregar campo de juros
    $.get( "https://localhost:8001/taxajuros", function( data ) {
        $( "#juros" ).val( data );                      
    });
});

$('#btn-submit').click(function( ) {
    var valorinicial= $( "#valorinicial" ).val()
    var meses = $( "#meses" ).val()
    var url = `https://localhost:8002/calculaJuros?valorinicial=${valorinicial}&meses=${meses}`
    $.get( url, function( data ) {
        alert('Resultado: ' + data );                      
    });
});