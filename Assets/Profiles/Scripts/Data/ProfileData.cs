public class ProfileData
{
    public string filename;
    public string name;
    public bool newGame;

    // Player position
    //public float x;
    //public float y;

    public int level;

    public ProfileData()
    {
        this.filename = "None.xml";
        this.name = "None";
        this.newGame = false;

        //this.y = this.x = 0;
        this.level = 1;
    }

    public ProfileData(string name, bool newGame, int level)
    {
        this.filename = name.Replace(" ", "_") + ".xml";
        this.name = name;
        this.newGame = newGame;
        //this.x = x;
        //this.y = y;
        this.level = level;

    }
}
