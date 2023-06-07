using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementares.Models
{
    public abstract class AtividadeComplementar
    {
        public AtividadeComplementar(string nome, DateTime data, int cargaHoraria) { 
            Nome = nome;
            Datarealizacao = data;
            CargaHoraria = cargaHoraria;
        }
        public string Nome { get; private set; }
        public DateTime Datarealizacao { get; private set; }
        public int CargaHoraria { get; private set; }
    }
}
