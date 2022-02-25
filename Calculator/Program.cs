Menu();

void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("--------------------");

    Console.WriteLine("Selecione uma opção: ");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Division(); break;
        case 4: Multiplication(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

void Sum()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = v1 + v2;
    //Console.WriteLine("O resultado da soma é " + result);
    Console.WriteLine($"O resultado da soma é {result}");
    //Console.WriteLine($"O resultado da soma é {v1 + v2}");
    //Console.WriteLine("O resultado da soma é " + (v1 + v2));
    Console.ReadKey();
    Menu();
}

void Subtraction()
{
    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = v1 - v2;
    Console.WriteLine($"O resultado da subtração é: {result}");
    
    Console.ReadKey();
    Menu();

}

void Division()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = v1 / v2;
    Console.WriteLine($"O resultado da divisão é {result}");

    Console.ReadKey();
    Menu();
}

void Multiplication()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    double result = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é: {result}");

    Console.ReadKey();
    Menu();
}
