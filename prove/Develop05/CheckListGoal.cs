using System.Drawing;

public class CheckListGoal: Goal
{
    protected int _timesToGetBonus;
    protected int _bonus;
    protected int _tries;
    public CheckListGoal(string name, string description, int points,string goalType, int timesToGetBonus, int bonus, int tries): base(name, description, points, goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _timesToGetBonus = timesToGetBonus;
        _goalType = goalType;
        _tries = tries;
       // _listGoal = ListGoal;
    }
     public override void RecordEvents()
    { _tries++;
      if(_tries == _timesToGetBonus)
      {
        _isComplete = true;        
        Console.WriteLine($"Congratulations! You have earned {_points}+{_bonus} points!");
        _points = _points + _bonus; 
                   
      }      
      
        
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public void set(string name, string description, int points, string goalType, int timesToGetBonus, int bonus,int tries)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _timesToGetBonus = timesToGetBonus;
        _goalType = goalType;
        _tries = tries;
      //  _listGoal = ListGoal;    
    }
      public override void ShowListGoal()
    {
        Console.WriteLine($"{_name} ({_description})--- Currently completed: {_tries}/{_timesToGetBonus}");
        if (_tries == _timesToGetBonus)
        {
          _tries = 0;
        }
    }
   

}