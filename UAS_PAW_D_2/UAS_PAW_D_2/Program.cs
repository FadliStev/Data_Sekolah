using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UAS_PAW_D_2
{
  
    public class Cafe
    {
        
        public double JmlhPesanMakan1, JmlhPesanMinumA;
        public double JmlhPesanMakan2, JmlhPesanMinumB; 
        public double TotalhargapesanMakan, totalhargapesanMinum;
        public double totalhargapesanMakan2, totalhargapesanMinumA;
        public double bayar, kembalian;
        public string NamaPelanggan;
        public string NamaKasir;

        public void nama()
        {
            Console.WriteLine("Silahkan Masukkan Nama Pelanggan = ");
            NamaPelanggan = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Silahkan Masukkan Nama Kasir = ");
            NamaKasir = Convert.ToString(Console.ReadLine());
            
        }
        public void Nasigoreng()
        {
            Console.WriteLine("Anda ingin memesan berapa ? : ");
            JmlhPesanMakan1 = Convert.ToDouble(Console.ReadLine());

        }
        public void HitungNasiGoreng()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\tCafe FadliStev");
            Console.WriteLine("\tBelum Mampir Ga Usah Nyinyir");
            Console.WriteLine("------------------------------------------------- ");
            Console.WriteLine("Nama Pelanggan = {0}", NamaPelanggan);
            Console.WriteLine("Nama Kasir = {0}", NamaKasir);
            Console.WriteLine("Tanggal Pembelian = {0}", DateTime.Now.ToString());
            Console.WriteLine("Nasi Goreng = {0}", JmlhPesanMakan1);
            Console.WriteLine("Harga Satuan = Rp.13000");
            TotalhargapesanMakan = 13000 * JmlhPesanMakan1;
            Console.WriteLine("Total Harga Yang Anda Pesan = Rp.{0}", TotalhargapesanMakan);
          
        }
        public void Miegoreng()
        {
            Console.WriteLine("Anda ingin memesan berapa ? : ");
            JmlhPesanMakan2 = Convert.ToDouble(Console.ReadLine());
           

            Console.ReadKey();
        }
        public void HitungMieGoreng()
        {

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\tCafe FadliStev");
            Console.WriteLine("\tBelum Mampir Ga Usah Nyinyir");
            Console.WriteLine("------------------------------------------------- ");
            Console.WriteLine("Nama Pelanggan = {0}", NamaPelanggan);
            Console.WriteLine("Nama Kasir = {0}", NamaKasir);
            Console.WriteLine("Tanggal Pembelian = {0}", DateTime.Now.ToString());
            Console.WriteLine("Mie Goreng = {0}", JmlhPesanMakan2);
            Console.WriteLine("Harga Satuan = Rp.6000");
            totalhargapesanMakan2 = 6000 * JmlhPesanMakan2;
            Console.WriteLine("Total Harga Yang Anda Pesan = Rp.{0}", totalhargapesanMakan2);

        }

        public void Esteh()
        {
            Console.WriteLine("Anda Ingin Memesan Berapa ? : ");
            JmlhPesanMinumA = Convert.ToDouble(Console.ReadLine());
           
            Console.ReadKey();
        }
        public void HitungEsteh()
        {

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\tCafe FadliStev");
            Console.WriteLine("\tBelum Mampir Ga Usah Nyinyir");
            Console.WriteLine("------------------------------------------------- ");
            Console.WriteLine("Nama Pelanggan = {0}", NamaPelanggan);
            Console.WriteLine("Nama Kasir = {0}", NamaKasir);
            Console.WriteLine("Tanggal Pembelian = {0}", DateTime.Now.ToString());
            Console.WriteLine("ES TEH = {0}", JmlhPesanMinumA);
            Console.WriteLine("Harga Satuan = Rp.3000");
            totalhargapesanMinum = 3000 * JmlhPesanMinumA;
            Console.WriteLine("Total Harga Yang Anda Pesan = Rp.{0}", totalhargapesanMinum);
        }

        public void TehHangat()
        {
            Console.WriteLine("Anda ingin memesan berapa ? : ");
            JmlhPesanMinumB = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
        }
        public void HitungTehHangat()
        {

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\tCafe FadliStev");
            Console.WriteLine("\tBelum Mampir Ga Usah Nyinyir");
            Console.WriteLine("------------------------------------------------- ");
            Console.WriteLine("Nama Pelanggan = {0}", NamaPelanggan);
            Console.WriteLine("Nama Kasir = {0}", NamaKasir);
            Console.WriteLine("Tanggal Pembelian = {0}", DateTime.Now.ToString());
            Console.WriteLine("Teh Hangat = {0}", JmlhPesanMinumB);
            Console.WriteLine("Harga Satuan = Rp.2500");
            totalhargapesanMinumA = 2500 * JmlhPesanMinumB;
            Console.WriteLine("Total Harga Yang Anda Pesan = Rp.{0}", totalhargapesanMinumA);
        }

       
        public void Pelangganbayar()
        {
            Console.Write("Masukkan Jumlah Uang Pelanggan = Rp. ");
            bayar = Convert.ToDouble(Console.ReadLine());
            
        }

        public void KembalianPelanggan()
        {
            kembalian = bayar - (TotalhargapesanMakan + totalhargapesanMakan2+ totalhargapesanMinum +totalhargapesanMinumA);
            Console.WriteLine("Kembalian = {0}", kembalian);
            Console.WriteLine("\tTERIMA KASIH");
            Console.ReadKey();
        }

       
    }

    
    class Program
    {
        static void Main(string[] args)
        {
           
            Cafe cf = new Cafe();
           
            int pilih;
            
            
            
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("\tSelamat Datang Di Cafe FadliStev");
                Console.WriteLine("\tBelum Mampir Ga Usah Nyinyir");
                Console.WriteLine("------------------------------------------------- ");

                Console.WriteLine("\tSilahkan Pilih Menu");
                Console.WriteLine("Makanan");
                Console.WriteLine("1.Nasi Goreng");
                Console.WriteLine("2.Mie Goreng");
                Console.WriteLine("3.Es Teh");
                Console.WriteLine("4.TehHangat");

                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");



                switch (pilih)
                {
                    case 1:
                        cf.Nasigoreng();
                        cf.nama();
                        Console.Clear();
                        cf.HitungNasiGoreng();
                        cf.Pelangganbayar();
                        cf.KembalianPelanggan();

                        break;
                    case 2:
                        cf.Miegoreng();
                        cf.nama();
                        Console.Clear();
                        cf.HitungMieGoreng();
                        cf.Pelangganbayar();
                        cf.KembalianPelanggan();
                        break;
                    case 3:
                        cf.Esteh();
                        cf.nama();
                        Console.Clear();
                        cf.HitungEsteh();
                        cf.Pelangganbayar();
                        cf.KembalianPelanggan();
                        break;
                    case 4:
                        cf.TehHangat();
                        cf.nama();
                        Console.Clear();
                        cf.HitungTehHangat();
                        cf.Pelangganbayar();
                        cf.KembalianPelanggan();
                        break;

                    case 5:
                    Console.WriteLine("\t\t\tMENU TIDAK ADA");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            try
            {
               string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

               StreamWriter sw = new StreamWriter(Path.Combine(path, "D:\\PAW 2\\UAS_PAW_D\\UAS_PAW_D_2\\" + ".txt"));
                sw.WriteLine($"Nama Pelanggan = {cf.NamaPelanggan}");
                sw.WriteLine($"Nama Kasir = {cf.NamaKasir}");
                sw.WriteLine("Tanggal Pembelian = {0}", DateTime.Now.ToString());
                sw.WriteLine($"Nasi Goreng (13000)= {cf.JmlhPesanMakan1}\nHarga Total = {cf.TotalhargapesanMakan}");
                sw.WriteLine($"Es Teh (3000)= {cf.JmlhPesanMinumA}\nHarga Total = {cf.totalhargapesanMinum}");
                sw.WriteLine($"Mie Goreng (6000)= {cf.JmlhPesanMakan2}\nHarga Total = {cf.totalhargapesanMakan2}");
                sw.WriteLine($"TehHangat (2500)= {cf.JmlhPesanMinumB}\nHarga Total = {cf.totalhargapesanMinumA}");
                sw.WriteLine("Total Harga = {0}", (cf.TotalhargapesanMakan)+(cf.totalhargapesanMakan2)+(cf.totalhargapesanMinum)+(cf.totalhargapesanMinumA));
                sw.WriteLine("Jumlah Bayar = {0}", (cf.bayar));
                sw.WriteLine("Kembalian = {0}", (cf.kembalian));
                sw.WriteLine("");
                sw.Close();
            }
            catch (Exception ex)
            {
                    Console.WriteLine("Exception" + ex.Message);
            }
            finally
            {
                    Console.WriteLine("Nota Telah Tercetak");
            }
           
                
            
        }
    }
}
