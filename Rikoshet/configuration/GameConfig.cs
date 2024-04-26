using System;

public class GameConfig
{

    public static List<Element> Elements { get; set; }

    public static StatisticsConfig config = new StatisticsConfig();

    public static Laser laser = new Laser(-20,-20);

    public static int enemiesLeft = 0;

    private static int enemiesKilled = 0;

    public static int UserAttempts { get; set; }

    public static void InitializeElements(int areaWidth, int areaHeight) 
    {
        Color[] colors = new Color[3] { Color.White, Color.Wheat, Color.Yellow };
        Random rd = new Random();
        Elements = new List<Element>();
        Element newEl;
        for (int i = 0; i < 10 + rd.Next(30); i++) 
        {
            int xPosition = (rd.Next(areaWidth) % (areaWidth - 100)) + 10;
            int yPosition = (rd.Next(areaHeight) % (areaHeight - 200)) + 10;

            //Обираємо тип об'єкту
            if (i % 6 == 0)
            {
                newEl = new Mirror(xPosition, yPosition, 100, 50, rd.Next(12) * 30);
            }
            else if (i % 4 == 0)
            {
                newEl = new Enemy(xPosition, yPosition, i%3);
                enemiesLeft++;
            }
            else
            {
                newEl = new Star(xPosition, yPosition, 30, 30, colors[i % colors.Length]);
            }

            // Якщо дуже поряд існує інший об'єкт, ще раз пробуємо
            if (Elements.Exists(cur => cur.ContainsElement(newEl)))
            {
                if(newEl is Enemy) enemiesLeft--;
                i--;
                continue;
            }
            System.Diagnostics.Debug.WriteLine("Element position set: x " + xPosition + " y " + yPosition);
            Elements.Add(newEl);
        }
        UserAttempts = enemiesLeft - 1;
    }

    public static Element IsCollised(Element myEl) 
    {
        return Elements.Find(element => element.ContainsElement(myEl));
    }
    public static Element IsCollised(Point myEl)
    {
        return Elements.Find(element => element.ContainsPoint(myEl));
    }
    public static bool HandleClicks(Point click)
    {
        foreach (var el in Elements)
        {
            if (!el.ContainsPoint(click,true)) continue;

            
            return true;
        }
        return false;
    }
    
    public static void ResetConfigurations() 
    {
        GameConfig.enemiesLeft = 0;
        GameConfig.Elements.Clear();
        GameConfig.laser = new Laser(-20, -20);
        
        // Оновлюємо поточні данні словника
        config.Statistics["gamesPlayed"] = int.Parse(config.Statistics["gamesPlayed"]) + 1 + "";
        config.Statistics["enemiesKilled"] = int.Parse(config.Statistics["enemiesKilled"]) + enemiesKilled + "";
        enemiesKilled = 0;
        config.SaveStats();
    }
    public static void KillEnemy(Enemy enemy) 
    {
        Elements.Remove(enemy);
        GameConfig.enemiesLeft--;
        GameConfig.enemiesKilled++;
    }
}
