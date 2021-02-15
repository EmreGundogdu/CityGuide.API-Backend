using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        DataContext _contex;
        public ValuesController(DataContext context)
        {
            _contex = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetValues()
        {
            var values = await _contex.Values.ToListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var value = await _contex.Values.FirstOrDefaultAsync(v=>v.Id == id);
            return Ok(value);
        }
        [HttpPost]
        public void Post([FromBody]string value)
        {            
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] string value)
        {
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
