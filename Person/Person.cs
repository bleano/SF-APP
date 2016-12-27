using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Person
{

    [DataContract]
    public class PersonOnbject
    {
        [DataMember]
        internal string name;

        [DataMember]
        internal int age;
    }
}
