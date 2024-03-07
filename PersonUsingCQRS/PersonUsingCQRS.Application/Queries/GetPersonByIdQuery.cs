using MediatR;
using PersonUsingCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUsingCQRS.Application.Queries
{
    public record GetPersonByIdQuery(Guid Id) : IRequest<PersonModel>;
}
