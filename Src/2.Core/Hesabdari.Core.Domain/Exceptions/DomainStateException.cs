namespace Hesabdari.Core.Domain.Exceptions
{
    public abstract class DomainStateException:Exception
    {
        public string[] Parameters { get; set; }

        public DomainStateException(string message , params string[] parameters):base(message)
        {
            Parameters = parameters;
        }
        public override string ToString()
        {
            if(Parameters.Length < 1 )
            {
                return Message;
            }
            string result = Message;
            for( int i = 0; i < Parameters.Length; i++ )
            {
                string placeHolder = $"{{{i}}}";
                result = result.Replace(placeHolder, Parameters[i]);
            }
            return result;
        }
    }
}
