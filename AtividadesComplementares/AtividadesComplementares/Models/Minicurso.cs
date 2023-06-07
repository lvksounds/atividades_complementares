using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementares.Models
{
    public class Minicurso : AtividadeComplementar
    {
        public string UriCertificado { get; set; }
        public Minicurso(string nome, DateTime dataRealizacao, int cargaHoraria, string certificado) : 
            base(nome, dataRealizacao, cargaHoraria)
        {
            UriCertificado = certificado;
        }
    }
}
