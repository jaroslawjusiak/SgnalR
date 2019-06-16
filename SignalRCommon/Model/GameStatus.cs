namespace SignalR.Common.Model
{
    public enum GameStatus
    {
        WaitingForPlayers = 0,
        ReadyToStart = 1,
        OnGoing = 2,
        Interrupted = 3,
        Finished = 4,
        Archived = 5
    }
}