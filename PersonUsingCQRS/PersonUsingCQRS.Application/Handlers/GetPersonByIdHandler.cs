using MediatR;
using PersonUsingCQRS.Application.Queries;
using PersonUsingCQRS.DataAccess;
using PersonUsingCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUsingCQRS.Application.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess data;

        public GetPersonByIdHandler(IDataAccess data)
        {
            this.data = data;
        }
        public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.GetPersonById(request.Id));
        }
    }
}
