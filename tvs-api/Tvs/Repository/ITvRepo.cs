using tvs_api.Tvs.Models;

namespace tvs_api.Tvs.Repository
{
    public interface ITvRepo
    {
        Task<List<Tv>> GetTvsAsync();
    }
}
