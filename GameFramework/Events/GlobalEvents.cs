namespace GameFramework.Events
{
    /// <summary>
    /// Events on global event bus should inherit from this class.
    /// Should be used for big events that are relevant to many systems (like player death, level completion, player or controller spawning, etc).
    /// </summary>
    public abstract class GlobalEvents
    {
        
    }
    
    /// <summary>
    /// Fired when the list of controllers in the game state changes (e.g., a new player joins, a player leaves, or a controller is destroyed).
    /// </summary>
    public sealed class OnControllersListChanges : GlobalEvents { }

    /// <summary>
    /// Fired when the list of actors in the game state changes (e.g., a new actor is spawned, an actor is destroyed, or an actor's state changes in a way that affects its presence in the list).
    /// </summary>
    public sealed class OnActorsListChanges : GlobalEvents { }
}