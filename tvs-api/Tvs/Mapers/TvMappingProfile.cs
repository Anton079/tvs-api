using AutoMapper;
using tvs_api.Tvs.Dtos;
using tvs_api.Tvs.Models;

namespace tvs_api.Tvs.Mapers
{
    public class TvMappingProfile:Profile
    {
        public TvMappingProfile()
        {
            CreateMap<TvRequest, Tv>();
            CreateMap<Tv, TvResponse>();
        }
    }
}
