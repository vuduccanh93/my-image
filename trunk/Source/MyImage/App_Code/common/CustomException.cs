using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Runtime.Serialization;


[Serializable]
public class CustomException : Exception
{
    public CustomException()
        : base() { }

    public CustomException(string message)
        : base(message) { }

    public CustomException(string format, params object[] args)
        : base(string.Format(format, args)) { }

    public CustomException(string message, Exception innerException)
        : base(message, innerException) { }

    public CustomException(string format, Exception innerException, params object[] args)
        : base(string.Format(format, args), innerException) { }

    protected CustomException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }
}
