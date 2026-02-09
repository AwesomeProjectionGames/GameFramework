namespace GameFramework.Appearance
{
    /// <summary>
    /// Manages the visual representation and skin selection for an entity.
    /// </summary>
    public interface ISkinManager
    {
        /// <summary>
        /// Disables the visual renderers for this entity, making it invisible.
        /// </summary>
        /// <remarks>
        /// Useful for death states or invisibility effects without destroying the GameObject.
        /// </remarks>
        void Hide();

        /// <summary>
        /// Enables the visual renderers for this entity, making it visible again.
        /// </summary>
        void Show();
    }

    /// <summary>
    /// A skin that can change
    /// </summary>
    public interface ISwappableSkin : ISkinManager
    {
        /// <summary>
        /// Changes the currently active skin to the one at the specified index.
        /// If index is out of bound, do nothing.
        /// </summary>
        /// <param name="index">The index of the skin to equip (usually corresponding to a list of available skins or a SkinID).</param>
        void SetActiveSkin(int index);
    }
}