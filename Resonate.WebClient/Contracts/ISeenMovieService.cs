using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Resonate.Services.Entities;

namespace Resonate.Services.Contracts
{
    [ServiceContract]
    public interface ISeenMovieService
    {
        [OperationContract]
        Task<SeenMovie> Add(SeenMovie movie);

        [OperationContract]
        Task<List<SeenMovie>> GetAll();
    }
}
