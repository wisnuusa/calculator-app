class Calculator {
	static void Main(string[] args)
	{
		int a = 10;
        int b = 5;

        Console.Write("Inputkan Nilai a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan Nilai b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Hasil Penambahan" + a + " + " + b + " = " + Penambahan(a, b));
        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
        Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

        Console.WriteLine("\nTekan Sembarang Key untuk Keluar");
        Console.ReadKey();
	}
	static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
}
