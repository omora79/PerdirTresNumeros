
//Realizar un algoritmo que me pida 3 números por pantalla, con el primer número hallar el cuadrado
//, con el segundo número hallar la raíz cuadrada y con el tercer número hallar la raíz cúbica.
//Mostrar en pantalla los 3 resultados aritméticos.


// recordar clase y metodo
public class tresNumeros
{
    static void Main(string[] args)
    {
        // 1 definir variables
        double num1, num2, num3;
        double cuadra, raiz, cubica;

        // 2 Pedir datos en pantalla

        Console.WriteLine("ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese el tercer numero: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        // 3 hacer los calculos

        cuadra = num1 * num1;
        raiz = Math.Sqrt(num2);
        cubica = Math.Pow(num3,1.0/3.0);

        //Mostrar los datos ne pantalla

        Console.WriteLine("el cuadrado de: " + num1 + " es: " + cuadra);
        Console.WriteLine("la raiz cuadrada de:" + num2 + " es: " + raiz);
        Console.WriteLine("la raiz cubica de:" + num3 + " es: " + cubica);

    }
}
