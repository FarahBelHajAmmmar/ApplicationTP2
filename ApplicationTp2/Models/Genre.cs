namespace ApplicationTp2.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public String? Name { get; set; }
        //c'est la propriete de navigation que je dois utiliser si je fais la relation entre movie et genre
        //public ICollection<Movie> Movie { get; set; }

    }
}
