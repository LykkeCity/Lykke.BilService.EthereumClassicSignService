using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumClassicSignService.Settings;
using Lykke.Quintessence.Core.DependencyInjection;
using Lykke.Quintessence.Settings;
using Lykke.SettingsReader;

namespace Lykke.BilService.EthereumClassicSignService.Modules
{
    [UsedImplicitly]
    public class EthereumClassicSignServiceModule : Module
    {
        private readonly IReloadingManager<AppSettings<EthereumClassicSignServiceSettings>> _appSettings;

        public EthereumClassicSignServiceModule(
            IReloadingManager<AppSettings<EthereumClassicSignServiceSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            var chainId = _appSettings.CurrentValue.SignService.IsMainNet ? 61 : 62;

            builder
                .UseChainId(chainId);
        }
    }
}