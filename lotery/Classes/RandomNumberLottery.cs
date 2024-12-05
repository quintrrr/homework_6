namespace lotery.Classes;

public class RandomNumberLottery : Lotery
{
    
    private int range;
    private Dictionary<Participant, int> participantsNumbers = new Dictionary<Participant, int>();
    public int Range { get => range; set => range = value; }
    public RandomNumberLottery(string name, string type) : base(name, type)
    {
        Range = 100;
        Result = GenerateResult();
    }
    public RandomNumberLottery(string name, string type, int range) : base(name, type)
    {
        Range = range;
        Result = GenerateResult();
    }
    public int GenerateResult()
    {
        Random rnd = new Random();
        return rnd.Next(range);
    }

    public void AssignNumbers()
    {
        foreach (Participant participant in Participants)
        {
            if (!participantsNumbers.ContainsKey(participant))
            {
                participantsNumbers.Add(participant, GenerateResult());
            }
            else
            {
                participantsNumbers[participant] = GenerateResult();
            }
        }
    }

    public override void DetermineWinner()
    {
        if (GetParticipantCount() == 0)
        {
            Console.WriteLine("Нет участников");
            return;
        }
        AssignNumbers();
        foreach (KeyValuePair<Participant, int> pair in participantsNumbers)
        {
            
            if (pair.Value == Result)
            {
                Console.WriteLine($"Выиграл игрок: {pair.Key.GetFullName()}");
            }
        }
    }
}