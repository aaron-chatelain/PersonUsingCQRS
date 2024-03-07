using MediatR;
using PersonUsingCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUsingCQRS.Application.Commands
{
    public record RecordBirthCommand(Guid Id, DateTime? BirthDate, string BirthLocation) : IRequest<PersonModel>;
}
