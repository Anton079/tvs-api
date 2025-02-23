using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using tvs_api.Data;
using tvs_api.Tvs.Dtos;
using tvs_api.Tvs.Models;

namespace tvs_api.Tvs.Repository
{
    public class TvRepo : ITvRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public TvRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task <TvResponse> CreateTvAsync(TvRequest tvReq)
        {
            Tv tv= _mapper.Map<Tv>(tvReq);

            _appDbContext.Tvs.Add(tv);

            await _appDbContext.SaveChangesAsync();

            TvResponse response = _mapper.Map<TvResponse>(tv);

            return response;
        }

        public async Task<List<Tv>> GetTvsAsync()
        {
            return await _appDbContext.Tvs.ToListAsync();
        }
    }
}
