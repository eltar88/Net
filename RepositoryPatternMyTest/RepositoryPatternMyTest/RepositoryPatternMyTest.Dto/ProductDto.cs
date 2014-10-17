using System.Runtime.Serialization;

namespace RepositoryPatternMyTest.Dto
{
    [DataContract]
    public class ProductDto
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public int ReorderLevel { get; set; }

        [DataMember]
        public bool Discontinued { get; set; }
    }
}