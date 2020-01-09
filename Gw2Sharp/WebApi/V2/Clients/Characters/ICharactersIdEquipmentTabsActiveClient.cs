using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 characters id equipment tabs active endpoint.
    /// </summary>
    public interface ICharactersIdEquipmentTabsActiveClient :
        IAuthenticatedClient,
        IBlobClient<CharacterEquipmentTabSlot>
    { }
}
