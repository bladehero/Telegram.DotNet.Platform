using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class ChatJoinRequestHandler : TypedUpdateHandler<ChatJoinRequest>
{
    public override UpdateType Type => UpdateType.ChatJoinRequest;
}
