using Microsoft.AspNetCore.Mvc;
using Proekt_Prakt_Lab.Filters;
using Proekt_Prakt_Lab.Interfaces.DisciplineInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proekt_Prakt_Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinesController : ControllerBase
    {
        private readonly ILogger<DisciplinesController> _logger;
        private readonly IDisciplineService _disciplineService;

        public DisciplinesController(ILogger<DisciplinesController> logger, IDisciplineService disciplineService)
        {
            _logger = logger;
            _disciplineService = disciplineService;
        }

        [HttpPost("GetListOfDisciplinesByTeacher")]
        public async Task<IActionResult> GetDisciplinesByTeacherAsync(DisciplineTeacherFilter filter, CancellationToken cancellationToken = default)
        {
            var disciplines_k = await _disciplineService.GetDisciplinesByTeacherAsync(filter, cancellationToken);
            return Ok(disciplines_k);
        }
        [HttpPost("GetListOfDisciplinesByLoad")]
        public async Task<IActionResult> GetDisciplinesByLoadAsync(DisciplineLoadFilter filter, CancellationToken cancellationToken = default)
        {
            var disciplines_l = await _disciplineService.GetDisciplinesByLoadAsync(filter, cancellationToken);
            return Ok(disciplines_l);
        }
    }
}
