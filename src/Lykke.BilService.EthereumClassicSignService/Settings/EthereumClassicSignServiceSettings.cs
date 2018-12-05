using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumClassicSignService.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class EthereumClassicSignServiceSettings : SignServiceSettings
    {
        public bool IsMainNet { get; set; }
    }
}