namespace Week02Queue;

internal record QueueItem
{
    internal required string Data { get; init; }
    internal required bool IsVip { get; init; }
}