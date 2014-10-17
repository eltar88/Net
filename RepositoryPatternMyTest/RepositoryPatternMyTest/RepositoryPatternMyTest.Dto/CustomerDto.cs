using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RepositoryPatternMyTest.Dto
{
    [DataContract]
    public class CustomerDto
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string CustomerIdentifier { get; protected set; }

        [DataMember]
        public NameDto CustomerName { get; protected set; }

        [DataMember]
        public AddressDto Address { get; set; }

        [DataMember]
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}