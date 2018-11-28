using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumClassicSignService.Settings;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumClassicSignService.Modules
{
    [UsedImplicitly]
    public class EthereumClassicSignServiceModule : Module
    {
        private readonly AppSettings<EthereumClassicSignServiceSettings> _appSettings;

        public EthereumClassicSignServiceModule(
            AppSettings<EthereumClassicSignServiceSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            
        }
    }
}