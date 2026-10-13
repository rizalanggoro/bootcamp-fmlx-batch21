namespace Week03Queue;

internal record QueueItem
{
    internal required string Data { get; init; }
    internal required int Priority { get; init; }
}
