using DbOperationWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCoreApp.Controllers
{
    [Route("api/Currency")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCurrencyTypes()
        {
            //var result = _appDbContext.CurrencyTypes.ToList();
            //var result = (from currencies in _appDbContext.CurrencyTypes
            //             select currencies).ToList();

            //var result = await _appDbContext.CurrencyTypes.ToListAsync();
            var result = await (from currencies in _appDbContext.CurrencyTypes
                          select currencies).ToListAsync();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAllCurrencyTypesById([FromRoute]int Id)
        {

            //var result = await _appDbContext.CurrencyTypes.FindAsync(Id);
            var result = await (from currencies in _appDbContext.CurrencyTypes
                                where currencies.Id == Id select currencies).SingleOrDefaultAsync();
            return Ok(result);
        }

    }
}
