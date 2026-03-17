namespace QuestManager;

public interface IQuest
{
    
    public string Title { get; } 
    public int GoldReward { get; } 
    public int ExpReward { get; } 
    public int EstimatedHours { get; } 
    public bool IsCompleted { get; }

    public void Complete();

    public void Reset();

    public void Display(int indentLevel);

    public void Add(IQuest quest);

    public void Remove(IQuest quest);
}