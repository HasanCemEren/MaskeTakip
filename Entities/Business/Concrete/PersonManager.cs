using Business.Abstract;
using Entities.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService 
    {
        public void ApplyForMask(Person person) { 
        
        }

        public List<Person> GetList() {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(123,"Hasan Cem", "Eren",2005))).Result.Body.TCKimlikDogrulaResult;
        }
    }
}
