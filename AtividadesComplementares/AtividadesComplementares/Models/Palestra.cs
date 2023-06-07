using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementares.Models
{
    public class Palestra : AtividadeComplementar
    {
        public string Palestrante { get; set; }
        public Palestra(string nome, DateTime data, int cargaHoraria, string palestrante) : base(nome, data, cargaHoraria)
        {
            Palestrante = palestrante;
        }
    }
}
