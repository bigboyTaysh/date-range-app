using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    [Serializable]
    public class IncorrectFormatException : Exception
    {
        public IncorrectFormatException() { }
        public IncorrectFormatException(string message) : base(message) { }
        public IncorrectFormatException(string message, Exception inner) : base(message, inner) { }
        protected IncorrectFormatException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
