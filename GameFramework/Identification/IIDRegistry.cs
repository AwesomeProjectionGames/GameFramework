namespace GameFramework.Identification
{
    /// <summary>
    /// Interface for a database that can retrieve objects by their unique identifier (UUID).
    /// </summary>
    public interface IIDRegistry
    {
        /// <summary>
        /// Get an object by its unique identifier (UUID).
        /// </summary>
        /// <param name="id">The unique identifier of the object.</param>
        /// <typeparam name="T">The type of the object to retrieve, must implement IHaveUUID.</typeparam>
        /// <returns>The object with the specified UUID (of type T) if found; otherwise, null.</returns>
        T GetByID<T>(string id) where T : IHaveUUID;
    }
}