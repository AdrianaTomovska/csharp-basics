using Homework8.CollectionTypes.Enums;

namespace Homework8.CollectionTypes.Models;

public class Song
{
    public string Title { get; set; }
    public int Length { get; set; }
    public Genre Genre { get; set; }

    public Song(string title, int lengthInSeconds, Genre genre)
    {
        Title = title;
        Length = lengthInSeconds;
        Genre = genre;
    }

}
