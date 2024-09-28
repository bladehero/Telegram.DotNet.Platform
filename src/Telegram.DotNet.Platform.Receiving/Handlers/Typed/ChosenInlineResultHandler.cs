using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class ChosenInlineResultHandler : TypedUpdateHandler<ChosenInlineResult>
{
    protected override UpdateType Type => UpdateType.ChosenInlineResult;
}
