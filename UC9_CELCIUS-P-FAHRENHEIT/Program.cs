//CRIANDO AS VARIÁVEIS
double g, f, gconvert, fconvert;
int op;
string sim;

//DANDO VALOR AS VARIÁVEIS
sim = "S";
g = 0;
f = 0;
op = 0;
gconvert = 0;

//PERGUNTAS 
Console.WriteLine("1 - CELSIUS -> FAHRENHEIT");
Console.WriteLine("2 - FAHRENHEIT -> CELSIUS");
op = int.Parse(Console.ReadLine());

//WHILE
while (sim == "S" || sim == "s")
{

    //SWITCH
    switch (op)
    {
        case 1:

            //FAZNDO AS PERGUNTAS
            Console.Clear();
            Console.WriteLine("Quantos graus CELSIUS gostaria de converter para FAHRENHEIT");
            g = double.Parse(Console.ReadLine());

            gconvert = (g * 1.8) + 32;

            Console.Clear();

            Console.WriteLine("A conversão deu: " + gconvert + " FAHRENHEIT");

            break;

        case 2:

            Console.Clear();
            Console.WriteLine("Quantos FAHRENHEIT gostaria de converter para CELSIUS");
            f = double.Parse(Console.ReadLine());

            fconvert = (f - 32) * 1.8;

            Console.Clear();

            Console.WriteLine("A conversão deu: " + fconvert + " FAHRENHEIT");

            break;
    }

    Console.Clear();
    Console.WriteLine("Gostaria de converter de novo? S/N");
    sim = Console.ReadLine();
}