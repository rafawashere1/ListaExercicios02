using System.Globalization;

namespace ExerciciosUtils
{
    public static class Utils
    {
        public static string ConverterParaTitleCase(string texto)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string textoToTitleCase = textInfo.ToTitleCase(texto);

            return textoToTitleCase;
        }
        public static int ContarPalavras(string[] fraseCortada)
        {
            int numeroPalavras = 0;

            for (int i = 0; i < fraseCortada.Length; i++)
            {
                numeroPalavras++;
            }

            return numeroPalavras;
        }
        public static string ValidarTexto(string? texto, string mensagem)
        {
            while (string.IsNullOrEmpty(texto))
            {
                FormatarMensagem($"\n>> {mensagem[0].ToString().ToUpper()}{mensagem[1..]} não pode ser vazia", "ERRO");
                Console.Write($"\n>> Digite outra {mensagem}: ");
                texto = Console.ReadLine();
            }

            return texto;
        }
        public static string? ObterTexto(string mensagem)
        {
            Console.Write($">> Digite uma {mensagem}: ");
            string? texto = Console.ReadLine();
            return texto;
        }
        public static void ValidarNumero(ref int letrasParaPular, ref bool numeroValido)
        {
            while (!numeroValido)
            {
                try
                {
                    Console.Write("\n>> Digite a quantidade de letras para pular: ");
                    letrasParaPular = Convert.ToInt32(Console.ReadLine());

                    if (letrasParaPular < 0)
                    {
                        FormatarMensagem("\n>> A quantidade não pode ser um número negativo", "ERRO");
                        continue;
                    }

                    numeroValido = true;
                }

                catch (FormatException)
                {
                    FormatarMensagem("\n>> A quantidade não pode ser vazia e deve ser um número", "ERRO");
                    continue;
                }
            }
        }
        public static void IncrementarLetras(int letrasParaPular, string palavraValida, char[] letra)
        {
            for (int i = 0; i < palavraValida.Length; i++)
            {
                for (int j = 0; j < letrasParaPular; j++)
                {
                    letra[i]++;
                }
            }
        }
        public static void FormatarMensagem(string mensagem, string tipoDeMensagem)
        {
            if (tipoDeMensagem == "ERRO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensagem);
                Console.ResetColor();
            }

            else if (tipoDeMensagem == "ERRO SEM READKEY")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensagem);
                Console.ReadKey();
                Console.ResetColor();
            }

            else if (tipoDeMensagem == "NORMAL")
            {
                Console.WriteLine(mensagem);
                Console.ReadKey();
            }
        }
        public static long EncontrarMaiorProduto(char[] sequenciaChar, long maiorProduto)
        {
            for (int i = 0; i < sequenciaChar.Length - 4; i++)
            {
                long multiplicacao = 1;

                for (int j = i; j < i + 5; j++)
                {
                    multiplicacao *= Convert.ToInt64(sequenciaChar[j].ToString());
                }

                if (maiorProduto < multiplicacao)
                {
                    maiorProduto = multiplicacao;
                }
            }

            return maiorProduto;
        }
        public static int ContadorDeCaracteres(int contadorCaracteres, string? frase)
        {
            foreach (char caracter in frase)
            {
                contadorCaracteres++;
            }

            return contadorCaracteres;
        }
        public static void ValidarArgumentOutOfRangeException(string frase)
        {
            try
            {
                Console.WriteLine($">> A primeira palavra da frase é: {frase[0..frase.IndexOf(' ')]}\n");
                Console.WriteLine($">> A última palavra da frase é: {frase[(frase.LastIndexOf(' ') + 1)..]}\n");
            }

            catch (ArgumentOutOfRangeException)
            {
                Utils.FormatarMensagem($">> Não foi possível obter a primeira e a última palavra da frase.\n", "ERRO");
                Utils.FormatarMensagem($">> Reinicie o programa e tente reescrever sua frase com mais de uma palavra.", "ERRO");
            }
        }
    }
}