using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = " 1234 ";
            mhs1.NamaMahasiswa = "Bejo";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = " 1234 ";
            mhs2.NamaMahasiswa = "Jono";

            Dosen dosen = new Dosen();
            dosen.Nik = "9786";
            dosen.NamaDosen = "Reza";

            List<Mahasiswa> list = new List<Mahasiswa>();

            list.Add(mhs1);
            list.Add(mhs2);

            Console.WriteLine(" Nim     Nama\n");
            Console.WriteLine("=============\n");

            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0} , {1}",mhs.Nim, mhs.NamaMahasiswa);
            }
            Console.ReadKey();
        }
    }
}