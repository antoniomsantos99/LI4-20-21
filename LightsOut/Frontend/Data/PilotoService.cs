using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LightsOut.Data
{
    public class PilotoService
    {
        public Task<Piloto[]> GetClassificacao() {
            Piloto piloto1 = new Piloto();
            piloto1.Posicao = 1;
            piloto1.Nome = "Max Verstappen";
            piloto1.Pontos = 25;

            Piloto piloto2 = new Piloto();
            piloto2.Posicao = 2;
            piloto2.Nome = "Lewis Hamilton";
            piloto2.Pontos = 20;

            Piloto piloto3 = new Piloto();
            piloto3.Posicao = 3;
            piloto3.Nome = "Valteri Bottas";
            piloto3.Pontos = 15;

            List<Piloto> lista = new List<Piloto>();
            lista.Add(piloto1);
            lista.Add(piloto2);
            lista.Add(piloto3);
            
            return Task.FromResult(lista.ToArray());
        }
    }
}