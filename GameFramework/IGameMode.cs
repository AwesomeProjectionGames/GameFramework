namespace GameFramework
{
    public interface IGameMode
    {
        public IPawn DefaultPawnPrefab { get; }
        public IController DefaultControllerPrefab { get; }
        public IGameState CurrentGameState { get; }
        public ISpawnPoint GetSpawnPoint(IPawn pawn);
    }
}