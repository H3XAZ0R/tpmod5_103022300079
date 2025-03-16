using System;

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
        DataGeneric<string> data = new DataGeneric<string>("103022300079"); // Ganti dengan NIM
        data.PrintData();
    }
}
