using Microsoft.AspNetCore.Mvc;
using PocaPal.API.Services;

namespace PocaPal.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PocaPalController : ControllerBase
    {
        private readonly IPocaPalService _pocaPalService;
        private readonly ILogger<PocaPalController> _logger;

        public PocaPalController(ILogger<PocaPalController> logger, IPocaPalService pocaPalService)
        {
            _logger = logger;
            _pocaPalService = pocaPalService;
        }

        [HttpGet("test")]
        public async Task<IActionResult> RetrieveSomething()
        {
            string data = "";

            try
            {
                data = await _pocaPalService.RetrieveSomething();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured");
            }

            return Ok(data);
        }
    }
}