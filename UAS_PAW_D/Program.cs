using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UAS_PAW_D
{
    /// <summary>
    /// main class
    /// </summary>
    public class Administrasi
    {
        ///<param name ="nomor induk">double untuk array nomor induk dikarenakan double hanya dikhususkan untuk memasukkan angka juga menggunakan array agar bisa memasukkan data yang banyak</param>
        double[] nomorinduk = new double[100];
        ///<param name="nama">string untuk array nama dikarenakan string hanya dikhususkan untuk memasukkan abjad juga menggunakan array agar bisa memasukkan data yang banyak</param>
        string [] nama = new string[100];
        ///<param name="kelas">string untuk array kelas dikarenakan string hanya dikhususkan untuk memasukkan abjad juga menggunakan array agar bisa memasukkan data yang banyak</param>
        string[] kelas = new string[100];
        ///<param name="alamat">string untuk array alamat dikarenakan string hanya dikhususkan untuk memasukkan abjad juga menggunakan array agar bisa memasukkan data yang banyak</param>
        string[] alamat = new string[100];
        ///<param name="jeniskelamin">string untuk array jeniskelamin dikarenakan string hanya dikhususkan untuk memasukkan abjad juga menggunakan array agar bisa memasukkan data yang banyak</param>
        string[] jeniskelamin = new string[100];
        
        
        /// <summary>
        /// operasi input data 
        /// </summary>
        public void DataSekolah()
        {
            //Line di bawah adalah syntax untuk menu dalam program
            Console.WriteLine("[][][][][][][][][][][][][][][][][][][][][][][][][][][][]");
            Console.WriteLine("\tSelamat Datang Di SMP Negeri 12 Sragen");
            Console.WriteLine("[][][][][][][][][][][][][][][][][][][][][][][][][][][][]");
            ///<param name="i, n">code ini ditujukan untuk memasukkan banyaknya data yang akan diinputkan dan mennggunakan int karena hanya memasukkan angka juga untuk membaca dari variable n</param>
            int i, n = 0;
            Console.WriteLine("Berapa Banyak Siswa Yang Ingin Di Inputkan Datanya ? :");
            n = int.Parse(Console.ReadLine());
            ///Line dibawah adalah function untuk memasukkan data2 siswa juga untuk mendeskripsikan dan membaca array pada program
            for (i = 1; i<=n; i++)
            {
                Console.Write("Silahkan Masukkan Kelas Siswa (A / B / C / D) = ");
                kelas[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Silahkan Masukkan Nama Siswa = ");
                nama[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Silahkan Masukkan Nomor Induk Siswa = ");
                nomorinduk[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Silahkan Masukkan Jenis Kelamin Siswa = ");
                jeniskelamin[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Silahkan Masukkan Alamat Siswa = ");
                alamat[i] = Convert.ToString(Console.ReadLine());

            }


            Console.Clear();
            //Line dibawah adalah tampilan untuk menu
            Console.WriteLine("****************************************");
            Console.WriteLine("\tSMP Negeri 12 Sragen");
            Console.WriteLine("****************************************");
            ///<param name="kelas">function dibawah untuk array kelas jika user mentrigger salah satu huruf pada code dibawah akan di display nama guru sesuai huruf yang sudah diketikkan</param>
            for (i = 1; i <= n; i++)
            {
                switch (kelas[i])
                {
                    case "A":
                        Console.WriteLine("Wali Kelas : Pak Joko");
                        break;
                    case "B":
                        Console.WriteLine("Wali Kelas : Pak Dwi");
                        break;
                    case "C":
                        Console.WriteLine("Wali Kelas : Ibu Sindy");
                        break;
                    case "D":
                        Console.WriteLine("Wali Kelas : Ibu Sinta");
                        break;
                    default:
                        break;
                }
                //Code dibawah untuk mendisplay array
                Console.WriteLine($"Kelas Siswa = \t{kelas[i]}" +
                    $"\nNama Siswa = \t{nama[i]}" +
                    $"\nNomor Induk Siswa = \t{nomorinduk[i]}" +
                    $"\nJenis Kelamin Siswa = \t{jeniskelamin[i]}" +
                    $"\nAlamat Siswa = \t{alamat[i]}");
                
            }
            try
            {
                ///<param name="path">untuk memasukkan program yang sudah dijalankan akan di print ke dalam folder kita jika memang user ingin mencetak data yang sudah diketiknya</param>
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamWriter sw = new StreamWriter("D:\\PAW 2\\UAS_PAW_D\\" + ".txt");
                sw.WriteLine("****************************************");
                sw.WriteLine("\tSMP Negeri 12 Sragen");
                sw.WriteLine("****************************************");
                ///<param name="kelas">function dibawah untuk array kelas jika user mentrigger salah satu huruf pada code dibawah akan di display di folder nama guru sesuai huruf yang sudah diketikkan</param>
                for (i = 1; i <= n; i++)
                {
                    
                    switch (kelas[i])
                    {
                        case "A":
                            sw.WriteLine("Wali Kelas : Pak Joko");
                            break;
                        case "B":
                            sw.WriteLine("Wali Kelas : Pak Dwi");
                            break;
                        case "C":
                            sw.WriteLine("Wali Kelas : Ibu Sindy");
                            break;
                        case "D":
                            sw.WriteLine("Wali Kelas : Ibu Sinta");
                            break;
                        default:
                            break;
                    }
                    //Code dibawah untuk mendisplay array                    
                    sw.WriteLine($"Kelas Siswa\t\t\t\t= {kelas[i]}");
                    sw.WriteLine($"Nama Siswa\t\t\t\t= {nama[i]} ");
                    sw.WriteLine($"Nomor Induk Siswa\t\t\t= {nomorinduk[i]}");
                    sw.WriteLine($"Jenis Kelamin Siswa\t\t= {jeniskelamin[i]}");
                    sw.WriteLine($"Alamat Siswa\t\t\t= {alamat[i]}");
                }
                sw.Close();
            }
            //syntax dibawah adalah untuk memunculkan pesan error jika errornya tidak terlihat
            catch (Exception e)
            {

                Console.WriteLine("Exception : " + e.Message);
            }

            finally
            {
                Console.WriteLine("Data Telah Tersimpan");
            }

            Console.ReadKey();
        }

       

    }

    //class untuk menjalankan program
    internal class Program
    {
        static void Main(string[] args)
        {
            Administrasi ad = new Administrasi();

            ad.DataSekolah();

        }
    }
}
