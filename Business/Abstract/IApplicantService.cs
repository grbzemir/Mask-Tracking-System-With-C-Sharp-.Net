using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //İnterfacelerde sadece imza metotlar olur.
        //İnterface arayüz görevi görür!

        void ApllyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);
        

    }
}
