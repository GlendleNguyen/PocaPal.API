using PocaPal.API.Repositories;

namespace PocaPal.API.Services
{
    public interface IPocaPalService
    {
        Task<string> RetrieveSomething();
    }

    public class PocaPalService : IPocaPalService
    {
        private readonly ILogger<PocaPalService> _logger;
        private readonly IPocaPalRepository _pocaPalRepository;

        public PocaPalService(ILogger<PocaPalService> logger, IPocaPalRepository pocaPalRepository)
        {
            _logger = logger;
            _pocaPalRepository = pocaPalRepository;
        }

        public async Task<string> RetrieveSomething()
        {
            string data = "";

            try
            {
                data = await _pocaPalRepository.RetrieveSomething();
                return data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured");
                throw;
            }
        }
    }
}
