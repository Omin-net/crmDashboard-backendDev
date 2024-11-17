namespace Crm.Domain.Products.Exceptions
{
    public class NullOrEmptyDomainDataException : Exception
    {
        public NullOrEmptyDomainDataException() { }
        public NullOrEmptyDomainDataException(string message) : base(message) { }
        public static void CheckStirng(string value, string nameOf)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NullOrEmptyDomainDataException($"{nameOf} is null or empty");
        }

    }
}
