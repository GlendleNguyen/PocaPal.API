namespace PocaPal.API.Repositories
{
    public interface IPocaPalRepository
    {
        public Task<string> RetrieveSomething();
    }

    public class PocaPalRepository : IPocaPalRepository
    {
        private readonly ILogger<PocaPalRepository> _logger;

        public PocaPalRepository(ILogger<PocaPalRepository> logger)
        {
            _logger = logger;
        }

        public async Task<string> RetrieveSomething()
        {
            try
            {
                await Task.Delay(1000);

                string data = "HELLO WORLD";

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
