using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// author: Edwin Denekamp
/// </summary>
[Serializable()]
public class ServiceException : System.Exception
{
    
    public ServiceException() : base() { }
    public ServiceException(string message) : base(message) { }
    public ServiceException(string message, System.Exception inner) : base(message, inner) { }

    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client. 
    protected ServiceException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) { }
}
