using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;

namespace WebApp.Controllers
{
    [Route("api/Currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly DBApp _DBApp;  
        public CurrencyController(DBApp DBApp)
        {
            _DBApp = DBApp;
        }
        // GET: api/Currency
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Currency>>> GetAllCurrencies()
        //{
        //    return  _DBApp.Currencies.ToList();
        //}
        // GET: api/Currency/5
        //[HttpGet("{id}")]
        [HttpGet("")]
        public IActionResult GetAllCurrency()
        {
            //var currency = await _DBApp.Currencies.FindAsync(id);
            //if (currency == null)
            //{
            //    return NotFound();
            //}
            //return currency;

            var result = (from Currencies in _DBApp.Currencies
                         select Currencies).ToList();
                  return Ok(result);     
        }
    }
}
