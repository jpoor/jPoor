using System;

namespace jPoor.Common
{
    public enum ErrorTypes
    {
        NoError = 0,
        Information = 1,
        Warning = 2,
        Error = 4,
        Blocker = 8
    }
    public class blError
    {
        /// <summary>
        /// NoError ==> ErrorType = ErrorTypes.NoError; Source = ""; Code = ""; Message = "";
        /// </summary>
        public blError()
        {
            Type = ErrorTypes.NoError;
            Source = "";
            Code = "";
            Message = "";
        }
        public blError(ErrorTypes errorType, string code, Exception exception)
        {
            Type = errorType;
            Source = exception.Source;
            Code = code;
            Message = exception.Message;
        }
        public blError(ErrorTypes errorType, string code, string message)
        {
            Type = errorType;
            Source = "";
            Code = code;
            Message = message;
        }
        public blError(ErrorTypes errorType, string code, string message, string source)
        {
            Type = errorType;
            Source = source;
            Code = code;
            Message = message;
        }


        /// <summary>
        /// Type of Error. NoError is default.
        /// </summary>
        public ErrorTypes Type { get; set; }

        /// <summary>
        /// The code of error.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The name of the application or the object that causes the error
        /// </summary>
        public string Source { get; set; }
    }
}
