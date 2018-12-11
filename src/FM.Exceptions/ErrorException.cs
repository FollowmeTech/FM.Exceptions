using System;

namespace FM.Exceptions
{
    public class ErrorException : Exception
    {
        /// <summary>
        /// system code
        /// </summary>
        public int Code { get; private set; }


        public ErrorException(int code)
        {
            this.Code = code;
        }

        public ErrorException(int code ,string exception) : base(exception){
            this.Code = code;
        }

        public ErrorException(int code, string exception, Exception ex) : base(exception, ex)
        {
            this.Code = code;
        }
    }
}
