using AtividadesComplementares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class ResgistroTests
    {
        [TestMethod]
        public void Deve_Criar_Registro_Atividade()
        {
            // arrange 
            var aluno = new Aluno("Lucas Oliveira", "lvksounds@gmail.com");
            var atividade = new AtividadeComplementar("Curso Gratis", DateTime.Now, 10);

            // act
            var registro = new Registro(aluno, atividade);

            // asserts

            Assert.IsNotNull(registro);
            Assert.AreEqual(registro.Aluno, aluno);
            Assert.AreEqual(registro.Atividade, atividade);
            Assert.IsTrue(registro.DataValidacao >= atividade.Datarealizacao);
        }

        [TestMethod]
        public void Deve_Criar_Registro_Minicurso()
        {
            // arrange 
            var aluno = new Aluno("Lucas Oliveira", "lvksounds@gmail.com");
            var curso = new Minicurso("Curso Gratis", DateTime.Now, 10, "jknsdlkjd092j2iif0249r2hd.pdf");

            // act
            var registro = new Registro(aluno, curso);

            // asserts

            Assert.IsNotNull(registro);
            Assert.AreEqual(registro.Aluno, aluno);
            Assert.AreEqual(registro.Atividade, curso);
            Assert.IsTrue(registro.DataValidacao >= curso.Datarealizacao);
        }

        [TestMethod]
        public void Deve_Criar_Registro_Palestra()
        {
            // arrange 
            var aluno = new Aluno("Lucas Oliveira", "lvksounds@gmail.com");
            var palestra = new Palestra("Curso Gratis", DateTime.Now, 10, "Fulaninho de Tal");

            // act
            var registro = new Registro(aluno, palestra);

            // asserts

            Assert.IsNotNull(registro);
            Assert.AreEqual(registro.Aluno, aluno);
            Assert.AreEqual(registro.Atividade, palestra);
            Assert.IsTrue(registro.DataValidacao >= palestra.Datarealizacao);
        }

        [TestMethod]
        public void Deve_Criar_Registro_Retornar_Exception()
        {
            // arrange 
            var aluno = new Aluno("Lucas Oliveira", "lvksounds@gmail.com");
            var atividade = new AtividadeComplementar("Curso Gratis", DateTime.Now.AddDays(10), 10);

            // act
            var registro = new Registro(aluno, atividade);
            var action = () => registro.RegistrarAtividade();

            // asserts

            Assert.IsNotNull(registro);
            Assert.AreEqual(registro.Aluno, aluno);
            Assert.AreEqual(registro.Atividade, atividade);
            Assert.IsFalse(registro.DataValidacao >= atividade.Datarealizacao);
            Assert.ThrowsException<InvalidOperationException>(action, "A data da validação não pode ser anterior a data de realização da atividade.");
        }
    }
}
