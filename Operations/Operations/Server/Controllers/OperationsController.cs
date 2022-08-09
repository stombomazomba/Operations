using Operations.Shared.Models;
using Operations.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Operations.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public OperationsController(ApplicationDBContext context)
        {
           this. _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var operationss = await _context.Operationss.ToListAsync();
            return Ok(operationss);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var operationss = await _context.Operationss.FirstOrDefaultAsync(a=>a.OperationID == id);
            return Ok(operationss);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Operationss operationss)
        {
            _context.Add(operationss);
            await _context.SaveChangesAsync();
            return Ok(operationss.OperationID);
        }
        [HttpPut]
        public async Task<IActionResult> Put(Operationss operationss)
        {
            _context.Entry(operationss).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var operationss = new Operationss {OperationID = id };
            _context.Remove(operationss);
            return NoContent();
        }
    }
}
