namespace lotery.Classes;

public class Participant
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Id { get; set; }

    public Participant(string firstName, string lastName, DateTime dateOfBirth, int id)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Id = id;
        
    }
    public string GetFullName() => $"{FirstName} {LastName}";
    
    public bool IsAdult()
    {
        return (DateTime.Now.Year - DateOfBirth.Year) >= 18;
    }
}