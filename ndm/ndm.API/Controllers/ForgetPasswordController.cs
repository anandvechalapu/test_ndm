using Microsoft.AspNetCore.Mvc;
using NDM.DTO;
using NDM.Service;

namespace NDM.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgetPasswordController : ControllerBase
    {
        private readonly ForgetPasswordService _forgetPasswordService;
        public ForgetPasswordController(ForgetPasswordService forgetPasswordService)
        {
            _forgetPasswordService = forgetPasswordService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ForgetPasswordModel>> GetForgetPasswordDataByIdAsync(int id)
        {
            var forgetPasswordData = await _forgetPasswordService.GetForgetPasswordDataByIdAsync(id);
            if (forgetPasswordData == null)
            {
                return NotFound();
            }

            return Ok(forgetPasswordData);
        }

        [HttpPost]
        public async Task<ActionResult<ForgetPasswordModel>> CreateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel)
        {
            var id = await _forgetPasswordService.CreateForgetPasswordDataAsync(forgetPasswordModel);
            if (id == 0)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetForgetPasswordDataByIdAsync), new { id }, forgetPasswordModel);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel)
        {
            var id = await _forgetPasswordService.UpdateForgetPasswordDataAsync(forgetPasswordModel);
            if (id == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForgetPasswordDataAsync(int id)
        {
            var deletedId = await _forgetPasswordService.DeleteForgetPasswordDataAsync(id);
            if (deletedId == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}