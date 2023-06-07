using AtividadesComplementares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class PalestraTests
    {
        [TestMethod]
        public void Deve_Criar_Palestra()
        {
            // arrange 
            string palestrante = "Chris Rock";
            string nome = "Todo mundo Odeia o Chris";
            DateTime dataRealizacao = DateTime.Now.AddDays(-10);
            int ch = 10;

            //act 
            var palestra = new Palestra(nome, dataRealizacao, ch, palestrante);

            // asserts

            Assert.IsNotNull(palestra);
            Assert.AreEqual(palestra.Palestrante, palestrante);
            Assert.AreEqual(palestra.Nome, nome);
            Assert.AreEqual(palestra.Datarealizacao, dataRealizacao);
            Assert.AreEqual(palestra.CargaHoraria, ch);
        }
    }
}
