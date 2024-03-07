using FluentValidation;
using MediatR;
using PersonUsingCQRS.Application.Commands;
using PersonUsingCQRS.DataAccess;
using PersonUsingCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PersonUsingCQRS.Application.Handlers
{
    public class AddPersonHandler : IRequestHandler<AddPersonCommand, PersonModel>
    {
        private readonly IDataAccess data;

        public AddPersonHandler(IDataAccess data)
        {
            this.data = data;
        }
        public Task<PersonModel> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.AddPerson(new Guid(), request.GivenName, request.Surname, request.Gender));
        }
    }
}
