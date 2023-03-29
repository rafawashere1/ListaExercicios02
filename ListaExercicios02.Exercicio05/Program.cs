using ExerciciosUtils;

namespace ListaExercicios02.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorCaracteres = 0;

            Console.WriteLine("------ Exercicio 05 ------\n");

            string? frase = Utils.ValidarTexto(Utils.ObterTexto("frase"), "frase");

            Console.WriteLine($"\n>> A frase em letras maiúsculas é: {frase.ToUpper()}\n");
            Console.WriteLine($">> A frase em letras minúsculas é: {frase.ToLower()}\n");
            Console.WriteLine($">> A quantidade de caracteres da frase é: {Utils.ContadorDeCaracteres(contadorCaracteres, frase)}\n");

            Utils.ValidarArgumentOutOfRangeException(frase);
        }
    }
}