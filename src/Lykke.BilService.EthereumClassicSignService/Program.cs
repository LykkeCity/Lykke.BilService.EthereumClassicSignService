using System.Threading.Tasks;
using Lykke.BilService.EthereumClassicSignService.Settings;
using Lykke.Quintessence;

namespace Lykke.BilService.EthereumClassicSignService
{
    internal static class Program
    {
        #if DEBUG
        
        private const bool IsDebug = true;
        
        #else

        private const bool IsDebug = false;

        #endif
        
        private static Task Main()
        {
            return SignServiceStarter
                .StartAsync<Startup, EthereumClassicSignServiceSettings>(IsDebug);
        }
    }
}