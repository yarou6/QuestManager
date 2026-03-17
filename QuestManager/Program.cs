

using QuestManager;

SimpleQuest questA = new SimpleQuest("Квест А", 10, 100, 1);
SimpleQuest questB = new SimpleQuest("Квест Б", 20, 150, 1);
SimpleQuest questC = new SimpleQuest("Квест В", 100, 500, 2);

QuestGroup group = new QuestGroup("Сюжет");

group.Add(questA);
group.Add(questB);

List<IQuest> list = new List<IQuest>(){group, questA, questB, questC};

foreach (IQuest quest in list)
{
    quest.Display(0);
}


Console.WriteLine();

questA.Complete();
questB.Complete();
foreach (IQuest quest in list)
{
    quest.Display(0);
}
Console.WriteLine(group.GoldReward + questC.GoldReward);

Console.WriteLine();

questB.Reset();
foreach (IQuest quest in list)
{
    quest.Display(0);
}
