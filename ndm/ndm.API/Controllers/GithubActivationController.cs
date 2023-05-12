namespace ndm.API
{
    using Microsoft.AspNetCore.Mvc;
    using ndm.DTO;
    using ndm.Service;

    [Route("api/[controller]")]
    [ApiController]
    public class GithubActivationController : ControllerBase
    {
        private readonly GithubActivationService _githubActivationService;

        public GithubActivationController(GithubActivationService githubActivationService)
        {
            _githubActivationService = githubActivationService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GithubActivationModel>> GetActivationDetailsAsync(int id)
        {
            var result = await _githubActivationService.GetActivationDetailsAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateActivationDetailsAsync(GithubActivationModel model)
        {
            if (await _githubActivationService.UpdateActivationDetailsAsync(model))
            {
                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivationDetailsAsync(int id)
        {
            if (await _githubActivationService.DeleteActivationDetailsAsync(id))
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}