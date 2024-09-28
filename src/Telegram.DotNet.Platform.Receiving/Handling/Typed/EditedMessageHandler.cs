using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling.Typed;

public abstract class EditedMessageHandler : TypedUpdateHandler<Message>
{
    public override UpdateType Type => UpdateType.EditedMessage;
}
