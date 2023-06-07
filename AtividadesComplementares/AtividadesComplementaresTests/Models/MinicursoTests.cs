using AtividadesComplementares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class MinicursoTests
    {
        [TestMethod]
        public void Deve_Criar_Minicurso()
        {
            // arrange 
            string certificado = "098fb38nbdmz9342xf2093u4xcn.pdf";
            string nome = "Curso de C++";
            DateTime dataRealizacao = DateTime.Now.AddDays(-20);
            int ch = 20;

            //act 
            var curso = new Minicurso(nome, dataRealizacao, ch, certificado);

            // asserts

            Assert.IsNotNull(curso);
            Assert.AreEqual(curso.UriCertificado, certificado);
            Assert.AreEqual(curso.Nome, nome);
            Assert.AreEqual(curso.Datarealizacao, dataRealizacao);
            Assert.AreEqual(curso.CargaHoraria, ch);
        }
    }
}
