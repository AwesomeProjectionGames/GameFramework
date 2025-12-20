#nullable enable

namespace GameFramework
{
    /// <summary>
    /// Interface for a spectate controller.
    /// There is generally one spectate controller per scene.
    /// And there is generally only one spectate controller if cameras and informations spectated are for one complete screen.
    /// There could be multiple spectate controllers if we are in split screen mode or if we want to spectate different things on different screens at once.
    /// </summary>
    public interface ISpectateController : ICameraController
    {
        /// <summary>
        /// Get the current spectate object that is being spectated by this controller.
        /// </summary>
        ISpectate? CurrentSpectate { get; }

        /// <summary>
        /// Start spectating a specific ISpectate object.
        /// </summary>
        /// <param name="spectate">Spectate object to start spectating.</param>
        void Spectate(ISpectate spectate);

        /// <summary>
        /// Signal that ISpectate can be stopped.
        /// </summary>
        void StopSpectating();
    }
}