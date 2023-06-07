using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementares.Models
{
    public class Registro
    {
        public Registro(Aluno aluno, AtividadeComplementar atividade)
        {
            DataValidacao = DateTime.Now;
            Aluno = aluno;
            Atividade = atividade;
        }
        public DateTime DataValidacao { get; set; }
        public Aluno Aluno { get; set; }
        public AtividadeComplementar Atividade { get; set; }

        public void RegistrarAtividade()
        {
            if (Atividade.Datarealizacao > DataValidacao) throw 
                    new InvalidOperationException("A data da validação não pode ser anterior a data de realização da atividade.");
        }
    } 
}
