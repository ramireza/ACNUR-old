namespace Acnur.App.Interfaces
{
    using Acnur.App.Entities;
    using System.ServiceModel;

    [ServiceContract]
    public interface IFacadeSessionComponentsByModule : IFacadeGeneric<SessionComponentsByModule>
    {
        int GetIdPurchase(string strGUID);
    }
}
