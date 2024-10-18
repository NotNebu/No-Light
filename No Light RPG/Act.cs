namespace No_Light_RPG;

public class Act
{
    public string Description { get; set; }
    public List<string> Choices { get; set; }

    public Act(string description)
    {
        Description = description;
        Choices = new List<string>();
    }

    public void ShowAct()
    {
        Console.WriteLine(Description);
        for (int i = 0; i < Choices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Choices[i]}");
        }
    }

    public void Choose(int choiceIndex)
    {
        // Handle the choice
        Console.WriteLine($"You chose: {Choices[choiceIndex]}");
    }
}
