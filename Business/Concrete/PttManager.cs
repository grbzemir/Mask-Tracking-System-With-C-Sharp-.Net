using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        //Dependency Injection -- sınıfı veya bir nesneyi bağımsız hale getirme
        private IApplicantService _applicantService;

        //Constructor Injection -- sınıfın constructor'ı üzerinden bağımlılığı enjekte etme
        public PttManager(IApplicantService applicantService) // Constructor
        {
            _applicantService = applicantService; // _applicantService nesnesi oluşturuldu.
        }
        public void GiveMask(Person person) 
        {
            if(_applicantService.CheckPerson(person))
            {

                Console.WriteLine(person.FirstName + " için maske verildi.");
            }

            else
            {

                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
            

           
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
