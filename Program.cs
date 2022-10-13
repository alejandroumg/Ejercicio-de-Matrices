// Tarea Grupal Matices conteniene la tabla de multiplicar del 1 al 9 (10 filas y 10 columnas).
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
       int opc=0;
       int C =10;
       int F =10;
       int[,] matriz = new int[F,C];
       StreamWriter writer=null;
       do
       {
        Console.Clear();
            Console.WriteLine("TABLA DE MULTIPLICAR");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. PROGRAMA TABLA");
            Console.WriteLine("2. TXT");
            Console.WriteLine("3. Leer");
            Console.WriteLine("4. SALIR");
            Console.WriteLine("-----------------------");
            Console.WriteLine("INGRESE OPCION: ");
            opc= Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                tabla(matriz);
                break;
                case 2:
                crear(writer);
                break;
                case 3:
                ReadFile(writer);
                break;
                case 4:
                Console.WriteLine("Gracias por usar el programa");
                break;
                default:
                Console.WriteLine("ingrese otra opcion");
                break;
            }
            Console.ReadKey();
       }while (opc!=4);
    }
    public static void tabla (int[,] matriz){

        int filas = matriz.GetLength(0); 
        int columnas = matriz.GetLength(1);
       Console.WriteLine("");
       
       
        for (int i = 0; i < filas; i++)
        {
           for (int j = 0; j < columnas; j++)
            {
             
               if(j<=0 )
               matriz[i,j]=i;
              

                else

                matriz[i,j]=i*j;
                
                Console.Write(matriz [i,j]+ "\t" );
                

           }
            Console.WriteLine("");

        }
    }
    public static void crear(StreamWriter writer){
      writer = new StreamWriter("./myfile.txt");
        writer.WriteLine(@"
        0   1   2   3   4   5   6   7   8   9
        1   1   2   3   4   5   6   7   8   9
        2   2   4   6   8   10  12  14  16  18
        3   3   6   9   12  15  18  21  24  27
        4   4   8   12  16  20  24  28  32  36
        5   5   10  15  20  25  30  35  40  45
        6   6   12  18  24  30  36  42  48  54
        7   7   14  21  28  35  42  49  56  63
        8   8   16  24  32  40  48  56  64  72
        9   9   18  27  36  45  54  63  72  81
        ");

        writer.Close();
        Console.WriteLine("se genero con exito");
    }
    public static void ReadFile(StreamWriter writer){
       StreamReader reader = new StreamReader("./myfile.txt");
       do
        {
            Console.WriteLine(reader.ReadLine());
        }
        while(reader.Peek()!= -1);
        
    }
}
