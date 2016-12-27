using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string name;

        [DataMember]
        public String id;

        [DataMember]
        public String timeStamp;

    }



}
