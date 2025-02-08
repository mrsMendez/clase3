
using clase3;
using System.ComponentModel.Design;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Word!");

// declaracion only
float temperatura;
string nombre;
MiClase MiClase;


//declaracion de inicializacion (por ejemplo) 

char primeraLetra = 'a';
var limite = 3;
int[] recurso = { 1, 2, 3, 4, 5 };
var query = from item in recurso
            where item <= limite
            select item;


//conversion entre tipos
//conversion implicita

int num = 2147483647;
long Maynum = num;

//conversion explicita

    double x = 1234.7;
    int a;
    // cast double to int
    a = (int)x;
    System.Console.WriteLine(a);

// operadores aritmeticos

//operador de incremento ++x
//posfijo
int i = 3;
Console.WriteLine(i); //resultado: 3
Console.WriteLine(i++); //resultado 3
Console.WriteLine(1); //resultado 4

//decremento
//posfijo
int m = 6;
Console.WriteLine(m); //resultado: 6
Console.WriteLine(m++); //resultadot 6
Console.WriteLine(m); //resultado 7


//prefijo
double c = 1.5;
Console.WriteLine(c);  
Console.WriteLine(--c);
Console.WriteLine(c);

//decremento
//prefijo
double e = 2.5;
Console.WriteLine(e);
Console.WriteLine(--e);
Console.WriteLine(e);




//operador unario + -
Console.WriteLine(+4);                  //resultado 4
Console.WriteLine(-4);                  //resultado -4
Console.WriteLine(-(-4));               //resultado 4

uint  g = 5;
var y = -g;
Console.WriteLine(y);                   //resultado -5
Console.WriteLine(y.GetType());         //resultado System.Int64

Console.WriteLine(-double.NaN);         //resultado NaN 



//operador de multiplicacion

Console.WriteLine(5* 2);                //resultado 10
Console.WriteLine(0.5 * 2.5);           //resultado 1.25
Console.WriteLine(0.1m * 23.4m);        //resultado 2.34


//division
Console.WriteLine(13 / 5.0);

int q = 13;
int p = 5;
Console.WriteLine((double)q / p); 




Console.WriteLine(5 % 4);               //residuo 
Console.WriteLine(5 % -4);              //residuo
Console.WriteLine(-5 % 4);              //residuo
Console.WriteLine(-5 % -4);             //residuo




//expresion boleana 
//estructura simple

DisplayMeasurement(45);
DisplayMeasurement(-3);

void DisplayMeasurement(double value)
{
    if (value < 0 || value > 100)
{
    Console.Write("warning:  not acceptable value!");
}

    Console.WriteLine($"the measurement value is (value)");
}



// estructura compuesta
DisplayWeatherReport(15.0);
DisplayWeatherReport(24.0);

void DisplayWeatherReport(double tempInCelsius)
{
    if (tempInCelsius < 20.0)
    {
        Console.WriteLine("cold.");
    }
    else
    {
        {
            Console.WriteLine("Perfecto");
        }
    }
}


//estructura multiple 

void DisplayCharacter(char ch)
{
    if (char.IsUpper(ch))
    {
        Console.WriteLine($"An uppercase letter: (ch)");
    }
    else if (char.IsLower(ch))
    {
        Console.WriteLine($"A lowercase letter: (ch)");
    }
    else if (char.IsDigit(ch))
    {
        Console.WriteLine($"A digit: (ch)");
    }
    else
    {
        Console.WriteLine($"Not alphanumeric character: (ch)");
    }
}


// instruccion switch

DisplayMeasurement2(-4);
DisplayMeasurement2(5);
DisplayMeasurement2(10);
DisplayMeasurement2(double.NaN);

void DisplayMeasurement2(double measurement)
{
    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; too low.");
            break;

            case < 15.0: 
            Console.WriteLine($"Measured value is {measurement}; too high.");
            break;

        case double.NaN:
            Console.WriteLine("Failed measurement.");
            break;


        default:
            Console.WriteLine($"Measure value is {measurement}.");
            break;
    }
}


//estructura de iteracion

//estructura for

for (int f  = 0; e < 3; e++)
{
    Console.Write(e);           //resultado 012
}



//instruccion foreach
List<int> fibNumbers = new() { 0, 1, 2, 3, 4, 5, 8, 13 };
foreach (int element in fibNumbers)
{
    Console.Write($"{element}");
}

//instruccion do

int n = 0;
do
{
    Console.Write(n);           //resultado 01234
    n++;
} while (n < 5);



//instruccion while

int s = 0;
while (s < 5)
{
    Console.Write(s); //resultado 01234
    n++;
}



//funciones

string GetName(int ID)
{
    if (ID < names.Length)
         return names[ID];
    else
        return String.Empty;
}
string[] names = { "Spencer", "Sally", "Doug" };