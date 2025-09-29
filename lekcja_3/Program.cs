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
        
        for (int j = 0; j <3; j++)
        {
            int zmienna = 0; 
            
                zmienna = tab[0, j];
                tab[0, j] = tab[1, j];
                tab[1, j] = zmienna;
        }
        
        for (int j = 0; j <2; j++)
        {
            int suma = 0; 
            for (int i = 0; i < 3; i++)
            {
                suma += tab[j, i];
            }
            Console.WriteLine($"suma wiersza {j + 1}: {suma};");
        }
        
            
            
        
        
        




    }
}