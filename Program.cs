namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----Bem vindo ao cronometro do C#-----");
            Console.WriteLine("");
            Console.WriteLine("S - Segundos => 10s = 10 segundos");
            Console.WriteLine("M - Minutos => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            //salvando o que o usuario digitar em uma variavel e convertendo a letra para minuscula caso digite maiuscula
            //Sem utilizar o ?? string.Empty o Console.ReadLine esta verificando como a string nula, entao dessa forma conseguimos tirar o warning que ele apresenta.

            //uma forma tbm a ser usada, porem o toLower não responde
            //string data = Console.ReadLine() ?? string.Empty.ToLower();

            // usando o comando a seguir no Visual Studio ele retira o warning e resolve o problema
            //#pragma warning disable CS8602

            //forma que o toLower esta respondendo porem com o warning, porem colocando os dois pontos de interogação ele acaba com o warning
            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);

            //outra forma de resolver sem precisar alterar as configurações do projeto.
            //string? data = Console.ReadLine()?.ToLower();
            //char type = char.Parse(data!.Substring(data.Length - 1, 1));

            //Toda metodo string tem um metodo a partir da variavel chamado SubString
            //pega uma parte da cadeia de caracteres, primeiro a parte inicial (qual caracter quer pegar), segundo a quantidade de caracteres que deseja pegar 
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            Console.WriteLine(type);

            // pegando o restante dos caracteres que vai ser o tempo
            int time = int.Parse(data.Substring(0, data.Length - 1));
            Console.WriteLine(time);

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                //saindo do programa sem chamar nenhuma função ou mensagem.
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);
            Start(time);
        }

        static void Start(int time)
        {
            //tempo atual
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                //usamos o thread para colocar uma pausa no programa, e ele vai lendo um por vez, igual o cronometro.
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(1500);
            Menu();
        }
    }
}


/*
Segue codigo sem comentarios, mais limpo para uma melhor vizualização.

namespace EditTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----Bem vindo ao cronometo C#-----");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("O que deseja fazer?");

            string? data = Console.ReadLine()?.ToLower();
            Console.WriteLine(data);

            char type = char.Parse(data!.Substring(data.Length - 1, 1));
            Console.WriteLine(type);

            int time = int.Parse(data.Substring(0, data.Length - 1));
            Console.WriteLine(time);

            int multiplier = 1;
            if (type == 'm')

                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometo finalizado");
            Thread.Sleep(1500);
            Menu();

        }
        static void PreStart(int time)
        {
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);
            Start(time);

        }
    }
}




*/