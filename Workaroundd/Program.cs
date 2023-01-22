// Entities.Concrete altındaki sınıfları kullanabilmek için using Entities.Concrete yazılır
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaroundd
{
    class Program
    {
        static void Main(string[] args) 
        {
            Person person1 = new Person();
            person1.FirstName = "BARAN";
            person1.LastName = "MENGÜCEK";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 54217165854;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

    }

}