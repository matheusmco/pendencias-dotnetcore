using System;

namespace CommonLibrary.Libraries
{
    /// <summary>
    /// Classe genérica de tratamento de excessões
    /// </summary>
    public class ExceptionLibrary
    {

        /// <summary>
        /// Trata uma excessão não esperada
        /// </summary>
        /// <param name="metodo">Nome do método que originou a excessão</param>
        /// <param name="mensagemAmigavel">Mensagem que será mostrada ao usuário</param>
        /// <param name="excessao">Excessão criada pelo C#</param>
        public static object tratarLogException(string metodo, string mensagemAmigavel, Exception excessao)
        {
            return new
            {
                retorno = 10,
                mensagemRetorno = mensagemAmigavel,
                exception = excessao.ToString()
            };
        }

        /// <summary>
        /// Trata excessões de regra de negócio
        /// </summary>
        /// <param name="message">Mensagem amigável de regra de negócio</param>
        public static object tratarRNException(string message)
        {
            return new
            {
                retorno = 5,
                mensagemRetorno = message
            };
        }
    }
}