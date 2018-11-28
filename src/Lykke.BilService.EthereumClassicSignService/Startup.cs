using JetBrains.Annotations;
using Lykke.BilService.EthereumClassicSignService.Modules;
using Lykke.BilService.EthereumClassicSignService.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilService.EthereumClassicSignService
{
    [UsedImplicitly]
    public class Startup : SignServiceStartupBase<EthereumClassicSignServiceSettings>
    {
        protected override string IntegrationName
            => "EthereumClassic";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<EthereumClassicSignServiceModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}