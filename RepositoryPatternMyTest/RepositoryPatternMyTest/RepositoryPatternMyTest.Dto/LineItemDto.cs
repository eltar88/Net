using System.Runtime.Serialization;

namespace RepositoryPatternMyTest.Dto
{
    [DataContract]
    public class LineItemDto
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public OrderDto Order { get; set; }

        [DataMember]
        public ProductDto Product { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public decimal Discount { get; set; }
    }
}