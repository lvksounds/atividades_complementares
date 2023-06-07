using AtividadesComplementares.Models;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class AtividadeComplemetarTests
    {
        [TestMethod]
        public void Deve_Criar_Aluno()
        {
            //arrange
            string nome = "Curso C# - Do Básico ao Avançado em 5 minutos";
            DateTime dataRealizacao = DateTime.Now.AddDays(-10);
            int ch = 17;

            // act 
            var Atividade = new AtividadeComplementar(nome, dataRealizacao, ch);

            // assert
            Assert.IsNotNull(Atividade);
            Assert.AreEqual(nome, Atividade.Nome);
            Assert.AreEqual(dataRealizacao, Atividade.Datarealizacao);
            Assert.AreEqual(ch, Atividade.CargaHoraria);

        }
    }
}