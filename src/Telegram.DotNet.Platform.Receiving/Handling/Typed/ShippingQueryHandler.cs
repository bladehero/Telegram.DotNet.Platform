using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.Payments;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class ShippingQueryHandler : TypedUpdateHandler<ShippingQuery>
{
    public override UpdateType Type => UpdateType.ShippingQuery;
}
