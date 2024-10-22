Console.WriteLine(@"
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+
|               Boas-Vindas              |
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+
|       ▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄    ▄    █       |
|      █▀             ▀▀█▄   ▀         ▄ |
|    ▄▀                 ▀██   ▄▀▀▀▄▄  ▀  |
|  ▄█▀▄█▀▀▀▀▄     ▄▀▀█▄  ▀█▄  █▄   ▀█    |
| ▄█ ▄▀  ▄▄▄ █   ▄▀▄█▄ ▀█  █▄  ▀█    █   |
|▄█  █   ▀▀▀ █  ▄█ ▀▀▀  █   █▄  █    █   |
|██   ▀▄   ▄█▀   ▀▄▄▄▄▄█▀   ▀█  █▄   █   |
|██     ▀▀▀                  █ ▄█    █   |
|██                     █    ██▀    █▄   |
|██                     █    █       ▀▀█▄|
|██                    █     █       ▄▄██|
| ██                  ▄▀     █       ▀▀█▄|
| ▀█      █         ▄█▀      █       ▄▄██|
| ▄██▄     ▀▀▀▄▄▄▄▀▀         █       ▀▀█▄|
|  ▀▀▀▀                      █▄▄▄▄▄▄▄▄▄██|
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+");


Console.WriteLine($"Entre com o valor do sálario recebido: ");
float sálario = float.Parse (Console.ReadLine())!;

Console.WriteLine($"Entre com o valor do gasto: ");
float gasto = float.Parse (Console.ReadLine())!;

if(sálario >= gasto) 
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else 
{
    Console.WriteLine($"orçamento estourado");

}