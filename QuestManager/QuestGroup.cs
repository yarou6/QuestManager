namespace QuestManager;

public class QuestGroup : IQuest
{
    private string _title = "";
    private List<IQuest> _children = new();
    
    public string Title { get; }

    public QuestGroup(string title)
    {
        _title = title;
    }

    public int GoldReward
    {
        get
        {
            int i = 0;
            foreach (var quest in _children)
            {
                i += quest.GoldReward;
            }
            return i;
        }
    }

    public int ExpReward
    {
        get
        {
            int i = 0;
            foreach (var quest in _children)
            {
                i += quest.ExpReward;
            }
            return i;
        }
    }

    public int EstimatedHours
    {
        get
        {
            int i = 0;
            foreach (var quest in _children)
            {
                i += quest.EstimatedHours;
            }
            return i;
        }
    }

    public bool IsCompleted
    {
        get
        {
            bool q = true;
            foreach (var quest in _children)
            {
                if (!quest.IsCompleted)
                {
                    q = false;
                    break;
                }
            }

            if (_children.Count != 0 && q)
            {
                return true;
            }
            return false;
        }
    }
    
    public void Complete()
    {
        foreach (var quest in _children)
        {
            quest.Complete();
        }
    }

    public void Reset()
    {
        foreach (var quest in _children)
        {
            quest.Reset();
        }
    }

    public void Display(int indentLevel)
    {
        Console.WriteLine($"{_title}");
        foreach (var quest in _children)
        {
            quest.Display(indentLevel + 1);
        }
        Console.WriteLine("--------------------------------------");
    }

    public void Add(IQuest quest)
    {
        _children.Add(quest);
    }

    public void Remove(IQuest quest)
    {
        _children.Remove(quest);
    }
}