using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class InlineQueryHandler : TypedUpdateHandler<InlineQuery>
{
    protected override UpdateType Type => UpdateType.InlineQuery;
}
