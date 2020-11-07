using System.Collections.Generic;

namespace NetCoreAPIAngular.Domain.Entities
{
    public class Palestrante
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curriculo { get; set; }
        public string Imagem { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<RedeSocial> RedesSociais { get; set; }
        public List<PalestranteEvento> PaletranteEventos { get; set; }
    }
}