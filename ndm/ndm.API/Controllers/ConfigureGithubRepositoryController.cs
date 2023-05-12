using ndm.Service;
using ndm.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ndm.API
{
    [ApiController]
    public class ConfigureGithubRepositoryController : ControllerBase
    {
        private readonly ConfigureGithubRepositoryService _configureGithubRepositoryService;
        private readonly ndmDTO _db;

        public ConfigureGithubRepositoryController(ConfigureGithubRepositoryService configureGithubRepositoryService, ndmDTO db)
        {
            _configureGithubRepositoryService = configureGithubRepositoryService;
            _db = db;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateAsync(ConfigureGithubModel model)
        {
            var result = await _configureGithubRepositoryService.CreateAsync(model);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConfigureGithubModel>> ReadAsync(int id)
        {
            var result = await _configureGithubRepositoryService.ReadAsync(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateAsync(ConfigureGithubModel model)
        {
            var result = await _configureGithubRepositoryService.UpdateAsync(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteAsync(int id)
        {
            var result = await _configureGithubRepositoryService.DeleteAsync(id);
            return Ok(result);
        }
    }
}