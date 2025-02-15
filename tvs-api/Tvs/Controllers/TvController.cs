using Microsoft.AspNetCore.Mvc;
using tvs_api.Tvs.Models;
using tvs_api.Tvs.Repository;

namespace tvs_api.Tvs.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TvController : ControllerBase
    {
        private ITvRepo _tvRepo;

        public TvController(ITvRepo tvRepo)
        {
            _tvRepo = tvRepo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Tv>>> GetTvAsync()
        {
            var tv = await _tvRepo.GetTvsAsync();

            return Ok(tv);
        }
    }
}
