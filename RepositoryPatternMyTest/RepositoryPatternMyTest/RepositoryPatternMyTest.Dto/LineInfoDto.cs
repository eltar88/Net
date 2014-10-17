using System.Runtime.Serialization;

namespace RepositoryPatternMyTest.Dto
{
    [DataContract]
    public class LineInfoDto
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int Quantity { get; set; }
    }
}