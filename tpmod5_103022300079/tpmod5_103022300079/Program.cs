using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class DataGeneric<T>
{
    public T Data { get; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("NamaPanggilan"); // Ganti dengan nama panggilan praktikan

        DataGeneric<string> data = new DataGeneric<string>("103022300079"); // Ganti dengan NIM
        data.PrintData();
    }
}
