List<string> InputStream = new List<string>();

public Animator MAnimator;

void Update()
{
    if(GetKeyDown(KeyCode.Z)) //You can change the inputs later
    {
        AddInputToStream("Z");
    }

    if(GetKeyDown(KeyCode.X))
    {
        AddInputToStream("X");
    }

    if(GetKeyDown(KeyCode.C))
    {
        AddInputToStream("C");
    }

    if(GetKeyDown(KeyCode.V))
    {
       AddInputToStream("V");
    }

    void AddInputToStream(string key)
    {
        //Add new input to the end of the stream
        InputStream.Add(key);

        //Removing the earliest value
        if(InputStream.Length >= 6)
        {
            InputStream.Remove(InputStream[0]);
        }

        //Creating a readable string to be used in the if statements
        string StreamString = "";
        foreach(string key in InputStream)
        {
            StreamString += key;
        }

        //Checking for special inputs
        if(StreamString.Contains("ZVZ"))
        {
            Debug.Log("Hadoken");
            //Play animation for hadoken 
            //Animator.SetTrigger("Hadoken");
        }
    }
}