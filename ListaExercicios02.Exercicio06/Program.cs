using System.Diagnostics;

namespace ListaExercicios02.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string municipios = File.ReadAllText(@"C:\Users\raffa\OneDrive\Área de Trabalho\Cidades.csv");

            string[] auxiliar = municipios.Split(';', '\r', '\n');
            string[] posicao = new string[auxiliar.Length];
            string[] codigo = new string[auxiliar.Length];
            string[] cidade = new string[auxiliar.Length];
            string[] estado = new string[auxiliar.Length];
            string[] populacao = new string[auxiliar.Length];

            for (int i = 0; i < auxiliar.Length; i += 5)
            {
                posicao[i] = auxiliar[i];
                codigo[i] = auxiliar[i+1];
                cidade[i] = auxiliar[i+2];
                estado[i] = auxiliar[i+3];
                populacao[i] = auxiliar[i+4];

                Console.WriteLine(posicao[i] + codigo[i] + cidade[i] + estado[i] + populacao[i]);
            }
        }
    }
}