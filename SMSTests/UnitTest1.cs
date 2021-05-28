using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SMS.ConsoleApp;

namespace SMSTests
{
    [TestClass]
    public class TesteSMS
    {
        
        [TestMethod]
        public void MaiorQue255() // Erro de 255 Caracteres
        {
            Letras mensagemCaracter = new Letras("SEMPRE ACESSO O DOJOPUZZLES SEMPRE SEMPRE ACESSO O DOJOPUZZLES SEMPRE SEMPRE ACESSO O DOJOPUZZLES SEMPRE SEMPRE ACESSO O DOJOPUZZLES SEMPRE SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SE SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SE SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SE SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SE SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SE SEMPRE ACESSO O DOJOPUZZLES SEMPRE ACESSO O DOJOPUZZLES SE");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", mensagemCaracter.SeparacaoMensagemEmNumeros());
        }

        [TestMethod]
        public void TestarMensagemCorreta()
        {
            Letras letras = new Letras("SEMPRE ACESSO O DOJOPUZZLES");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", letras.SeparacaoMensagemEmNumeros());
        }

        [TestMethod]
        public void TestarMensagemCorretaLowCase()
        {
            Letras letras = new Letras("sempre acesso o dojopuzzles");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", letras.SeparacaoMensagemEmNumeros());
        }

        [TestMethod]
        public void TestarMensagemNumeros()
        {
            Letras mensagemNumero = new Letras("SEMPRE ACESSO O DOJOPUZZLES 2428");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", mensagemNumero.SeparacaoMensagemEmNumeros());
        }
    }
}
