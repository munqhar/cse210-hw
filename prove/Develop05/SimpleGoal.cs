public class SimpleGoal: Goal
{
    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvents()
    {

    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

}