using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class EditedChannelPostHandler : TypedUpdateHandler<Message>
{
    protected override UpdateType Type => UpdateType.EditedChannelPost;
}
