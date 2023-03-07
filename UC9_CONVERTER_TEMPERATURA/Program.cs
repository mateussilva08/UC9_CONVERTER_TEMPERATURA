double celsius = 0;
double fahrenheit = 32;
int opcao = 0;
string continuar = "sim";

while (continuar == "sim" || continuar == "SIM") {

    Console.WriteLine("Pressione 1 para converter celsius para fahrenheit");
    Console.WriteLine("Pressione 2 para converter fahrenheit para celsius");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe a temperatura:");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é " + fahrenheit);
            break;

        case 2:
            Console.WriteLine("Informe a temperatura:");
            fahrenheit = int.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é " + celsius);
            break;

        default:
            break;
    }

    Console.WriteLine("Deseja converter outra temperatura");
    continuar = Console.ReadLine();
}