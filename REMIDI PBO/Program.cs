using System;
using System.Collections.Generic;

class Mahasiswa
{
    public string NIM;
    public string Nama;
    public string Prodi;
}

class Program
{
    static List<Mahasiswa> data = new List<Mahasiswa>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Tambah");
            Console.WriteLine("2. Lihat");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Hapus");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih: ");
            string pilih = Console.ReadLine();

            if (pilih == "1") Tambah();
            else if (pilih == "2") Lihat();
            else if (pilih == "3") Update();
            else if (pilih == "4") Hapus();
            else if (pilih == "5") break;
            else Console.WriteLine("Pilihan salah.");
        }
    }

    static void Tambah()
    {
        Console.Write("NIM: ");
        string nim = Console.ReadLine();

        foreach (var m in data)
            if (m.NIM == nim)
            {
                Console.WriteLine("NIM sudah ada.");
                return;
            }

        Console.Write("Nama: ");
        string nama = Console.ReadLine();
        Console.Write("Prodi: ");
        string prodi = Console.ReadLine();

        data.Add(new Mahasiswa { NIM = nim, Nama = nama, Prodi = prodi });
        Console.WriteLine("Data ditambahkan.");
    }

    static void Lihat()
    {
        if (data.Count == 0)
        {
            Console.WriteLine("Belum ada data.");
            return;
        }

        foreach (var m in data)
            Console.WriteLine($"NIM: {m.NIM}, Nama: {m.Nama}, Prodi: {m.Prodi}");
    }

    static void Update()
    {
        Console.Write("NIM yang diupdate: ");
        string nim = Console.ReadLine();

        foreach (var m in data)
        {
            if (m.NIM == nim)
            {
                Console.Write("Nama baru: ");
                m.Nama = Console.ReadLine();
                Console.Write("Prodi baru: ");
                m.Prodi = Console.ReadLine();
                Console.WriteLine("Data diupdate.");
                return;
            }
        }

        Console.WriteLine("NIM tidak ditemukan.");
    }

    static void Hapus()
    {
        Console.Write("NIM yang dihapus: ");
        string nim = Console.ReadLine();

        for (int i = 0; i < data.Count; i++)
        {
            if (data[i].NIM == nim)
            {
                data.RemoveAt(i);
                Console.WriteLine("Data dihapus.");
                return;
            }
        }

        Console.WriteLine("NIM tidak ditemukan.");
    }
}
