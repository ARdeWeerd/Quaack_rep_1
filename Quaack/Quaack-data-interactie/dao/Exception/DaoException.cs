using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable()]
public class DaoException : System.Exception
{
    public DaoException() : base() { }
    public DaoException(string message) : base(message) { }
    public DaoException(string message, System.Exception inner) : base(message, inner) { }

    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client. 
    protected DaoException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) { }
}
