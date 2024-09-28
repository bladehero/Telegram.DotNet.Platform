using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class MyChatMemberHandler : TypedUpdateHandler<ChatMemberUpdated>
{
    protected override UpdateType Type => UpdateType.MyChatMember;
}
