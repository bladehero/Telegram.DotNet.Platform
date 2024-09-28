using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.Payments;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class ShippingQueryHandler : TypedUpdateHandler<ShippingQuery>
{
    protected override UpdateType Type => UpdateType.ShippingQuery;
}
