namespace lotery.Classes;

public class Participant
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Id { get; set; }
    
    public string GetFullName() => $"{FirstName} {LastName}";
    
    public bool IsAdult()
    {
        return (DateTime.Now.Year - DateOfBirth.Year) >= 18;
    }
}