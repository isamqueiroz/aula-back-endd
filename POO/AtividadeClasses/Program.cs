
using AtividadeClasses.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao portal dos veiculos");
Console.WriteLine("");


  Console.WriteLine("Digite a marca do carro: ");
   string marca = Console.ReadLine();

   Console.WriteLine($"Digite o modelo do {marca} :");
   string modelo = Console.ReadLine();

   Console.WriteLine($"Digite a cor do {modelo}: ");
   string cor = Console.ReadLine();

   Console.WriteLine($"Digite a potencia do {modelo}: ");
   string potencia = Console.ReadLine();

   Console.WriteLine($"Quantas portas tem o {modelo}: ");
   int portas = int.Parse(Console.ReadLine());
   
   
   
   
        

Veiculo carro = new Veiculo();


carro.marca = marca;
carro.modelo = modelo;
carro.cor = cor;
carro.potencia = potencia;
carro.qtdPortas = portas;

Console.WriteLine($"marca do carro: {carro.marca}");
Console.WriteLine($"modelo do {carro.marca}: {carro.modelo}");
Console.WriteLine($"cor do {carro.marca}: {carro.cor}");
Console.WriteLine($"potencia do {carro.marca}: {carro.potencia}");
Console.WriteLine($"portas  do {carro.marca}: {carro.qtdPortas}");

carro.acelerar("Vrummmm");
carro.ligar("Rowh Rowh");
carro.Desligar("RUWNH");
carro.Freiar("RIHHHHHHNM");