using ExerciciosUtils;

namespace ListaExercicios02.Exercicio01
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("------ Exercicio 01 ------\n");
            Console.WriteLine($"\n{Utils.ConverterParaTitleCase(Utils.ValidarTexto(Utils.ObterTexto("frase para título"), "frase para título").ToLower())}");
        }
    }
}