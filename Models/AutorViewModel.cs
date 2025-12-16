namespace books.Models
{
    public class AutorViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AutorViewModel()
        {
            this.Id = 0;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
        }

        public AutorViewModel(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
    }