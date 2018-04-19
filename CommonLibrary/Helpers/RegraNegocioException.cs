using System;

namespace CommonLibrary.Helpers
{
    /// <summary>
    /// Exception que indica que alguma regra de negócio não está válida
    /// </summary>
    public class RegraNegocioException : ApplicationException
    {
        public int Code { get; set; }

        public RegraNegocioException()
        {
        }

        /// <summary>
        /// Utilize esse construtor para criar uma exceção de validação de REGRA DE NEGÓCIO
        /// </summary>
        /// <param name="codigoRetorno">Informe o código de retorno para a aplicação entender que houve problema de validação de RN</param>
        /// <param name="mensagemRetorno">Informar a mensagem de consistência</param>
        public RegraNegocioException(int codigoRetorno = 5, string mensagemRetorno = "")
            : base(mensagemRetorno)
        {
            Code = codigoRetorno;
        }
    }
}