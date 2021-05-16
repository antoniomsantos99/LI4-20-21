var map;
function loadMapScenario() {
    //console.log(lista)

    var mapOptions = {
        zoom: 5
    };

    mapa = new Microsoft.Maps.Map(document.getElementById('map'), mapOptions);
    
    /*
    lista.forEach(function (item, index){
        var local = new Microsoft.Maps.Location(item[0], item[1]);
        var pin = new Microsoft.Maps.Pushpin(local, {color: 'green'});
        mapa.entities.push(pin);
    });*/
       
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
    });
    
}