namespace HttpStubServer
{
    public class NullLogger : ILogger
    {
        public static ILogger Instance
        {
            get { return new NullLogger();}
        }

        public void Debug(object o)
        {
            //Do nothing
        }
    }
}