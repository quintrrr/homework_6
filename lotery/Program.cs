using System;

namespace lotery.Classes;
class Program
{
    public static void Main(string[] args)
    {
        CryptoLotery uniqueNumberLottery = new CryptoLotery("Unique Number Draw", "Unique Number Draw");
        uniqueNumberLottery.AddParticipant(new Participant("Тамара", "Зотейко", new DateTime(2000, 5, 15), 1));
        uniqueNumberLottery.AddParticipant(new Participant("Пётр", "Вицше", new DateTime(1995, 8, 20), 2));
        uniqueNumberLottery.AddParticipant(new Participant("Артур", "Рыболов", new DateTime(1992, 3, 10), 3));
        uniqueNumberLottery.DisplayInfo();
        uniqueNumberLottery.GenerateResult();
        uniqueNumberLottery.DetermineWinner();
    }
}

