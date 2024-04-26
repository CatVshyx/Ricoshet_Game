using System;
using static System.Net.Mime.MediaTypeNames;

public class StatisticsConfig {

    string fileLocation = "./mystats.txt";

    public Dictionary<string,string> Statistics { get; }

    public StatisticsConfig()
	{
       Statistics = GetStats();
	}


	public string OpenFile() 
	{
        System.Diagnostics.Debug.WriteLine("File location: " , fileLocation);
        if (!File.Exists(fileLocation))
        {
            File.WriteAllText(fileLocation, "enemiesKilled:0\ngamesPlayed:0\nwins:0\nloses:0");
        }

        return File.ReadAllText(fileLocation);
    }

	private Dictionary<string, string> GetStats() 
	{
        // Отримуємо увесь текст з файлу та прибираємо символ \n
		string text = this.OpenFile().Trim('\n');

        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        
        foreach (string line in text.Split('\n')) 
		{
            //Додаємо до словнику нашу запис
			string[] lineSplited = line.Split(':');
            myDictionary[lineSplited[0]]  = lineSplited[1];
            System.Diagnostics.Debug.WriteLine("Key:" + lineSplited[0] + " Value:" + lineSplited[1]);
        }

        return myDictionary;
	}

    public void SaveStats() 
    {
        string text = "";

        foreach(string key in Statistics.Keys) 
        { 
            text += (key + ":" + Statistics[key] + '\n');
        }
        File.WriteAllText(fileLocation, text);
    }
}
