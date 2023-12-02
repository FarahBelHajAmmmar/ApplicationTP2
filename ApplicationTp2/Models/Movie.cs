namespace ApplicationTp2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String ?Name { get; set; }
        //c'est la clé étrangere et la propriete de navigation si je vais faire la relation entre movie et genre
        //public int genre_Id { get; set; }
        //public Genre Genre { get; set; }
        public Movie()
        {

        }
    }
}
