using Business.Abstract;
using Entities.Concrete;
using MernisServiceReferance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {

        //Encapsulation
        public void ApllyForMask(Person person)
        {
           
        
        }

        public List<Person> GetList()
        {
              return null;

           
        }

        public bool CheckPerson(Person person)
        {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                
              return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                  (new TCKimlikNoDogrulaRequestBody(person.NationalId,person.FirstName,person.LastName,person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
               
                  
            
           
        }
    }
}
