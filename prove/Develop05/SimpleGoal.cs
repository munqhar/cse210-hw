public class SimpleGoal: Goal
{
    //protected string _goalType = "Simple Goal";
    public SimpleGoal(string name, string description, int points, string goalType ): base( name,  description,  points, goalType )
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
//        _listGoal = listGoal;
        
    }
    
    public override int RecordEvents()
    {
     Console.WriteLine($"Congratulations! You have earned {_points} points!");               
     _isComplete = true;
     return _points;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public void set(string name, string description, int points, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
        //_listGoal = listGoal;

    }
     public override void ShowListGoal()
    {
        Console.WriteLine($"{_name} ({_description})");
    }
   

}