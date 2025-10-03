public class Attendee
{
    // Properties to hold the attendee's information
    public string Name { get; set; }
    public string City { get; set; }
    public int Age { get; set; }
    public string Business { get; set; }
    public string Position { get; set; }
    public string SeatNumber { get; set; }
    public bool HasAttended { get; set; } // පැමිණීම සටහන් කරගන්න

    // Constructor to easily create a new attendee
    public Attendee(string name, string city, int age, string business, string position, string seatNumber)
    {
        Name = name;
        City = city;
        Age = age;
        Business = business;
        Position = position;
        SeatNumber = seatNumber;
        HasAttended = false; // මුලින්ම හැමෝම 'පැමිණ නැත' ලෙස සලකමු
    }
}