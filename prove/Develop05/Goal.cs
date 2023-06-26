public abstract class Goal{

    protected String _name = "Goal";
    protected int _rewardPoints = 1;
    protected String _description = "Description";

    protected String _type = "Goal";
    protected bool _status = false;

    public Goal(){}

    public Goal(String name, int points, String description, bool status){
        _name = name;
        _rewardPoints = points;
        _description = description;
        _status = status;
    }

    public Goal(String name, int points, String description){
        _name = name;
        _rewardPoints = points;
        _description = description;
    }

    public String GetGoalType(){
        return _type;
    }

    public String GetName(){
        return  _name;
    }

    public void SetName(String name){
        _name = name;
    }

    public String GetDescription(){
        return _description;
    }

    public void GetDescription(String description){
        _description = description;
    }

    public int GetRewardPoints(){
        return _rewardPoints;
    }

    public void SetRewardPoints(int points){
        _rewardPoints = points;
    }

    public bool GetStatus(){
        return _status;
    }

    public void SetStatus(bool status){
        _status = status;
    }

    virtual public int CompleteGoal(){
        Console.WriteLine($"You comepleted the {_name}!");
        _status = true;
        return GetRewardPoints();
    }

    virtual public String GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}";
    }

    virtual public void OverwriteGoal(String saveData){
            String[] dataList = saveData.Split("|");
            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = bool.Parse(dataList[4]);
        }
    
    virtual public string GetDisplay(){

        if (_status){
            return $"[X] {_name}: {_description}";
        }
        else{
            return$"[ ] {_name}: {_description}";
        }
        
    }

}