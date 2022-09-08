namespace Entity
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = String.Empty;

        public decimal Price { get; set; }

        public string Instructor { get; set; } = String.Empty;

        public decimal Rating { get; set; }

        public string Image { get; set; } = String.Empty;

    }
}