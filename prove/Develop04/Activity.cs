 public class Activity{
    private String _activityName = "Activity";
    protected int _activityDurationSeconds;
    protected int _activityRepetitions;
    protected int _repCount = 0;
    protected DateTime _startTime = DateTime.Now;
    protected DateTime _currentTime;
    protected DateTime _endTime;
    protected string _startMessage;
    protected string _endMessage;
    protected List<String> _results = new List<string>();
    private String _timerMessage = "\bNext";
    protected String _activityOverview = "Shooby-doo-wah";

/* By default this._activityRepetitions is  equal to _activityDuration for a rate of one loop per second This can change for child classes As well as be defined by the user*/

    public Activity(){
        this._activityDurationSeconds = 30;
        this._activityRepetitions = 30;
        _startMessage = $"The {_activityName} starts now.";
        _endMessage = $"Great job! You completed {_repCount} repetitions or {this._activityDurationSeconds} seconds of the {_activityName}.";
    }

    public Activity(int duration){
        this._activityDurationSeconds = duration;
        this._activityRepetitions = duration;
        _startMessage = $"The {_activityName} starts now.";
        _endMessage = $"Great job! You completed {_repCount} repetitions or {this._activityDurationSeconds} seconds of the {_activityName}.";
    }

    public Activity(int duration, int repetitions){
        this._activityDurationSeconds = duration;
        this._activityRepetitions = repetitions;
        _startMessage = $"The {_activityName} starts now.";
        _endMessage = $"Great job! You completed {_repCount} repetitions or {this._activityDurationSeconds} seconds of the {_activityName}.";
    }

    public void SetActivityDuration(int duration){
        this._activityDurationSeconds = duration;
    }

    public void SetActivityRepetitions(int repetitions){
        this._activityRepetitions = repetitions;
    }

    protected virtual void SetActivityTime(){
        Console.Write("\nHow will you measure your time - reps or seconds? (Nothing to to use the defaults.) ");
        String answer = Console.ReadLine();
        int number;

        if (answer.ToLower() == "reps"|| answer.ToLower() == "repetitions" ){
            Console.Write("\nHow many reps do you want to do? ");

            number = int.Parse(Console.ReadLine());

            SetActivityRepetitions(number);
            SetActivityDuration(number+300);
            Console.WriteLine("\n");
        }

        else if (answer.ToLower() == "seconds"|| answer.ToLower() == "second" ){
            Console.Write("\nHow many seconds do you want to do this for? ");

            number = int.Parse(Console.ReadLine());

            SetActivityRepetitions(number+20);
            SetActivityDuration(number);
            Console.WriteLine("\n");
        }

        else{
            Console.WriteLine("You either skipped or entered an invalid answer, using Default time.\n");
        }
    }

    protected void DisplayStartMessage(){
        Console.Clear();
        Console.WriteLine(_startMessage);
    }

    protected void DisplayEndMessage(){
        Console.WriteLine(_endMessage);
    }
    public String GetName(){
        return _activityName;
    }

    protected void DisplayTimerMessage(){
        Console.WriteLine(_timerMessage);
    }

    protected void AnimateSpinner(){
        Console.Write("\b|");
        Thread.Sleep(125);
        Console.Write("\b/");
        Thread.Sleep(125);
        Console.Write("\b-");
        Thread.Sleep(125);
        Console.Write("\b\\");
        Thread.Sleep(125);
        Console.Write("\b|");
        Thread.Sleep(125);
        Console.Write("\b/");
        Thread.Sleep(125);
        Console.Write("\b-");
        Thread.Sleep(125);
        Console.Write("\b\\");
        Thread.Sleep(125);
        Console.Write("\b");
    }

    protected void Prepare(){
            Console.WriteLine("Get Ready...");
            AnimateSpinner();
            AnimateSpinner();
            AnimateSpinner();
        }

    public void RunActivity(){
        DisplayStartMessage();
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(this._activityDurationSeconds);

        while(_repCount < this._activityRepetitions){
            /*Timer Failsafe*/
            _currentTime = DateTime.Now;
            if(_currentTime == _endTime){
                break;
            }
            DisplayTimerMessage();
            AnimateSpinner();
            _repCount++;
            /* Thread.Sleep(1000); */
        }

        DisplayEndMessage();
    }

    public string GetResults(){
        String output = "Results:\n";
        
        foreach(string line in _results)
            {output += line + "\n";}
        
        return output;
    }


    protected void DisplayActivityOverview(){
        Console.WriteLine(_activityOverview);
    }

}