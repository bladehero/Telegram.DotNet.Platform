using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class CallbackQueryHandler : TypedUpdateHandler<CallbackQuery>
{
    public override UpdateType Type => UpdateType.CallbackQuery;
}
