namespace QuestManager;

public class SimpleQuest : IQuest
{
    private string _title;
    private int _gold;
    private int _exp;
    private int _hours;
    private bool _isCompleted = false;

    public string Title { get; }

    public int GoldReward => _gold;

    public int ExpReward => _exp;

    public int EstimatedHours => _hours;

    public bool IsCompleted => _isCompleted;

    public SimpleQuest(string title, int gold, int exp, int hours)
    {
        _title = title;
        _gold = gold;
        _exp = exp;
        _hours = hours;
    }
    public void Complete()
    {
        _isCompleted = true;
    }

    public void Reset()
    {
        _isCompleted = false;
    }

    public void Display(int indentLevel)
    {
        Console.Write(_isCompleted ? "[x]" : "[ ]");
        Console.Write($"{_title} (Награда: {_gold} золотых)\n");
    }

    public void Add(IQuest quest)
    {
        Console.WriteLine("Ошибка добавления подквеста");
            
    }

    public void Remove(IQuest quest)
    {
        Console.WriteLine("Ошибка удаления подквеста");
    }
}