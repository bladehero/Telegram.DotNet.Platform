using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class PollHandler : TypedUpdateHandler<Poll>
{
    public override UpdateType Type => UpdateType.Poll;
}
