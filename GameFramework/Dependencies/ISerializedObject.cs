#nullable enable

namespace GameFramework.Dependencies
{
    /// <summary>
    /// Contract for objects that can serialize and deserialize their state as binary bytes.
    /// Used for persistence, savegames, and full state network snapshots.
    /// </summary>
    public interface ISerializedObject
    {
        /// <summary>
        /// Computes the serialized state as raw bytes.
        /// </summary>
        byte[] Serialize();

        /// <summary>
        /// Applies serialized state from raw bytes.
        /// </summary>
        void Deserialize(byte[] data);
    }
}
