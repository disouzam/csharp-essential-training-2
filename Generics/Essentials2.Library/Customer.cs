namespace Essentials2.Library
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreateDate { get; set; }

        public int CompareTo(Customer? other)
        {
            if (other?.Id == this.Id)
            {
                return 0;
            }

            if (other?.Id > this.Id)
            {
                return -1;
            }

            return 1;
        }

        public T Map<T>(IMapper<Customer, T> mapper)
        {
            return mapper.Map(this);
        }
    }
}
