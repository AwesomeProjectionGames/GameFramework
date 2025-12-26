using GameFramework.Identification;

namespace GameFramework.Saving
{
    /// <summary>
    /// An interface representing an object that can be serialized and deserialized.
    /// We can expect the format to be a JSON string.
    /// This is useful for saving and loading game state and networking.
    /// Everything that change in for example an actor should be contained in the serialized state.
    /// </summary>
    public interface ISerializedObject : IHaveUUID
    {
        public string Serialize();
        public void Deserialize(string serializedData);
    }
}