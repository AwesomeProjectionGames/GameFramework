namespace GameFramework.Saving
{
    public interface INetworkedSerializedObject : ISerializedObject
    {
        /// <summary>
        /// Should Serialize and Send the current state of the object to a specific client.
        /// Generally done with a network message (e.g., RPC) to the client identified by clientId.
        /// </summary>
        /// <param name="machine">The machine representing the client to send the state to.</param>
        void SendStateToClient(IMachine machine);
    }
}