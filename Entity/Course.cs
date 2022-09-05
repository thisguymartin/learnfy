namespace Entity
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = String.Empty;

        public string Price { get; set; } = String.Empty;

        public string Instructor { get; set; } = String.Empty;

        public decimal Rating { get; set; }

        public string Image { get; set; } = String.Empty;

    }
}