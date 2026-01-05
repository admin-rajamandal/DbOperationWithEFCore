using DbOperationWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DbOperationWithEFCoreApp.Controllers
{
    [Route("api/Language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public LanguageController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLanguage()
        {
            //var result = _appDbContext.Languages.ToList();
            //var result = (from language in _appDbContext.Languages
            //             select language).ToList();

            //var result = await _appDbContext.Languages.ToListAsync();
            var result = await (from language in _appDbContext.Languages
                         select language).ToListAsync();

            return Ok(result);
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAllLanguageById([FromRoute] int Id)
        {
            //var result = await _appDbContext.Languages.FindAsync(Id);
            var result = await (from Language in _appDbContext.Languages
                                where Language.Id==Id
                                select Language).SingleOrDefaultAsync();

            return Ok(result);
        }
    }
}
