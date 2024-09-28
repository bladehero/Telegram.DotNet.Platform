using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.Payments;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class PreCheckoutQueryHandler : TypedUpdateHandler<PreCheckoutQuery>
{
    public override UpdateType Type => UpdateType.PreCheckoutQuery;
}
