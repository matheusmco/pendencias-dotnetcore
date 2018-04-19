using System.Linq;
using CommonLibrary.Helpers;
using WAPendencia.Models;

namespace WAPendencia
{
    public class PendenciaDalc
    {
        private readonly PendenciaContext _context;
        public int Gravar(PendenciaModel pendencia)
        {
            _context.Pendencias.Add(pendencia);
            _context.SaveChanges();
            return pendencia.PendenciaId;
        }

        public void Atualizar(PendenciaModel pendencia)
        {
            _context.Pendencias.Update(ConsistirExistenciaPendencia(pendencia.PendenciaId));
            _context.SaveChanges();
        }

        public PendenciaModel Consultar(int pendenciaId)
        {
            return _context.Pendencias.FirstOrDefault(p => p.PendenciaId == pendenciaId);
        }

        public object Listar()
        {
            return null;
        }

        public void Excluir(int pendenciaId)
        {
            _context.Pendencias.Remove(ConsistirExistenciaPendencia(pendenciaId));
            _context.SaveChanges();
        }

        private PendenciaModel ConsistirExistenciaPendencia(int pendenciaId)
        {
            PendenciaModel pendencia = Consultar(pendenciaId);
            if (pendencia == null)
            {
                throw new RegraNegocioException(5, "Não foi encontrada pendência com o id " + pendenciaId.ToString());
            }
            return pendencia;
        }
    }
}