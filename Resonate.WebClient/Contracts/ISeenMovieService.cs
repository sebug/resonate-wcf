using System;
using System.Collections.Generic;
using System.ServiceModel;
using Resonate.WebClient.Entities;

namespace Resonate.WebClient.Contracts
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
