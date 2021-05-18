using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    [Serializable]
    public class IncorrectRelationshipException : Exception
    {
        public IncorrectRelationshipException() { }
        public IncorrectRelationshipException(string message) : base(message) { }
        public IncorrectRelationshipException(string date1, string relationship, string date2) : base($"{date1} {relationship} {date2}") { }
        public IncorrectRelationshipException(string message, Exception inner) : base(message, inner) { }
        protected IncorrectRelationshipException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
