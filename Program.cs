using AtividadePOO;

namespace AtividadedePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Caminhao("Scania", 2026),
            new Carro("Lancer", 2010),
            new Moto("CB300", 2025)
        ];

        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
        }
    }
}