using System;

namespace GameFramework.Identification
{
    /// <summary>
    /// Identifies an object with a unique UUID (Universally Unique Identifier).
    /// Each instance of the same object should have a unique, different UUID.
    /// In context of actors, this should be used to identify each instance of an actor in the game world (with the GameState for example).
    /// It should be SYNCED OVER THE NETWORK to identify objects between server and clients.
    /// It also SHOULD BE PERSISTENT between game sessions, to identify the same object when LOADING a saved game.
    /// Every object implementing this interface should be retreivable by its UUID through a central registry (like a GameState or any IIDDatabase).
    /// </summary>
    public interface IHaveUUID : IEquatable<IHaveUUID>
    {
        public string UUID { get; }
        
        /// <summary>
        /// If's it's necessary to change the UUID (for example when duplicating an object)
        /// this method can be used to attempt to set a new UUID.
        /// </summary>
        /// <param name="newUUID"></param>
        /// <returns>>Returns true if the UUID was successfully changed, false otherwise.</returns>
        public bool TryToChangeUUID(string newUUID);
    }
}