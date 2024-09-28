using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handlers.Typed;

public abstract class EditedMessageHandler : TypedUpdateHandler<Message>
{
    protected override UpdateType Type => UpdateType.EditedMessage;
}
