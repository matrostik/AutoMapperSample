using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample
{
    class Program
    {
        static void Main(string[] args)
        {

            MappingModule mm = new MappingModule();
            mm.RegisterModule();


            var list = new List<ContactDTO>
            {
                new ContactDTO {Age = 5, FirstName = "FirstName1", LastName = "LastName1", Mobile = "324234523"},
                new ContactDTO {Age = 5, FirstName = "FirstName2", LastName = "LastName2", Mobile = "980890898"},
                new ContactDTO {Age = 5, FirstName = "FirstName3", LastName = "LastName3", Mobile = "324545423"}
            };

            var mappedList = list.Select(ContactMapper.MapToContact);
            foreach (var item in mappedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
