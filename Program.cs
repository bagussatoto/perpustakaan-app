using System;
using System.Collections;
using System.Collections.Generic;

namespace perpustakaan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Perpustakaan-------");
            Console.WriteLine("1. Tambah Buku");
            Console.WriteLine("2. Daftar Buku");
            Console.WriteLine("3. Cari buku ");
            Console.WriteLine("4. Insert Buku");
            Console.WriteLine("5. Hapus buku");
            Console.WriteLine("6. Hapus semua daftar buku");
            Console.WriteLine("---------------------------");
            Console.Write("Pilih Nomer = ");
            int x = int.Parse(Console.ReadLine());

            ArrayList arr = new ArrayList();
            arr.Add("Koala Kumal");
            arr.Add("Manusia Setengah Salmon");
            arr.Add("Single");
            arr.Add("Your Name");

            switch (x)
            {
                case 1:
                    Console.Write("Masukan nama Buku = ");
                    string buku = Console.ReadLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Buku Berhasil Ditambahkan");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Sebelum");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(" ");
                    foreach (string y in arr)
                    {
                        Console.WriteLine(y + " ");
                    }
                    arr.Add(buku);
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Sesudah");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(" ");
                    foreach (string y in arr)
                    {
                        Console.WriteLine(y + " ");
                    }

                    break;
                case 2:
                    Console.WriteLine(" ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Daftar Buku :");
                    Console.WriteLine("--------------------------");
                    foreach (string y in arr)
                    {
                        Console.WriteLine(y + " ");
                    }
                    break;
                case 3:
                    Console.Write("Buku yang dicari = ");
                    string cariBuku = Console.ReadLine();
                    if (arr.Contains(cariBuku))
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Buku Ada");
                        Console.WriteLine("--------------------------");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Buku tidak Ada");
                        Console.WriteLine("--------------------------");
                    }
                    break;
                case 4:
                    Console.Write("urutan ke ");
                    int urut = int.Parse(Console.ReadLine());
                    int urutan = urut - 1;
                    Console.Write("Nama buku akan ditambah = ");
                    string baru = Console.ReadLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Buku telah ditambahkan ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Sebelum");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("");
                    foreach (var val in arr)
                    {
                        Console.WriteLine(val + " ");
                    }
                    arr.Insert(urutan, baru);
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Sesudah");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("");
                    foreach (var val in arr)
                    {
                        Console.WriteLine(val + " ");
                    }

                    break;
                case 5:
                    Console.Write("Nama Buku yang akan dihapus = ");
                    string hapusBuku = Console.ReadLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Buku telah dihapus ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Sebelum");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("");
                    foreach (string y in arr)
                    {
                        Console.WriteLine(y + " ");
                    }
                    arr.Remove(hapusBuku);
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Sesudah");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("");
                    foreach (string y in arr)
                    {
                        Console.WriteLine(y + " ");
                    }

                    break;
                case 6:
                    arr.Clear();
                    Console.WriteLine("---------------------------");
                    Console.Write("Daftar buku telah di hapus");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------");
                    break;
            }
        }
    }
}

