using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class MyChatMemberHandler : TypedUpdateHandler<ChatMemberUpdated>
{
    public override UpdateType Type => UpdateType.MyChatMember;
}
