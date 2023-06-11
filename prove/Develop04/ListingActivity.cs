public class ListingActivity: Activity{

    private String _activityName = "Listing Activity";
    new private String _activityOverview = "This is the Listing activity! This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private List<string> _promptList = new List<string>();
    private int _secondCount = 0;


    public ListingActivity(){
        this._activityDurationSeconds = 60;
        
        /* InitiatePromptList(); */
        _startMessage = $"The {_activityName} starts now.";
        
    }

    public ListingActivity(int duration){
        this._activityRepetitions = duration / 30;
        this._activityDurationSeconds = duration;
        /* InitiatePromptList(); */
        _startMessage = $"The {_activityName} starts now.";
        
    }

    public ListingActivity(int duration, int repetitions){
        this._activityDurationSeconds = duration;
        this._activityRepetitions = repetitions;
        /* InitiatePromptList(); */
        _startMessage = $"The {_activityName} starts now.";
        
    }

    new public void RunActivity(){
        InitiatePromptLists();
        Console.Clear();
        DisplayActivityOverview();
        SetActivityTime();
        
        DisplayStartMessage();
        DisplayPrompt();
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(this._activityDurationSeconds);
        _currentTime = DateTime.Now;

        while(_secondCount != _activityDurationSeconds){
            /*Timer Failsafe*/
            _currentTime = DateTime.Now;
            if(_currentTime == _endTime){
                break;
            }

            _repCount++;
            Thread.Sleep(100);
            _secondCount++;
            Console.Write($"{_repCount}. ");
            String answer = Console.ReadLine();
            _results.Add($"{_repCount}. {answer}");
        }

        _endMessage = $"Great job! You listed {_repCount} things and spent {this._activityDurationSeconds} seconds listing.";
        DisplayEndMessage();
    }

    private void DisplayPrompt(){
        Random seed = new Random();

        String _prompt = _promptList[seed.Next(0,_promptList.Count)];

        _results.Add($"Prompt: {_prompt}");

        Console.WriteLine("\n");
        Console.WriteLine("Consider this prompt:");
        Console.WriteLine(_prompt);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("\n");

    }

    private void InitiatePromptLists(){
        _promptList.Add("Where have you seen God's hand in your life?");
        _promptList.Add("What are you grateful for?");
        _promptList.Add("When has someone done something nice for you?");
        _promptList.Add("When was a time where the Lord helped you.");
        _promptList.Add("When have you felt the Holy Spirit.");
    }


    new private void SetActivityTime(){
        Console.Write("\nHow many seconds do you want to do this for? ");

            int number = int.Parse(Console.ReadLine());

            SetActivityDuration(number);
    }

    new private void DisplayActivityOverview(){
        Console.WriteLine(_activityOverview);
    }
}   