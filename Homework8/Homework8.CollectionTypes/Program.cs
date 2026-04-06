using Homework8.CollectionTypes.Enums;
using Homework8.CollectionTypes.Models;

var songs = new List<Song>
{
    new Song("Bohemian Rhapsody", 354, Genre.Rock),
    new Song("Beat It", 258, Genre.Rock),
    new Song("Blackbird", 185, Genre.Rock),
    new Song("Billie Jean", 294, Genre.Hip_Hop),
    new Song("Clair de Lune", 480, Genre.Classical),
    new Song("Fur Elise", 330, Genre.Classical),
    new Song("Numb", 187, Genre.Techno),
    new Song("Lose Yourself", 326, Genre.Hip_Hop),
    new Song("Thunderstruck", 292, Genre.Rock),
    new Song("Sicko Mode", 312, Genre.Hip_Hop),
    new Song("Imagine", 363, Genre.Rock),
    new Song("Canon in D", 420, Genre.Classical),
    new Song("Born to Run", 380, Genre.Rock),
    new Song("Blinding Lights", 200, Genre.Techno)
};

var persons = new List<Person>
{
    new Person(1, "Jerry", "Smith", 28, Genre.Rock),
    new Person(2, "Maria", "Johnson", 25, Genre.Classical),
    new Person(3, "Jane", "Williams", 22, Genre.Rock),
    new Person(4, "Stefan", "Brown", 30, Genre.Hip_Hop),
    new Person(5, "Alice", "Davis", 27, Genre.Techno)
};

// Select the person Jerry and add all the songs which start with the letter B.
var jerry = persons.Find(p => p.FirstName == "Jerry");
foreach (var song in songs)
{
    if (song.Title.StartsWith("B", StringComparison.OrdinalIgnoreCase))
        jerry.FavoriteSongs.Add(song);
}

//Select the person Maria and add all the songs with length longer than 6 min.
var maria = persons.Find(p => p.FirstName == "Maria");
foreach (var song in songs)
{
    if (song.Length > 360)
        maria.FavoriteSongs.Add(song);
}

// Select the person Jane and add all the songs that are of genre Rock.
var jane = persons.Find(p => p.FirstName == "Jane");
foreach (var song in songs)
{
    if (song.Genre == Genre.Rock)
        jane.FavoriteSongs.Add(song);
}

// Select the person Stefan and add all songs shorter than 3 min and of genre Hip-Hop.
var stefan = persons.Find(p => p.FirstName == "Stefan");
foreach (var song in songs)
{
    if (song.Length < 180 && song.Genre == Genre.Hip_Hop)
        stefan.FavoriteSongs.Add(song);
}

// Select all persons from the persons array that have 4 or more songs.
var personsWith4OrMoreSongs = persons.FindAll(p => p.FavoriteSongs.Count >= 4);

Console.WriteLine("Persons with 4 or more songs:");
foreach (var person in personsWith4OrMoreSongs)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} - {person.FavoriteSongs.Count} songs");
}

Console.WriteLine("\nFavorite songs of each person:");
foreach (var person in persons)
{
    person.GetFavSongs();
    Console.WriteLine();
}