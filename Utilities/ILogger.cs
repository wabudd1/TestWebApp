using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Utilities
{
    public interface ILogger
    {
        void Debug(string message, string arg = null);
    }
}