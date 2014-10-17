using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RepositoryPatternMyTest.Dto
{
    [DataContract]
    public class OrderDto
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public CustomerDto Customer { get; set; }

        [DataMember]
        public EmployeeDto Reference { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public decimal OrderTotal { get; set; }

        [DataMember]
        public IEnumerable<LineItemDto> LineItems { get; set; }
    }
}