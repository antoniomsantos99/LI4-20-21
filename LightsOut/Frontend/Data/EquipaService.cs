using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LightsOut.Data
{
    public class EquipaService
    {
        public Task<Equipa[]> GetEquipas() {
            
            //equipa1
            Equipa equipa1 = new Equipa();
            equipa1.nome = "Mercedes-Benz";
            equipa1.nacionalidade = "Alemã";
            
            List<string> pilotosEquipa1 = new List<string>();
            pilotosEquipa1.Add("Lewis Hamilton");
            pilotosEquipa1.Add("Valteri Bottas");

            equipa1.pilotos = pilotosEquipa1;

            //equipa2
            Equipa equipa2 = new Equipa();
            equipa2.nome = "Red-Bull";
            equipa2.nacionalidade = "Austriaca";
            
            List<string> pilotosEquipa2 = new List<string>();
            pilotosEquipa2.Add("Max Verstappen");
            pilotosEquipa2.Add("Sergio Pérez");

            equipa2.pilotos = pilotosEquipa2;

            //equipa3
            Equipa equipa3 = new Equipa();
            equipa3.nome = "McLaren";
            equipa3.nacionalidade = "Inglesa";
            
            List<string> pilotosEquipa3 = new List<string>();
            pilotosEquipa3.Add("Daniel Ricciardo");
            pilotosEquipa3.Add("Lando Norris");

            equipa3.pilotos = pilotosEquipa3;

            //lista de equipas
            List<Equipa> lista = new List<Equipa>();
            lista.Add(equipa1);
            lista.Add(equipa2);
            lista.Add(equipa3);
            
            return Task.FromResult(lista.ToArray());
        }
    }
}