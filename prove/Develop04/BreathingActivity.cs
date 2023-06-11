public class BreathingActivity: Activity{

    private String _activityName = "Breathing Activity";
    private String _breathIn = "Breath in...";
    private String _breathOut = "Breath out...";

    new private String _activityOverview = "Welcome to the Breathing Activity!\n\nThis is the breathing activity.\n\nHere you will clear your mind by breathing in and out. Taking deep breaths is a well known technique for calming down. So clear your mind and focus on your breathing.\n";

/* By default this._activityRepetitions is  equal to _activityDuration divided by eight for a rate of one loop per 8 second This can be changed by the user */
    public BreathingActivity(){
        _activityDurationSeconds = 32;
        this._activityRepetitions = 4;
        _startMessage = $"The {_activityName} starts now.";
    }

    public BreathingActivity(int duration){
        this._activityRepetitions = duration / 8;
        _activityDurationSeconds = duration;
        _startMessage = $"The {_activityName} starts now.";
    }

    public BreathingActivity(int duration, int repetitions){
        _activityDurationSeconds = duration;
        this._activityRepetitions = repetitions;
        _startMessage = $"The {_activityName} starts now.";
    }

/* --------------------------------------------------------- */

    new public void RunActivity(){

        DisplayActivityOverview();
        Console.Clear();
        SetActivityTime();
        Prepare();

        /* ---------Activity Start----------- */
        DisplayStartMessage();
        _startTime = DateTime.Now;
        Console.WriteLine(_startTime);
        _endTime = _startTime.AddSeconds(_activityDurationSeconds);

        /* ---------Loop------------- */

        while(_repCount < this._activityRepetitions){
            _currentTime = DateTime.Now;
            if(_currentTime == _endTime){
                break;
            }
            DisplayBreathInMessage();
            count3Seconds();
            Thread.Sleep(1000);
            DisplayBreathOutMessage();
            count3Seconds();
            Thread.Sleep(1000);
            _repCount++;
        }

        _endMessage = $"Great job! You completed {_repCount} repetitions or {_activityDurationSeconds} seconds of the {_activityName}.";
        _results.Add($"--Completed {_repCount} repetitions or {_activityDurationSeconds}-- of {_activityName}");
        DisplayEndMessage();
    }

    private void DisplayBreathInMessage(){
        Console.WriteLine(_breathIn);
    }

    private void DisplayBreathOutMessage(){
        Console.WriteLine(_breathOut);
    }

    private void count3Seconds(){
        Thread.Sleep(1000);
        Console.Write("1 ");
        Thread.Sleep(1000);
        Console.Write("2 ");
        Thread.Sleep(1000);
        Console.WriteLine("3 ");
        
    }

    new private void DisplayActivityOverview(){
        Console.WriteLine(_activityOverview);
    }

}