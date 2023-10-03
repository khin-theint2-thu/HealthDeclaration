using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidHealthDeclarationForm.Enums
{
    public enum ReturnStatus
    {
        Success,
        Error
    }

    public enum LogLevel
    {
        Info,
        Error,
        Warning
    }

    public enum ActionStatus
    {
        Create,
        Update,
        Delete,
        Read
    }
}
