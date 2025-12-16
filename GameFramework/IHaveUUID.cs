namespace GameFramework
{
    /// <summary>
    /// Identifies an object with a unique UUID (Universally Unique Identifier).
    /// Each instance of the same object should have a unique, different UUID.
    /// </summary>
    public interface IHaveUUID
    {
        public string UUID { get; }
        public bool TryToChangeUUID(string newUUID);
    }
}