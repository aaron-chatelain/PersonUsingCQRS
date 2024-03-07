using PersonUsingCQRS.Models;
using System.Collections.Generic;

namespace PersonUsingCQRS.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel GetPersonById(Guid id);
        PersonModel AddPerson(Guid id, string givenName, string surName, Gender gender);
        PersonModel RecordBirth(Guid id, DateTime birthDate, string birthLocation);
    }
}