using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class InlineQueryHandler : TypedUpdateHandler<InlineQuery>
{
    public override UpdateType Type => UpdateType.InlineQuery;
}
