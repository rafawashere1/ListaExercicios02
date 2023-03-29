using ExerciciosUtils;

namespace ListaExercicios02.Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Exercicio 02 ------\n");
            Console.WriteLine($"\n>> O número de palavras na frase é: {Utils.ContarPalavras(Utils.ValidarTexto(Utils.ObterTexto("frase"), "frase").RemoverEspacosEntrePalavras())}");
        }
    }
}