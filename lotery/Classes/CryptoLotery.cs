namespace lotery.Classes;

public class CryptoLotery : Lotery
{
    private int UniqueNumber = 1;
    
    public CryptoLotery(string name, string type, List<Participant> participants) : base(name, type)
    {
        Participants = participants;
    }
    


    public override void DetermineWinner()
    {
        throw new NotImplementedException();
    }
}