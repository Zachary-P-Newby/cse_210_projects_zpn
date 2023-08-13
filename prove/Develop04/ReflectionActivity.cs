public class ReflectionActivity: Activity{

    private String _activityName = "Relection Activity";

    new private String _activityOverview = "Welcome to the Reflection Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<string> _promptList = new List<string>();
    private List<string> _questionList = new List<string>();

    

    public ReflectionActivity(){
        
        /* InitiatePromptList(); */
        _startMessage = $"The {_activityName} starts now.";
        
    }

    public ReflectionActivity(int duration){
        base._activityRepetitions = duration / 30;
        base._activityDurationSeconds = duration;
        /* InitiatePromptList(); */
        _startMessage = $"The {_activityName} starts now.";
        
    }

    public ReflectionActivity(int duration, int repetitions){
        base._activityDurationSeconds = duration;
        base._activityRepetitions = repetitions;
        /* InitiatePromptList(); */
        _startMessage = $"The {_activityName} starts now.";
        
    }

/* ------------------------------------------------------------------------------ */

    new public void RunActivity(){
        InitiatePromptLists();
        Console.Clear();
        DisplayActivityOverview();

        SetActivityTime();

        Prepare();

        DisplayStartMessage();

        DisplayPrompt();
        Console.Write("Press enter when you are ready to begin writing:");
        Console.ReadLine();

        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(this._activityDurationSeconds);

        while(_repCount < this._activityRepetitions){
            /*Timer Failsafe*/
            _currentTime = DateTime.Now;
            if(_currentTime == _endTime){
                break;
            }

            DisplayQuestion();
            
            String answer = Console.ReadLine();

            _results.Add(answer);

            _repCount += 1;
        }

        _endMessage = $"Great job! You answered {_repCount} questionstions and spent {this._activityDurationSeconds /60 } minutes reflecting.";
        DisplayEndMessage();

    }

    /* ------------------------------------------------------------------------- */

    private void InitiatePromptLists(){
        _promptList.Add("Think of a time you saw God's hand in your life.");
        _promptList.Add("Think of a time when you completed a difficult task.");
        _promptList.Add("Think of a time when someone did something nice to you.");
        _promptList.Add("Think of a time where the Lord helped you.");
        _promptList.Add("Think of a time you felt the Holy Spirit.");

        _questionList.Add("How did that make you feel?");
        _questionList.Add("What happened or why did it happen?");
        _questionList.Add("What do you remember most about that expirience?");
        _questionList.Add("Did anything else signifigant happen that day?");
        _questionList.Add("What does that expirience inspire you to do?");
    }


/* ------------------------------------------------------------------------- */


/* ------------------------------------------------------------------------- */

    private void DisplayPrompt(){
        Random seed = new Random();

        String _prompt = _promptList[seed.Next(0,_promptList.Count)];

        _results.Add(_prompt);

        Console.WriteLine("\n");
        Console.WriteLine("Consider this and write down answers to the questions:");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine("\n");
        Console.WriteLine("-------------------------------------------------");
    }

/* ------------------------------------------------------------------------- */

    private void DisplayQuestion(){
        Random seed = new Random();

        String _question = _questionList[seed.Next(0,_promptList.Count)];

        _results.Add(_question);

        Console.WriteLine("\n");
        Console.WriteLine("Consider this:");
        Console.WriteLine($"{_question}");
        Console.WriteLine("\n");
        Console.WriteLine("-------------------------------------------------");
    }


/* --------------------------------------------------------------- */

    new public void SetActivityDuration(int duration){
        base._activityDurationSeconds = duration;
        Console.WriteLine($"{base._activityDurationSeconds}");
    }

    new public void SetActivityRepetitions(int repetitions){
        base._activityRepetitions = repetitions;
        Console.WriteLine($"{base._activityRepetitions}");
    }

/* ------------------------------------------------------------------------- */


    new protected void DisplayActivityOverview(){
        Console.WriteLine(_activityOverview);
    }


/* ------------------------------------------------------------------------- */


    new protected void SetActivityTime(){
        Console.Write("How will you measure your time - questions or minutes? (Nothing to to use the defaults.) ");
        String answer = Console.ReadLine();
        int number;

        if (answer.ToLower() == "questions"|| answer.ToLower() == "question" ){
            Console.Write("\nHow many questions do you want? ");

            number = int.Parse(Console.ReadLine());

            this.SetActivityRepetitions(number);
            this.SetActivityDuration((number * 10 ) * 60);
            Console.WriteLine("\n");
        }

        else if (answer.ToLower() == "minute"|| answer.ToLower() == "minutes" || answer.ToLower() == "min" ){
            Console.Write("\nHow many minutes do you want to do this for? ");

            number = int.Parse(Console.ReadLine());

            this.SetActivityRepetitions(number*30);
            this.SetActivityDuration(number * 60);
            Console.WriteLine("\n");
        }

        else{
            Console.WriteLine("You either skipped or entered an invalid answer, using Default time.\n");
            base._activityDurationSeconds = 60;
            base._activityRepetitions = 15;
        }

    }


}
