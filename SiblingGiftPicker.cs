using System;
using System.IO;
using System.Collections.Generic;
public class Sibling
{
    private string _name;
    private int _numberInList;
    private int _giftsGiven = 0;
    private int _giftsReceived = 0;
    private List<string> _givingTo = new List<string>();
    public Sibling(string name)
    {
        _name = name;
    }
    public void AddGiftGiven()
    {
        _giftsGiven++;
    }
    public void AddGiftReceived()
    {
        _giftsReceived++;
    }
    public void AddNumber(int number)
    {
        _numberInList = number;
    }
    public int GetNumber()
    {
        return _numberInList;
    }
    public string GetName()
    {
        return _name;
    }
    public void AddGivingTo(Sibling sibling)
    {
        _givingTo.Add(sibling.GetName());
    }
    public void GetGivingTo()
    {
        foreach (string recepient in _givingTo)
        {
            Console.WriteLine($"{_name} buys for {recepient}");
        }
    }
    public List<string> GetRecepients()
    {
        return _givingTo;
    }
    public int GetReceived()
    {
        return _giftsReceived;
    }
    public int GetGiven()
    {
        return _giftsGiven;
    }
}
public class GiftPicker
{
    static void Main(string[] args)
    {
        int giftsToGive = 2;
        int siblingNumber = 0;

        List<Sibling> siblings = new List<Sibling>();
        Sibling chandlersarah = new Sibling("Sarah+Chandler");
        siblings.Add(chandlersarah);
        Sibling shannon = new Sibling("Shannon");
        siblings.Add(shannon);
        Sibling emily = new Sibling("Emily");
        siblings.Add(emily);
        Sibling michael = new Sibling("Michael");
        siblings.Add(michael);
        Sibling bethany = new Sibling("Bethany");
        siblings.Add(bethany);
        Sibling megan = new Sibling("Megan");
        siblings.Add(megan);

        foreach (Sibling sibling in siblings)
        {
            sibling.AddNumber(siblingNumber);
            siblingNumber++;
        }
        Random random = new Random();
        foreach (Sibling sibling in siblings)
        {
            while (sibling.GetGiven() < giftsToGive)
            {
                int num = random.Next(0, siblings.Count);
                while (sibling.GetNumber() == num || siblings[num].GetReceived() >= giftsToGive || sibling.GetRecepients().Contains(siblings[num].GetName()))
                {
                    num = random.Next(0, siblings.Count);
                }
                sibling.AddGivingTo(siblings[num]);
                sibling.AddGiftGiven();
                siblings[num].AddGiftReceived();
            }
        }
        foreach (Sibling sibling in siblings)
        {
            sibling.GetGivingTo();
        }
    }
}