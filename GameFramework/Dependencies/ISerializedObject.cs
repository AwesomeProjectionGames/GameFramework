using GameFramework.Identification;

namespace GameFramework.Dependencies
{
    /// <summary>
    /// An interface representing an object that can be serialized and deserialized.
    /// We can expect the format to be a JSON string.
    /// This is useful for saving and loading game state and networking.
    /// Everything that change in for example an actor should be contained in the serialized state.
    /// </summary>
    public interface ISerializedObject
    {
        /// <summary>
        /// Compute Serialized state (preferably in JSON format for consistency) of the feature.
        /// </summary>
        public string Serialize();
        
        /// <summary>
        /// Apply the state to the feature / object.
        /// </summary>
        /// <param name="serializedData">The serialized state to apply (probably in JSON).</param>
        public void Deserialize(string serializedData);
    }
}