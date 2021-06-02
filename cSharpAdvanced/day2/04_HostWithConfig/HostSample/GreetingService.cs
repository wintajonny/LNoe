using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HostSample
{
    public record GreetingServiceOptions
    {
        public string? From { get; set; }
    }

    public class GreetingService : IGreetingService
    {
        private readonly ILogger _logger;
        private string _from;
        public GreetingService(ILogger<GreetingService> logger, IOptions<GreetingServiceOptions> options)
        {
            _logger = logger;
            _from = options.Value?.From ?? "unknown";
            // Console.WriteLine("GreetingService ctor");
            _logger.LogDebug("GreetingService ctor");
        }

        public string Greet(string name) => $"Hello, {name} from {_from}";
    }
}
