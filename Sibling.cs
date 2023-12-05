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