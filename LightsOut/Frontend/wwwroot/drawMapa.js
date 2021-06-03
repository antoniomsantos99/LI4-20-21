var map;
function loadMapScenario(lista) {

    var mapOptions = {
        zoom: 5
    };

    mapa = new Microsoft.Maps.Map(document.getElementById('map'), mapOptions);

    lista.forEach(function (item, index) {
        
        var listaAux = []
        
        var local = new Microsoft.Maps.Location(JSON.parse(item).localizacao.latitude, JSON.parse(item).localizacao.longitude);
        
        var n = listaAux.includes(local);
        
        
            //console.log(local);
            listaAux.push(local);

            diaAtual = new Date(Date.now()).toISOString().split('T')[0]
            horaAtual = new Date(Date.now()).toISOString().split('T')[1]
            divideAtual = horaAtual.split(":")
            horasMinutosAtual = divideAtual[0] + ":" + divideAtual[1]

            diaProva = new Date(JSON.parse(item).data).toISOString().split('T')[0]
            horaProva = new Date(JSON.parse(item).data).toISOString().split('T')[1]
            divideProva = horaProva.split(":")
            horasMinutosProva = divideProva[0] + ":" + divideProva[1]

            //console.log(horasMinutosAtual)
            //console.log(horasMinutosProva)

            if (diaProva > diaAtual) {
                var pin = new Microsoft.Maps.Pushpin(local, {color: 'black'});
                var url = "http://localhost:5000/notificacoes/" + JSON.parse(item).id;
                pin.redirectUrl = url;

                Microsoft.Maps.Events.addHandler(pin, 'click', function (e) {
                    window.location = e.target.redirectUrl;
                });

            } else {
                if (diaProva == diaAtual) {

                    hma = horasMinutosProva.split(":")
                    ihma = parseInt(hma[0])
                    ihoraTermina = ihma + 2.0//depois, para ser mais rápido, dimnuir em vez de 2horas, tipo 5 minutos ou assimm
                    horaTerminaProva = ihoraTermina.toString() + ":" + hma[1]
                    //console.log(horasMinutosProva)
                    //console.log(horaTerminaProva)
                    //console.log(horasMinutosAtual)



                    if (horasMinutosAtual == horasMinutosProva) {
                        var pin = new Microsoft.Maps.Pushpin(local, {color: 'red'});
                        var url = "http://localhost:5000/notificacoes/" + JSON.parse(item).id;
                        pin.redirectUrl = url;

                        Microsoft.Maps.Events.addHandler(pin, 'click', function (e) {
                            window.location = e.target.redirectUrl;
                        });
                    } else {
                        if (horaTerminaProva > horasMinutosAtual && horasMinutosAtual > horasMinutosProva){
                            var pin = new Microsoft.Maps.Pushpin(local, {color: 'red'});
                            var url = "http://localhost:5000/notificacoes/" + JSON.parse(item).id;
                            pin.redirectUrl = url;

                            Microsoft.Maps.Events.addHandler(pin, 'click', function (e) {
                            window.location = e.target.redirectUrl;
                        });
                        }
                        else{

                        if (horasMinutosProva < horasMinutosAtual) {
                            var pin = new Microsoft.Maps.Pushpin(local, {color: 'green'});
                            var url = "http://localhost:5000/resultados/" + JSON.parse(item).id;
                            pin.redirectUrl = url;

                            Microsoft.Maps.Events.addHandler(pin, 'click', function (e) {
                                window.location = e.target.redirectUrl;
                            });
                        } else {
                            var pin = new Microsoft.Maps.Pushpin(local, {color: 'black'});
                            var url = "http://localhost:5000/notificacoes/" + JSON.parse(item).id;
                            pin.redirectUrl = url;

                            Microsoft.Maps.Events.addHandler(pin, 'click', function (e) {
                                window.location = e.target.redirectUrl;
                            });
                        }
                    }
                }
                } else {
                    var pin = new Microsoft.Maps.Pushpin(local, {color: 'green'});
                    var url = "http://localhost:5000/resultados/" + JSON.parse(item).id;
                    pin.redirectUrl = url;

                    Microsoft.Maps.Events.addHandler(pin, 'click', function (e) {
                        window.location = e.target.redirectUrl;
                    });
                }
            }
        mapa.entities.push(pin);
    });    
}