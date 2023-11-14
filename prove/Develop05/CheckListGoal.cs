public class CheckListGoal: Goal
{
    protected int _timesToGetBonus;
    protected int _bonus;
    public CheckListGoal(string name, string description, int points, int timesToGetBonus, int bonus): base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _timesToGetBonus = timesToGetBonus;
    }
     public override void RecordEvents()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

}