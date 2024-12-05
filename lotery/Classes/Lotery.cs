namespace lotery.Classes;

public abstract class Lotery
{
    private string name;
    private string type;
    private List<Participant> participants = new List<Participant>();
    private int result;
    public string Name { get => name; set => name = value; }
    public string Type { get => type; set => type = value; }
    public List<Participant> Participants { get => participants; protected set => participants = value; }
    public int Result { get => result; protected set => result = value; }
    

    public void AddParticipant(Participant participant)
    {
        if (participant.IsAdult())
        {
            participants.Add(participant);
        }
        else
        {
            Console.WriteLine("Участник должен быть совершеннолетним");
        }
    }
    
    public int GetParticipantCount()
    {
        return Participants.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Лотерея: {name}, Тип лотереи: {type}, Количество участника: {GetParticipantCount()}");
    }
    
    public abstract void DetermineWinner();
    
    public Lotery(string name, string type)
    {
        Name = name;
        Type = type;
    }
}