using System.Xml.Linq;

int num1 = 21;
int num2 = 17;

var suma = num1 + num2;
var resta = num1 - num2;
var multi = num1 * num2;
var div = num1 / num2;

int val1 = 9;
var val2 = 9;
double val3 = 10;
double val4 = 10;
var data = val1 != val2;
string name;

Console.WriteLine(" Suma: {0}\n Resta: {1}\n Multiplicacion: {2}\n Division: {3}", suma, resta, multi, div);

if (val1 != val2 || val3 == val4) //Nos da el resultado si es verdad cualquiera de las 2 condiciones
{
    Console.WriteLine("Resultado: {0}", data);
}
if (data)           //si es verdadera la condición
{
    Console.WriteLine("\nResultado True: {0}\n", data);
    if (val3 == val4)
    {
        Console.WriteLine("La condicional es verdadera y la opereacion es verdadera");
    }
    else
    {
        Console.WriteLine("La condicional es verdadera y la operacion es falsa");
    }
}
else            //sino es verdadera la condición
{
    Console.WriteLine("\nResultado False: {0}\n", data);
    if (val3 == val4)
    {
        Console.WriteLine("La condicional es falsa y la opereacion es verdadera");
    }
    else
    {
        Console.WriteLine("La condicional es falsa y la operacion es falsa");
    }
}

name = data ? "Angel" : "Bolaño";
Console.WriteLine("data: "+name);


