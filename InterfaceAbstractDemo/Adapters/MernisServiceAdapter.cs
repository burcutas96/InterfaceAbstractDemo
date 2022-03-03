using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using ServiceReference1;


namespace InterfaceAbstractDemo.Adapters
{
    internal class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
        }
    }
}
