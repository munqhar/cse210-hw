public abstract class Goal
{
    // Making a change to the file

    protected string _name;
    protected bool _isComplete;
    protected string _description;
    protected int _points;
    protected string _goalType;
    public  Goal (string name, string description, int points, string goalType )
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
        //_listGoal = listGoal;
    }
    
    public string GetType()
    {
        return _goalType;
    }
    public string CreateFile()
    {
        return $"{_goalType}: {_name}, {_description}, {_points} ";

    }
   
   
    public string getname()
    {
        return _name;
    }
    public abstract int RecordEvents ();
   
    /* public void ShowListGoal()
    {
    for(int i = 0; i < _listGoal.Count; i++)
        {
            Console.WriteLine($"{i+1}. [] {_listGoal[i]}");
        }

    } */
    
    public abstract bool IsComplete();
   
  public abstract void ShowListGoal();
    
}