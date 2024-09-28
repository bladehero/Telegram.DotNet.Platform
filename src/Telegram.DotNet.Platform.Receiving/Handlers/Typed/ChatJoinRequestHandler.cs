using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class ChatJoinRequestHandler : TypedUpdateHandler<ChatJoinRequest>
{
    protected override UpdateType Type => UpdateType.ChatJoinRequest;
}
