public class EternalGoal: Goal{

    new protected String _type = "EternalGoal";
    new private String _status = "Eternal";

    public EternalGoal(){}

    public EternalGoal(String name, int points, String description):base(name, points, description){
    }

    override public int CompleteGoal(){
        Console.WriteLine($"You comepleted the {_name}!");
        return GetRewardPoints();
    }

    override public string GetDisplay(){

        return $"[ ] {_name}: {_description} -- {_status}";
        
    }

    override public String GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}";
    }

    override public void OverwriteGoal(String saveData){
            String[] dataList = saveData.Split("|");

            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = dataList[4];
        }
}