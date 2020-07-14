using System;
using System.Runtime.Serialization;

namespace Resonate.WebClient.Entities
{
    [DataContract]
    public class SeenMovie
    {
        [DataMember]
        public string Name { get; set; }
    }
}
