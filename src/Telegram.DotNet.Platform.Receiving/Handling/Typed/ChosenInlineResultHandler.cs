using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class ChosenInlineResultHandler : TypedUpdateHandler<ChosenInlineResult>
{
    public override UpdateType Type => UpdateType.ChosenInlineResult;
}
