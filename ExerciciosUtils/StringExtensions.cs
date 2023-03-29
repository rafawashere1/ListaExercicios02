namespace ExerciciosUtils
{
    public static class StringExtensions
    {
        public static string[] RemoverEspacosEntrePalavras(this string str)
        {
            string auxiliar = str.Replace(", ", " ").Replace(". ", " ").Replace(" .", " ").Replace(" ,", " ");
            string[] resultado = auxiliar.Split(' ', ',', '.');

            return resultado;
        }
    }
}