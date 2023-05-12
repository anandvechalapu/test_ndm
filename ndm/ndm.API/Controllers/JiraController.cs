using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ndm.DTO;
using ndm.Service;

namespace ndm.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraController : ControllerBase
    {
        private readonly IJiraService _jiraService;

        public JiraController(IJiraService jiraService)
        {
            _jiraService = jiraService;
        }

        [HttpPost]
        public async Task<IActionResult> ConfigureJira([FromBody] JiraConfiguration jiraConfiguration)
        {
            var response = await _jiraService.ConfigureJira(jiraConfiguration);

            return Ok(response);
        }
    }
}