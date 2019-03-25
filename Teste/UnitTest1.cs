using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteRecursaoT1;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void P1_BuscaRaiz()
        {
            Node n0 = new Node("A", null, null);
            string res = Buscar.Executar(n0);
            Assert.AreEqual("A", res);
        }
        
        [TestMethod]
        public void P2_BuscaFilhos()
        {
            Node n0 = new Node("B", new Node("A", null, null), new Node("C", null, null));
            string res = Buscar.Executar(n0);
            Assert.AreEqual("ABC", res);
        }
        
        [TestMethod]
        public void P3_BuscaNetos()
        {
         Node n0 = new Node("F",
      new Node("C", new Node("A", null, null), new Node("D", null, null)),
       new Node("M", new Node("K", null, null), new Node("O", new Node("N", null,null), null)));
            string res = Buscar.Executar(n0);
            Assert.AreEqual("ACDFKMNO", res);
        }
       //  new Node("M", new Node("K", null, null), new Node("O", new Node("N", null, null), null)));
        [TestMethod]
        public void P4_BuscaDeadLock()
        {
            Node n0 = new Node("F", null, null);
            n0.Prior = new Node("C", new Node("A", null, null), new Node("D", null, null));
            n0.Next = new Node("M", new Node("K", null, null), new Node("O", new Node("N", null, null),n0));
            
            
            string res = Buscar.Executar(n0);
            Assert.AreEqual("ACDFKMNO", res);
        }
    }
}
