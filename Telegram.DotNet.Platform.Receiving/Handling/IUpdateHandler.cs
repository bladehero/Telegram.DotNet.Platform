using Telegram.Bot.Types;

namespace Telegram.DotNet.Platform.Receiving.Handling;

public interface IUpdateHandler
{
    Task HandleAsync(Update update, CancellationToken token = default);
}
