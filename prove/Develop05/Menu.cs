public class Menu {
    private List<Goal> _goalList = new List<Goal>();
    private int _pointCount = 0;
    private String _menuDisplay = """
    Select an option: (1-6)
    1. Create a Goal
    2. List Goals
    3. Record an Event
    4. Save Goals
    5. Load Goals
    6. Quit
    """;
    private String _goaltypes = """
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
    """;
    private String _userInput = "";
    private bool _running = false; 

/* ------------------------------------------------------- */
    public Menu(){}
    public Menu(List<Goal> goalList){
        _goalList = goalList;
    }

    public void RunMenu(){
        _running = true;
        while(_running){
            Console.Clear();
            Console.WriteLine($"Points earned: {_pointCount}");
            Console.WriteLine(_menuDisplay);
            _userInput = Console.ReadLine();

            if(_userInput =="1"){
                CreateGoal();
                continue;
            }
            else if(_userInput =="2"){
                ListGoals();
                continue;
            }
            else if(_userInput =="3"){
                RecordEvent();
                continue;
            }
            else if(_userInput =="4"){
                SaveGoalList();
                continue;
            }
            else if(_userInput =="5"){
                LoadGoalsList();
                continue;
            }
            else if(_userInput =="6"){
                _running = false;
                Environment.Exit(0);
            }
            else{
                Console.WriteLine("Invalid input, enter integer 1-6");
                Console.ReadLine();
            }
        }
    }

    private void CreateGoal(){
        Console.Clear();
            Console.WriteLine("Select the type of goal you would like to create:");
            Console.WriteLine(_goaltypes);
            _userInput = Console.ReadLine();

            if(_userInput =="1"){
                Console.Write("Enter goal name: ");
                String _name = Console.ReadLine();
                Console.Write("Enter the number of points you receive: ");
                int _rewardPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter goal description: ");
                String _description = Console.ReadLine();

                SimpleGoal myGoal = new SimpleGoal(_name, _rewardPoints, _description);
                _goalList.Add(myGoal);
            }
            else if(_userInput =="2"){
                Console.Write("Enter goal name: ");
                String _name = Console.ReadLine();
                Console.Write("Enter the number of points you receive: ");
                int _rewardPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter goal description: ");
                String _description = Console.ReadLine();

                EternalGoal myGoal = new EternalGoal(_name, _rewardPoints, _description);
                _goalList.Add(myGoal);
            }
            else if(_userInput =="3"){
                Console.Write("Enter goal name: ");
                String _name = Console.ReadLine();
                Console.Write("Enter the number of points you receive: ");
                int _rewardPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter goal description: ");
                String _description = Console.ReadLine();
                Console.Write("Enter the number of times it must be completed to earn a bonus: ");
                int _timesToComplete = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus Point Value: ");
                int _bonusRewardValue = int.Parse(Console.ReadLine());


                ChecklistGoal myGoal = new ChecklistGoal(_name, _rewardPoints, _description, _timesToComplete, _bonusRewardValue);
                _goalList.Add(myGoal);
            }

            else{
                Console.WriteLine("Invalid input, enter integer 1-3");
            }

        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }

    private void ListGoals(){
        int _count = 0;
        foreach(Goal goal in _goalList){
            _count += 1;
            Console.WriteLine($"{_count}. {goal.GetDisplay()}");
        }

        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();

    }

    private void LoadGoal(String saveData){

        string[] _dataList = saveData.Split("|");

        if(_dataList[0] == "SimpleGoal"){
            SimpleGoal output = new SimpleGoal();
            output.OverwriteGoal(saveData);
            _goalList.Add(output); 
        }
        else if(_dataList[0] == "EternalGoal"){
            EternalGoal output = new EternalGoal();
            output.OverwriteGoal(saveData);
            _goalList.Add(output); 
        }
        else if(_dataList[0] == "ChecklistGoal"){
            ChecklistGoal output = new ChecklistGoal();
            output.OverwriteGoal(saveData);
            _goalList.Add(output); 
        }
        else{
            Console.WriteLine("Loading Error: String Invalid");
        }

    }

    private void RecordEvent(){
        Console.WriteLine("Select a Goal");
        
        int _count = 0;
        foreach(Goal goal in _goalList){
            _count += 1;
            Console.WriteLine($"{_count}. {goal.GetDisplay()}");
        }

        int _selection = int.Parse(Console.ReadLine());

        _selection -= 1;

        _pointCount += _goalList[_selection].CompleteGoal();

        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }

    
    private void SaveGoalList(){
        List<String> _stringList = new List<string>();

        foreach(Goal goal in _goalList){
            _stringList.Add(goal.GetSaveData());
        }

        RecordResultsToFile(_stringList);

        Console.WriteLine("Success! Press Enter to continue");
        Console.ReadLine();
    }

    private void RecordResultsToFile(List<String> data){
        Console.Write("Enter new file name:");
        string _newFileName = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(_newFileName))
            {
                outputFile.WriteLine($"{_pointCount}");

                foreach(string line in data)
                    {outputFile.WriteLine($"{line}");}
            }
    }

    private void LoadGoalsList(){

        Console.Write("Enter file name:");
        string _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        _pointCount = int.Parse(lines[0]);

        

        foreach(string line in lines[1..]){
            LoadGoal(line);
        }

        Console.WriteLine("Sucess! Press Enter to continue");
        Console.ReadLine();
    }
}