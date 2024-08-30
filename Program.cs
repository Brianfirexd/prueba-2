class Ejemplos
{
    static void Main()
    {
        /*
         //declaración de variables
         int cantidad;
         Console.WriteLine("Digite la cantidad:");
         cantidad = int.Parse(Console.ReadLine());

         Console.WriteLine("Ciclo creciente");
         for (int i = 1; i <= cantidad; i++)
         {
             Console.WriteLine("Numero:" + i);
         }
         Console.WriteLine("Cicle decreciente");
         for (int i = cantidad; i >= 1; i--)
         {
             Console.WriteLine("Numero " + i);
         }
         int numero;
         Console.WriteLine("Digite el número");
         numero = int.Parse(Console.ReadLine());
         Console.WriteLine("Tabla de multiplicar con ciclo for");
         for (int i = 1; i <= 10; i++)
         {
             Console.WriteLine(numero + " x " + i + " = " + numero * i);
         }
         int contador = 1;
         Console.WriteLine("Tabla de multiplicar con ciclo while");
         while (contador <= 10)
         {
             Console.WriteLine(numero + " x " + contador + " = " + contador * numero);
             contador++;
         }
         int contador1 = 1;
         Console.WriteLine("Tabla de multiplicar con ciclo do-while");

         do
         {
             Console.WriteLine(numero +" x "+contador1+" = "+contador1*numero);
             contador1++;
         } while (contador1<=10);

         int numero2;
         int factorial=1;
         Console.WriteLine("Digite el número");
         numero2= int.Parse(Console.ReadLine());

         for (int i = 1; i <=numero2; i++)
         {
             factorial = factorial* i;
         }
         Console.WriteLine("El factorial de " + numero2 + " es " + factorial);
         Console.WriteLine(numero2+"!="+factorial);
         //resteando la varible factorial
         //factorial por decremento con while
         factorial = 1;
         int cont1=numero2;
         while (cont1>=1)
         {
             factorial = factorial * cont1;
             cont1--;
         }
         Console.WriteLine("Con ciclo while decremento");
         Console.WriteLine(numero2 + "!=" + factorial);
        
        string nombre="";
        string [] nombres;
        int[] edad;
        string []cedula;
        string []direccion;
        int [] año_lectivo = new int[] {2024,2025,2026};
        int cantidad_nombres;

        Console.WriteLine("Digite la cantidad de nombres a ingresar");
        cantidad_nombres = int.Parse(Console.ReadLine());
        nombres= new string[cantidad_nombres];
        edad= new int[cantidad_nombres];  
        cedula= new string[cantidad_nombres];
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("Digite el nombre No."+(i+1));
            nombres[i] = Console.ReadLine();
            Console.WriteLine("Edad:");
            edad[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cédula");
            cedula[i] = Console.ReadLine();
        }
        Console.WriteLine("\nNombres ingresados:\n");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("Año lectivo:"+año_lectivo[0]);
            Console.WriteLine((i+1)+") Nombre:" + nombres[i]);
            Console.WriteLine("Edad:"+edad[i]+" años");
            Console.WriteLine("Cédula:" + cedula[i]);
        }
        */

        string[] paises = new string[] { "Nicaragua", "Panama", "Costa Rica" };
        int[] numeros = new int[] { 22, 4, 10, 11, 0, -5 };
        int suma = 0;

        // paises[1] = "Brasil";
        for (int i = 0; i < paises.Length; i++)
        {
            Console.WriteLine("Pais:" + paises[i]);
        }

        Array.Sort(numeros);
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
        int final = numeros.Length;
        Console.WriteLine("El numero es mayor es:" + numeros[numeros.Length - 1]);
        Console.WriteLine("El numero es menor es:" + numeros[0]);
        for (int i = 0; i < numeros.Length; i++)
        {
            suma = suma + numeros[i];
        }
        Console.WriteLine("La suma de los elementos del arreglo:" + suma);

    }
}