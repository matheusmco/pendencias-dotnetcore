using CommonLibrary.Libraries;
using WAPendencia.Models;

namespace WAPendencia
{
    public class PendenciaBo
    {
        PendenciaDalc dalc = new PendenciaDalc();
        public PendenciaModel Gravar(PendenciaModel pendencia)
        {
            int pendenciaId = 0;

            if (IntegerLibrary.ConsistirInteiroZero(pendencia.PendenciaId))
            {
                dalc.Atualizar(pendencia);
                pendenciaId = pendencia.PendenciaId;
            }

            pendenciaId = dalc.Gravar(pendencia);
            return Consultar(pendenciaId);
        }

        public PendenciaModel Consultar(int pendenciaId)
        {
            return dalc.Consultar(pendenciaId);
        }

        public object Listar()
        {
            return dalc.Listar();
        }

        public void Excluir(int pendenciaId)
        {
            dalc.Excluir(pendenciaId);
        }
    }
}