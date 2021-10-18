using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationRegex
{
    [Serializable]
    internal class CustomException : Exception
    {
        private object entered_Empty;
        private string v;

        public CustomException(object entered_Empty, string v)
        {
            this.entered_Empty = entered_Empty;
            this.v = v;
        }

        public static object ExceptionName { get; internal set; }

        public class CustomException : Exception
        {
            /// <summary>
            /// List of custome errors
            /// </summary>
            public enum ExceptionName
            {
                Entered_Null,
                Entered_Empty,
                Expected_Minimum_length,
                Failed_To_Follow_Regex
            }

            ExceptionName exceptionType;
            /// <summary>
            /// Constructor to set enum variable type
            /// </summary>
            /// <param name="exName"></param>
            /// <param name="msg"></param>
            public CustomException(ExceptionName exName, string msg) : base(msg)
            {
                this.exceptionType = exName;
            }
        }
    }
}
