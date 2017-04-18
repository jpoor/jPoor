namespace jPoor.Common
{
    public class blResult
    {
        /// <summary>
        /// True Resul ==> Error = NoError; Result = true; Message = ""; ReturnObject = null;
        /// </summary>
        public blResult()
        {
            Error = new blError();
            Result = null;
        }
        public blResult(blError error)
        {
            Error = error;
            Result = null;
        }
        public blResult(object result)
        {
            Error = new blError();
            Result = result;
        }
        public blResult(blError error, object result)
        {
            Error = error;
            Result = result;
        }

        public blError Error { get; set; }
        public object Result { get; set; }
    }
}
