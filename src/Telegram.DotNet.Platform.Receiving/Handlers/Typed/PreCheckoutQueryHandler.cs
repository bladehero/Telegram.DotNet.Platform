using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.Payments;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class PreCheckoutQueryHandler : TypedUpdateHandler<PreCheckoutQuery>
{
    protected override UpdateType Type => UpdateType.PreCheckoutQuery;
}
