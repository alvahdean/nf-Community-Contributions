using System;


namespace nanoFramework.Contrib.HandyExtensions.ExceptionExtensions
{

    public static class HandyExceptionExtensions
    {
        public static string Gist(this Exception ex)
        {
            return ex != null ? $"[{ex.GetType().Name}]: {ex.Message}" : "Null exception";
        }

        public static void Throw(this Exception ex)
        {
            if (ex != null)
                throw ex;
        }
    }

}
