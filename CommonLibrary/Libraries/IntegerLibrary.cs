using System;

namespace CommonLibrary.Libraries
{
    /// <summary>
    /// Classe genérica de manipulação de inteiros
    /// </summary>
    public class IntegerLibrary
    {

        /// <summary>
        /// Consistir o valor de um inteiro em 0
        /// </summary>
        /// <param name="variavel">Variável que será consistida</param>
        public static bool ConsistirInteiroZero(int variavel)
        {
            if (variavel == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Consistir o valor de um inteiro em 0 ou nulo
        /// </summary>
        /// <param name="variavel">Variável que será consistida</param>
        public static bool ConsistirInteiroZero(int? variavel)
        {
            if (variavel == 0 || variavel == null)
            {
                return false;
            }
            return true;
        }
    }
}