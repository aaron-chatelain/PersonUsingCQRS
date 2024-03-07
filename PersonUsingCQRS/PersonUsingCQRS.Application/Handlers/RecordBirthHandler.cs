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
    public class RecordBirthHandler : IRequestHandler<RecordBirthCommand, PersonModel>
    {
        private readonly IDataAccess data;

        public RecordBirthHandler(IDataAccess data)
        {
            this.data = data;
        }
        public Task<PersonModel> Handle(RecordBirthCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.RecordBirth(request.Id, request.BirthDate, request.BirthLocation));
        }
    }
}
