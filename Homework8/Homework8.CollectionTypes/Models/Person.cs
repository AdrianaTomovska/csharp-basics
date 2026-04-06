using Homework8.CollectionTypes.Enums;

namespace Homework8.CollectionTypes.Models;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Genre FavoriteMusicType { get; set; }
    public List<Song> FavoriteSongs {  get; set; }


    public Person(int id, string firstName, string lastName, int age, Genre favoriteMusicType)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        FavoriteMusicType = favoriteMusicType;
        FavoriteSongs = new List<Song>();
    }

    public void GetFavSongs()
    {
        if (FavoriteSongs.Count == 0)
        {
            Console.WriteLine($"{FirstName} {LastName} hates music.");
            return;
        }

        Console.WriteLine($"{FirstName} {LastName}'s favorite songs:");
        foreach (var song in FavoriteSongs)
        {
            Console.WriteLine($"- {song.Title}");
        }
    }
}

