using Proekt_Prakt_Lab.Database;
using Proekt_Prakt_Lab.Interfaces.LoadInterfaces;
using Proekt_Prakt_Lab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proekt_Prakt_Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadsController : ControllerBase
    {
        private readonly ILogger<LoadsController> _logger;
        private readonly ILoadService _LoadService;
        private TeacherDbContext _teacherDbContext;
        public LoadsController(ILogger<LoadsController> logger, ILoadService loadService)
        {
            _logger = logger;
            _LoadService = loadService;
        }
        [HttpGet("GetLoads")]
        public async Task<IActionResult> GetLoadsAsync(CancellationToken cancellationToken = default)
        { 
            var loads = await _LoadService.GetLoadsAsync(cancellationToken);
            return Ok(loads);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoadAsync([FromRoute] int id, CancellationToken cancellationToken = default) { 
        var loads = await _LoadService.GetLoadAsync(id, cancellationToken); 
            return Ok(loads);
        }
        [HttpPost("AddNewLoad")]
        public async Task<IActionResult> AddNewLoadAsync(Load load,CancellationToken cancellationToken =default)
        {
            await _LoadService.AddNewLoadAsync(load, cancellationToken);    
            return Ok(load);
            
        }
        [HttpPut("EditLoad")]
        public async Task<IActionResult> UpdateLoadAsync(Load load, CancellationToken cancellationToken = default)
        {

            await _LoadService.UpdateLoadAsync(load, cancellationToken);
            return NoContent();
        }
    }
}
