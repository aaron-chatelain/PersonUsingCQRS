using PersonUsingCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUsingCQRS.DataAccess
{
    public class PersonDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public PersonDataAccess()
        {
            people.Add(new PersonModel { Id = new Guid("72e60c90-d46f-4f84-b07a-1b154192b0f5"), GivenName = "Bob", Surname = "Dylan", Gender = Gender.Male });
            people.Add(new PersonModel { Id = new Guid("e6f7fcd5-003a-400e-b88f-0ec49b5e8e35"), GivenName = "Cher", Gender = Gender.Female });
        }

        public PersonModel AddPerson(Guid id, string givenName, string surName, Gender gender)
        {
            PersonModel person = new() {Id = id, GivenName = givenName, Surname = surName, Gender = gender};
            people.Add(person);
            return person;   
        }

        public PersonModel RecordBirth(Guid id, DateTime birthDate, string birthLocation)
        {
            PersonModel person = people.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                person.BirthDate = birthDate;
                person.BirthLocation = birthLocation;
            }
            return person;
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel GetPersonById(Guid id)
        {
            return people.FirstOrDefault(x => x.Id == id);
        }

    }
}
