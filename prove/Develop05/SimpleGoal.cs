public class SimpleGoal: Goal{

    new protected String _type = "SimpleGoal";

    public SimpleGoal(){}
    
    public SimpleGoal(String name, int points, String description, bool status):base(name, points, description, status){
    }

    public SimpleGoal(String name, int points, String description):base(name, points, description){
    }

    override public String GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}";
    }

    override public void OverwriteGoal(String saveData){
            String[] dataList = saveData.Split("|");
            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = bool.Parse(dataList[4]);
        }

    override public string GetDisplay(){

        if (_status){
            return $"[X] {_name}: {_description}";
        }
        else{
            return$"[ ] {_name}: {_description}";
        }
        
    }
        
}