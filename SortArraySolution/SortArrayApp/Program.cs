internal class Program
{
    private static void Main(string[] args)
    {
        //Leer el tamaño del array
    Console.WriteLine ("Ingrese el tamaño del array: ");
    string tamanoArray = Console.ReadLine();
    int tamano = Int32.Parse(tamanoArray);
    Console.WriteLine ("El tamaño del array es: "+tamano);
    
    //Crear el array
    int[] array1 = new int[tamano];

    //llenar el array
    Console.WriteLine ("Ingrese numeros para llenar el array: ");
    llenarArray(array1, tamano);
    
    //Imprimier el array
    ImprimirArray(array1, tamano);

    // Ordenar el array
    Array.Sort(array1);
    
    for (int i=0; i<array1.Length; i++)
    {
      //Imprimo el arreglo ordenado
      Console.WriteLine("El array ordenado es:  "+array1[i]);
    }
    Console.ReadLine();
    }

    //Funcion llenar el array
     public static void llenarArray (int [] array, int tamano1)
     {
         // llenar los elementos del array
      for (int i=0; i<tamano1; i++)
        {
          //Asignamos los valores al array
          array[i] = int.Parse(Console.ReadLine()); 
        }
     }
  
     // Funcion imprimir el array
     public static void ImprimirArray (int[] array, int tamanoA)
     {
     for (int index=0; index < tamanoA; index++)
        {
             //imprimir
            Console.WriteLine("Array posicion: " +index+ " valor "+array[index]);
        }
     }     
}