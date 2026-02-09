#nullable enable

using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Defines game rules, flow, and win conditions.
    /// Scope / Persistence: Level-specific.
    /// Key Responsibilities:
    /// - Handles player spawning.
    /// - Determines match rules (time, score, win conditions).
    /// - Initializes GameState and PlayerController.
    /// - Manages transitions between match states.
    /// </summary>
    public interface IGameMode
    {
        public IPawn DefaultPawnPrefab { get; }
        public IController DefaultControllerPrefab { get; }
        public IGameState CurrentGameState { get; }
        public ISpawnPoint GetSpawnPoint(IPawn pawn);
        public IActor? Spawn(IActor prefab, bool destroyWithScene = true);
        public IActor? SpawnAtLocation(IActor prefab, Vector3 location, Quaternion rotation, bool destroyWithScene = true);
    }
}