using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class PollAnswerHandler : TypedUpdateHandler<PollAnswer>
{
    protected override UpdateType Type => UpdateType.PollAnswer;
}
