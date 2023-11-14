public abstract class Goal
{
    protected string _name;
    protected bool _isComplete;
    protected string _description;
    protected int _points;
    protected List<string> _listGoal= new List<string>();
    public  Goal (string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public void CreateFile()
    {

    }
    public void LoadFile()
    {

    }
    public abstract void RecordEvents ();
    public void ShowListGoal()
    {

    }
    public abstract bool IsComplete();
   

}