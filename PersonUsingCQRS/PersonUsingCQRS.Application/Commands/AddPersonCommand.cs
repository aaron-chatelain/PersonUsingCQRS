using MediatR;
using PersonUsingCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUsingCQRS.Application.Commands
{
    public record AddPersonCommand(
        Guid Id,
        string GivenName, 
        string? Surname, 
        Gender Gender,
        DateTime? BirthDate, 
        string BirthLocation, 
        DateTime? DeathDate, 
        string DeathLocation) : IRequest<PersonModel>;
}
