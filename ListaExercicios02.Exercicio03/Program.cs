using ExerciciosUtils;

namespace ListaExercicios02.Exercicio03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int letrasParaPular = 0;
            bool numeroValido = false;

            Console.WriteLine("------ Exercício 03 ------\n");

            string palavraValida = Utils.ValidarTexto(Utils.ObterTexto("palavra"), "palavra");

            Utils.ValidarNumero(ref letrasParaPular, ref numeroValido);

            char[] letra = palavraValida.ToCharArray();

            Utils.IncrementarLetras(letrasParaPular, palavraValida, letra);

            Console.WriteLine();
            Console.WriteLine(letra);
        }
    }
}