namespace Crm.Domain.Products.Exceptions
{
    public class InvalidDomainDataException : Exception
    {
        public InvalidDomainDataException() { }
        public InvalidDomainDataException(string message) : base(message) { }

        public static void CheckPrice(int price)
        {
            if (price < 1)
                throw new InvalidDomainDataException("out of range");
        }
        public static void CheckCount(int count)
        {
            if (count < 1)
                throw new InvalidDomainDataException("out of range");
        }
        public static void CheckSize(int size)
        {
            if (size < 35 || size > 49)
                throw new InvalidDomainDataException("out of range");
        }
    }
}
