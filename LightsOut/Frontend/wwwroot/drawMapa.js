var map;
function loadMapScenario(lista) {
    //console.log(lista)

    //console.log(JSON.parse(lista[0]).idEpoca);

    var mapOptions = {
        zoom: 5
    };

    mapa = new Microsoft.Maps.Map(document.getElementById('map'), mapOptions);

    lista.forEach(function (item, index) {

        //console.log(JSON.parse(item));
        //console.log(JSON.parse(item).data.split("T")[0]);
        var local = new Microsoft.Maps.Location(JSON.parse(item).localizacao.latitude, JSON.parse(item).localizacao.longitude);
        
        diaAtual = new Date(Date.now()).toISOString().split('T')[0]
        diaProva = new Date(JSON.parse(item).data).toISOString().split('T')[0]

        if (diaProva > diaAtual) {
            var pin = new Microsoft.Maps.Pushpin(local, { color: 'black' });
        } else {
            if (diaProva == diaAtual){
                var pin = new Microsoft.Maps.Pushpin(local, { color: 'red' });
            }
            else{
                console.log(diaProva);
                console.log(diaAtual);
                var pin = new Microsoft.Maps.Pushpin(local, { color: 'green' });
            }
        }

        var url = "http://localhost:5000/resultados/" + JSON.parse(item).id;
        //var url = "http://localhost:5000/resultados/";
        pin.redirectUrl = url;
        /*
         infobox = new Microsoft.Maps.Infobox(local, {
         title: 'teste',
         description: 'possivel resultado',
         visible: 'false'});
        */

        Microsoft.Maps.Events.addHandler(pin, 'click', function (e) {
            window.location = e.target.redirectUrl;
        });

        mapa.entities.push(pin);
    });

    /*
    var local1 = new Microsoft.Maps.Location(24.6149, -42.1941);
    var local2 = new Microsoft.Maps.Location(13.6149, 10.1941);
    var local3 = new Microsoft.Maps.Location(-20.6149, -20.1941);

    var local4 = new Microsoft.Maps.Location(60.6149, 22.1941);
    var local5 = new Microsoft.Maps.Location(-10.6149, 10.1941);

    var local6 = new Microsoft.Maps.Location(4.6149, -2.1941);
    var local7 = new Microsoft.Maps.Location(30.6149, 30.1941);

    var provasTerminadas = [local1, local2, local3];
    var provasDecorrer = [local4, local5];
    var provasFuturas = [local6, local7];

    
    provasTerminadas.forEach(function (item, index) {
        var pin = new Microsoft.Maps.Pushpin(item, {
            color: 'green'
        });

        //Add the pushpin to the map
        mapa.entities.push(pin);
    });

    provasDecorrer.forEach(function (item, index) {
        var pin = new Microsoft.Maps.Pushpin(item, {
            color: 'red'
        });

        //Add the pushpin to the map
        mapa.entities.push(pin);
    });

    provasFuturas.forEach(function (item, index) {
        var pin = new Microsoft.Maps.Pushpin(item, {
            color: 'grey'
        });

        //Add the pushpin to the map
        mapa.entities.push(pin);
    });*/
    
}