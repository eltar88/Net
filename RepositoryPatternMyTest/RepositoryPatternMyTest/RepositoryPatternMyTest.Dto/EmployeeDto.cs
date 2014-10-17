using System.Runtime.Serialization;

namespace RepositoryPatternMyTest.Dto
{
    [DataContract]
    public class EmployeeDto
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public NameDto Name { get; set; }
    }
}