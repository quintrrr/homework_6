namespace lotery.Classes;

public class CryptoLotery : Lotery
{
    private int UniqueNumber = 1;
    private Dictionary<Participant, int> ParticipantNumbers { get; set; } = new Dictionary<Participant, int>();
    public CryptoLotery(string name, string type, List<Participant> participants) : base(name, type)
    {
        Participants = participants;
    }
    public CryptoLotery(string name, string type) : base(name, type)
    {
    }
    public override void DetermineWinner()
    {
        foreach (var entry in ParticipantNumbers)
        {
            if (entry.Value == Result)
            {
                Console.WriteLine($"Победитель: {entry.Key.FirstName} {entry.Key.LastName} с номером {entry.Value}");
                return;
            }
        }
        Console.WriteLine("Победитель не найден.");
    }
    
    public void GenerateResult()
    {
        if (Participants.Count == 0)
        {
            Console.WriteLine("Нет участников в лотерее.");
            return;
        }

        Random random = new Random();
        HashSet<int> assignedNumbers = new HashSet<int>();

        foreach (var participant in Participants)
        {
            int uniqueNumber;
            do
            {
                uniqueNumber = random.Next(1, Participants.Count + 1);
            } while (assignedNumbers.Contains(uniqueNumber));

            assignedNumbers.Add(uniqueNumber);
            ParticipantNumbers[participant] = uniqueNumber;
            Console.WriteLine($"Назначен номер {uniqueNumber} для {participant.FirstName} {participant.LastName}");
        }
        Result = random.Next(1, Participants.Count + 1);
        Console.WriteLine($"Победивший номер: {Result}");
    }
}