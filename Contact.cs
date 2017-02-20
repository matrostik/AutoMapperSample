namespace AutoMapperSample
{
    public interface IContact
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Mobile { get; set; }
    }

    public class Contact : IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {Mobile}";
        }
    }
}
