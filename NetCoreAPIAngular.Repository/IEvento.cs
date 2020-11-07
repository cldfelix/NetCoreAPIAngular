using System.Threading.Tasks;
using NetCoreAPIAngular.Domain.Entities;

namespace NetCoreAPIAngular.Repository
{
    public interface IEvento: INetCoreAPIAngularRepository
    {
        Task<Evento[]>GetAllEventoAssyncByTema(string tema, bool includePalestrante);
        Task<Evento[]>GetAllEventoAssync( bool includePalestrante);
        Task<Evento>GetAllEventoAssyncById(int EventoId,  bool includePalestrante);
    }
}