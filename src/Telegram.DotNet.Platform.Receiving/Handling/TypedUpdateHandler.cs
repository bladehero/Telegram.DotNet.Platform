using System.Reflection;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.DotNet.Platform.Receiving.Handling;

public abstract class UpdateHandler : IUpdateHandler
{
    internal static readonly Dictionary<UpdateType, PropertyInfo> UpdateProperties = typeof(Update)
        .GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty)
        .ToDictionary(x => Enum.Parse<UpdateType>(x.Name), x => x);

    public abstract Task HandleAsync(Update update, CancellationToken token = default);
}

public abstract class TypedUpdateHandler<T> : UpdateHandler
    where T : class
{
    public abstract UpdateType Type { get; }

    public sealed override Task HandleAsync(Update update, CancellationToken token = default)
    {
        if (Type != update.Type)
        {
            throw new InvalidOperationException($"Update of type `{update.Type}` cannot be handled by `{GetType()}`");
        }

        var updateData = (T)UpdateProperties[update.Type].GetValue(update)!;
        return HandleAsync(update.Id, updateData, token);
    }

    protected abstract Task HandleAsync(int updateId, T updateData, CancellationToken token = default);
}
