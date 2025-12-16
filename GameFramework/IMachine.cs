namespace GameFramework
{
    /// <summary>
    /// An interface representing a machine in the game framework.
    /// Typically used for networks to identify machines / devices / clients of the game.
    /// One running instance of the game on a device is considered a machine.
    /// </summary>
    public interface IMachine
    {
        /// <summary>
        /// Get the client ID of the machine.
        /// Typically unique in one multiplayer game session to identify the device.
        /// </summary>
        ulong ClientId { get; }
    }
}