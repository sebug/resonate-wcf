using System;
using System.Collections.Generic;
using System.ServiceModel;
using Resonate.Services.Entities;

namespace Resonate.Services.Contracts
{
    [ServiceContract]
    public interface ISeenMovieService
    {
        [OperationContract]
        SeenMovie Add(SeenMovie movie);

        [OperationContract]
        List<SeenMovie> GetAll();
    }
}
