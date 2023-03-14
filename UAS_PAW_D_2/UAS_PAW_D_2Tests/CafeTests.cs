using Microsoft.VisualStudio.TestTools.UnitTesting;
using UAS_PAW_D_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PAW_D_2.Tests
{
    [TestClass()]
    public class CafeTests
    {
        Cafe cf = new Cafe();
        [TestMethod()]
        public void nama()
        {
            string NamaPelanggan = "budi";
            Assert.IsTrue(true, NamaPelanggan);
            string NamaKasir = "toni";
            Assert.IsTrue(true, NamaKasir);
        }

        [TestMethod()]
        public void NasigorengTest()
        {
            double Nasigoreng = 1;
            Assert.AreEqual(1, Nasigoreng);
        }

        [TestMethod()]
        public void HitungNasiGorengTest()
        {
            double HitungNasiGoreng = 1;
            Assert.AreEqual(1, HitungNasiGoreng);
        }

        [TestMethod()]
        public void MiegorengTest()
        {
            double Miegoreng = 1;
            Assert.AreEqual(1, Miegoreng);
        }

        [TestMethod()]
        public void HitungMieGorengTest()
        {
            double HitungMieGoreng = 1;
            Assert.AreEqual(1, HitungMieGoreng);
        }

        [TestMethod()]
        public void EstehTest()
        {
            double Esteh = 1;
            Assert.AreEqual(1, Esteh);
        }

        [TestMethod()]
        public void HitungEstehTest()
        {
            double HitungEsteh = 1;
            Assert.AreEqual(1, HitungEsteh);
        }

        [TestMethod()]
        public void TehHangatTest()
        {
            double TehHangat = 1;
            Assert.AreEqual(1, TehHangat);
        }

        [TestMethod()]
        public void HitungTehHangatTest()
        {
            double HitungTehHangat = 1;
            Assert.AreEqual(1, HitungTehHangat);
        }

        [TestMethod()]
        public void PelangganbayarTest()
        {
            double Pelangganbayar = 10000;
            Assert.AreEqual(10000, Pelangganbayar);
        }

        [TestMethod()]
        public void KembalianPelangganTest()
        {
            double KembalianPelanggan = 1000;
            Assert.AreEqual(1000, KembalianPelanggan);
        }
    }
}