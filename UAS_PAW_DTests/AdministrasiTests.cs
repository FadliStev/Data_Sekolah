using Microsoft.VisualStudio.TestTools.UnitTesting;
using UAS_PAW_D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PAW_D.Tests
{
    [TestClass()]
    public class AdministrasiTests
    {
        Administrasi ad = new Administrasi();
        [TestMethod()]
        public void DataSekolahTest()
        {
            string kelas = "A";
            Assert.IsTrue(true, kelas);

            string nama = "Fadli";
            Assert.IsTrue(true, nama);

            string jeniskelamin = "L";
            Assert.IsTrue(true, jeniskelamin);

            string alamat = "Mojo";
            Assert.IsTrue(true, alamat);

            int nomorinduk = 131313;
            Assert.AreEqual(131313, nomorinduk);

        }
    }
}