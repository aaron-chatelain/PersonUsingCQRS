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
    public class GetAllPeopleHandler : IRequestHandler<GetAllPeopleQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;

        public GetAllPeopleHandler(IDataAccess data)
        {
            this._data = data;
        }
        public Task<List<PersonModel>> Handle(GetAllPeopleQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}
