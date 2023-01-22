using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // interfaceler belli method imzalarını barındırırlar ve birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar

    //Applicant=Başvuran
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);

    }
}
