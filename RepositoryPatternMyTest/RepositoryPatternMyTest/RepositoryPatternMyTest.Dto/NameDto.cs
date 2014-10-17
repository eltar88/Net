using System.Runtime.Serialization;

namespace RepositoryPatternMyTest.Dto
{
    [DataContract]
    public class NameDto
    {
        [DataMember]
        public string LastName { get; private set; }

        [DataMember]
        public string FirstName { get; private set; }

        [DataMember]
        public string MiddleName { get; private set; }
    }
}