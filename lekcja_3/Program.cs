namespace lekcja_3;

class Program
{
    static void Main(string[] args)
    {
        int[,] tab = new int[2, 3];
            
        
        for (int i = 0; i <3; i++)
        {
            tab[0,i] = int.Parse(Console.ReadLine());
            tab[1,i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i <= 2; i++)
        {
            Console.Write($"{tab[0,i]}, ");
        }
            Console.WriteLine();
            
        for (int i = 0; i <= 2; i++)
        {
            Console.Write($"{tab[1,i]}, ");
        }
            Console.WriteLine();
            

        int suma_1 = tab[0,0] + tab[1,0];
        int suma_2 = tab[0,1] + tab[1,1];
        int suma_3 = tab[0,2] + tab[1,2];
        
        Console.WriteLine($"{suma_1}");
        Console.WriteLine($"{suma_2}");
        Console.WriteLine($"{suma_3}");




    }
}