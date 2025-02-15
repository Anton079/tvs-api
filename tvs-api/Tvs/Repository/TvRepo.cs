using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using tvs_api.Data;
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

        public async Task<List<Tv>> GetTvsAsync()
        {
            return await _appDbContext.Tvs.ToListAsync();
        }
    }
}
