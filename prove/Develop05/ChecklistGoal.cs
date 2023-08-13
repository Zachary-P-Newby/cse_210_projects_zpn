public class ChecklistGoal:Goal {

    new protected String _type = "ChecklistGoal";   
    
    private int _timesCompleted = 0;
    private int _timesToComplete = 3;
    private int _bonusRewardValue = 10;

    public ChecklistGoal(){}

    public ChecklistGoal(String name, int points, String description, int timesToComplete, int bonusRewardValue):base(name, points, description){
        _timesToComplete = timesToComplete;
        _bonusRewardValue = bonusRewardValue;
    }
    
    public ChecklistGoal(String name, int points, String description, bool status, int timesCompleted, int timesToComplete, int bonusRewardValue):base(name, points, description, status){
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _bonusRewardValue = bonusRewardValue;
    }

    public ChecklistGoal(String name, int points, String description, int timesCompleted, int timesToComplete, int bonusRewardValue):base(name, points, description){
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _bonusRewardValue = bonusRewardValue;
    }
    
    override public string GetDisplay(){

        if (_status == true || _timesCompleted == _timesToComplete){
                return $"[X] {_name}: {_description} --Competed: {_timesCompleted}/{_timesToComplete}";
            }
            else{
                return $"[ ] {_name}: {_description} --Competed: {_timesCompleted}/{_timesToComplete}";
            } 
        
    }
    
    override public int CompleteGoal(){
        Console.WriteLine($"You {_name} once, good job!");

        _timesCompleted += 1;

        if (_timesCompleted == _timesToComplete){
            _status = true;
            return GetTotalPoints();

        }
        else{
            return GetRewardPoints();
        }
    }

    public int GetTimesCompleted(){
        return _timesCompleted;
    }

    public void setTimesCompleted(int timesCompleted){
        _timesCompleted = timesCompleted;
    }

    public int GetTimesToComplete(){
        return _timesToComplete;
    }

    public void setTimesToComplete(int timesToComplete){
        _timesToComplete = timesToComplete;
    }

    public int GetBonusRewardValue(){
        return _bonusRewardValue;
    }

    public int GetTotalPoints(){
        return _rewardPoints + _bonusRewardValue;
    }

    public void setBonusRewardValue(int bonusRewardValue){
        _bonusRewardValue = bonusRewardValue;
    }

    override public String GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}|{_timesCompleted}|{_timesToComplete}|{_bonusRewardValue}";
    }


    override public void OverwriteGoal(String saveData){
            String[] dataList = saveData.Split("|");

            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = bool.Parse(dataList[4]);
    }


}