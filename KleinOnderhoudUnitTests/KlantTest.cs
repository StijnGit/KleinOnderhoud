using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KleinOnderhoudApi.Models;
using KleinOnderhoudApi.Controllers;

namespace KleinOnderhoudUnitTests
{
    [TestClass]
    public class KleinOnderhoudTests
    {
        [TestMethod]
        public void MaakKlant()
        {
            KlantController k = new KlantController();

            Klant klant = new Klant("Wim", "Aerts");

            k.PostKlant(klant);

        }
    }
}
