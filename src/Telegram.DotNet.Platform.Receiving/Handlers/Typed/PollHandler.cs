using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class PollHandler : TypedUpdateHandler<Poll>
{
    protected override UpdateType Type => UpdateType.Poll;
}
