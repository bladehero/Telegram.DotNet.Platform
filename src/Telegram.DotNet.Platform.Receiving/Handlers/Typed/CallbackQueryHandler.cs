using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class CallbackQueryHandler : TypedUpdateHandler<CallbackQuery>
{
    protected override UpdateType Type => UpdateType.CallbackQuery;
}
