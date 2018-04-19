using System;

namespace WAPendencia.Models
{
    public class PendenciaModel
    {
        public int PendenciaId { get; set; }
        public int ProjetoId { get; set; }
        public int ClienteId { get; set; }
        public int PrioridadeId { get; set; }
        public int StatusId { get; set; }
        public int TipoId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Solicitante { get; set; }
        public int RecursoId { get; set; }
        public int NumPendencia { get; set; }
        public DateTime DataOKCliente { get; set; }
        public DateTime DataIncl { get; set; }
        public int TabTipoArtefatoId { get; set; }
        public string MotivoUrgencia { get; set; }
        public string Titulo { get; set; }
        public int RecursoOriginalId { get; set; }
    }
}