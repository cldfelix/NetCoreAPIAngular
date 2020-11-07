using System;


namespace NetCoreAPIAngular.Domain.Entities
{
    public class Lote
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public int Qtd { get; set; }
        public Evento Evento { get; set; }
        public int EventoId { get; set; }

    }
}