using AtividadesComplementares.Models;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class AlunoTests
    {
        [TestMethod]
        public void Deve_Criar_Aluno()
        {
            //arrange
            string nome = "Lucas Oliveira";
            string email = "lvksounds@gmail.com";

            // act 
            var aluno = new Aluno(nome, email);

            // assert
            Assert.IsNotNull(aluno);
            Assert.AreEqual(aluno.Nome, nome);
            Assert.AreEqual(aluno.Email, email);

        }

        [TestMethod]
        public void Erro_ao_Criar_Aluno()
        {
            //arrange
            string nome = "Lucas Oliveira";
            string email = "lvksounds@gmail.com";

            // act 
            var aluno = new Aluno("Julia Nicolau", "nicolaujubs@gmail.com");

            // assert 
            Assert.AreNotEqual(aluno.Nome, nome);
            Assert.AreNotEqual(aluno.Email, email);
        }
    }
}