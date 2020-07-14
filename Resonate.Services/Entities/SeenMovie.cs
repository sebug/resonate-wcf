using System;
using System.Runtime.Serialization;

namespace Resonate.Services.Entities
{
    [DataContract]
    public class SeenMovie
    {
        [DataMember]
        public string Name { get; set; }
    }
}
