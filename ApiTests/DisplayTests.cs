using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTests;

namespace Api.Tests
{
    [TestClass()]
    public class DisplayTests
    {
        [TestMethod()]
        public void DisplayTest()
        {
            ITag target = new FakeApiCall();
            List<Tram> list = target.GetTrams();
            String attendu = Display.DisplayInfo(list);
            String result = "FONTAINE La Poya / PONT DE CLAIX  L'Etoile";
            Assert.AreEqual(result, attendu);
        }
    }
}