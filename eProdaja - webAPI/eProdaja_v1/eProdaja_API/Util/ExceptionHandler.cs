using System;
using System.Data.SqlClient;

namespace eProdaja_API.Util
{
    public class ExceptionHandler
    {

        public static string HandleException(Exception ex)
        {
            SqlException error = ex.InnerException as SqlException;

            switch (error.Number)
            {
                case 2627:
                    return GetExceptionMessage(error);

                default: return error.Message + '(' + error.ErrorCode + ')';
            }
        }

        private static string GetExceptionMessage(SqlException error)
        {
            string errorMessage = error.Message;

            int startIndex = errorMessage.IndexOf("'");
            int endIndex = errorMessage.IndexOf("'", startIndex + 1);

            if (startIndex > 0 && endIndex > 0)
            {
                string constraintName = errorMessage.Substring(startIndex + 1, endIndex - startIndex - 1);

                if (constraintName == "CS_KorisnickoIme")
                {
                    errorMessage = "username_ex";
                }
                else if (constraintName == "CS_Email")
                {
                    errorMessage = "email_ex";
                }
            }

            return errorMessage;

        }
    }
}