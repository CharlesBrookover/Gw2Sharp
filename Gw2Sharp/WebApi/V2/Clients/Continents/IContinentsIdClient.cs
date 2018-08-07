namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 continents id endpoint.
    /// </summary>
    public interface IContinentsIdClient : IClient
    {
        /// <summary>
        /// The continent id.
        /// </summary>
        int ContinentId { get; }

        /// <summary>
        /// Gets the continent floors.
        /// </summary>
        IContinentsFloorsClient Floors { get; }
    }
}
