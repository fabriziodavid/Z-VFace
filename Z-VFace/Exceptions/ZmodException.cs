using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_VFace.Exceptions
{
    [System.Serializable]
    public class ZmodException : Exception
    {
        public ZmodException() { }
        public ZmodException(string message) : base(message) { }
        public ZmodException(string message, Exception inner) : base(message, inner) { }
        protected ZmodException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
