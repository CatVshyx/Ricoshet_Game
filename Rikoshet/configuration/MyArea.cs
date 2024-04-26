using Rikoshet;
using Rikoshet.configuration;
using System;
using System.Xml.Linq;

public class MyArea : PictureBox
{
    private bool isMouseDown = false;

    private Point userStart;

    private Point userEnd;

    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    private Form1 form;

    public MyArea(Form1 form) 
    {
        Dock = DockStyle.Fill;
        BackColor = Color.White;
        this.MouseClick += MyAreaMouseClick;
        this.MouseDown += MyAreaMouseDown;
        this.MouseUp += MyAreaMouseUp;
        this.MouseMove += MyAreaMouseMove;
        this.form = form;

        timer.Interval = 1000 / 60;
        timer.Tick += new EventHandler(TimerCallback);
    }
    
    private void MyAreaMouseClick(object sender, MouseEventArgs e)
    {
        Point clickLocation = e.Location;
        if (GameConfig.HandleClicks(clickLocation)) 
        {
            this.Invalidate();
        }
    }

    private void MyAreaMouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
       
        this.userStart = e.Location;
        this.userEnd = e.Location;
        isMouseDown = true;
        timer.Stop();
    }

    private void MyAreaMouseUp(object sender, MouseEventArgs e)
    {
        
        if (e.Button != MouseButtons.Left) return;
        if (GameConfig.UserAttempts <= 0) 
        {
            StopGameProcesses(false);
            return;
        }

        isMouseDown = false;
        GameConfig.laser.X = userStart.X;
        GameConfig.laser.Y = userStart.Y;

        double radians = MathHelper.CalculateAngleBetweenTwoDots(userStart.X, userStart.Y, userEnd.X, userEnd.Y);
        GameConfig.laser.SetLaserAngle(radians);
        timer.Start();
        
        GameConfig.UserAttempts -= 1;
    }

    private void MyAreaMouseMove(object sender, MouseEventArgs e)
    {
        if ( isMouseDown )
        {
            this.userEnd = e.Location;
            this.Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        PaintArea(e);
        PaintElements(e);
    }

    private void PaintArea(PaintEventArgs e)
    {
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        using (Brush brush = new SolidBrush(Color.Black))
        {
            e.Graphics.FillRectangle(brush, rect);
        }
        using (Pen pen = new Pen(Color.Green, 10))
        {
            e.Graphics.DrawRectangle(pen, rect);
        }
    }

    void UpdateLaser()
    {
        Laser local = GameConfig.laser;
        local.X = (int)(local.X + local.DirectionX);
        local.Y = (int)(local.Y + local.DirectionY);
        // Чи вийшов наш лазер за кордони, якщо так, вимикаємо його
        if (local.X  < -10 || local.X > this.Width) timer.Stop();
        if (local.Y < -10 || local.Y > this.Height) timer.Stop();

        // Чи стикнувся наш лазер чимось
        Element el = GameConfig.IsCollised(local);
        if (el == null) return;
        if (el is Enemy)
        {
            onEnemyKilled(el);
            return;
        }
        
        GameConfig.laser.MakeRikoshet();
    }
  
    void TimerCallback(object sender, EventArgs e)
    {
        UpdateLaser();
        this.Invalidate();
        return;
    }


    private void onEnemyKilled(Element el) 
    {
        System.Diagnostics.Debug.WriteLine("Enemy was touched and killed at coords" + el.X + " " + el.Y);
        GameConfig.KillEnemy((Enemy)el);
        if (GameConfig.enemiesLeft > 0) return;

        StopGameProcesses(true);
    }
    private void StopGameProcesses(Boolean hasWon) 
    {
        System.Diagnostics.Debug.WriteLine($"User attempts left:{GameConfig.UserAttempts}");
        
        Thread.Sleep(1000);
        GameConfig.ResetConfigurations();
        isMouseDown = false;
        timer.Stop();
        

        if (hasWon) 
        {
            GameConfig.config.Statistics["wins"] = int.Parse(GameConfig.config.Statistics["wins"]) + 1 + "";
        }
        else 
        {
            GameConfig.config.Statistics["loses"] = int.Parse(GameConfig.config.Statistics["loses"]) + 1 + "";
        }
        form.OpenInfo(hasWon ? "YOU WON!!!" : "You lose");
        
        form.EnterMenu();
        
    }
    private void PaintElements(PaintEventArgs e)
    {
        if (GameConfig.Elements == null)
            return;
        
        foreach (Element element in GameConfig.Elements)
        {
            
            if (element is Enemy)
            {

                e.Graphics.DrawImage(AssetsClass.AssetsEnemies[((Enemy) element).ImageId ], new Point(element.X, element.Y));
            }
            else if (element is Mirror)
            {
                Mirror mirror = (Mirror)element;
                DrawImageOnAngle(e, mirror, mirror.Angle, AssetsClass.MirrorImage);
            }
            else
            {
                Rectangle rect = new Rectangle(element.X, element.Y, element.Width, element.Height);
                
                using (Brush brush = new SolidBrush(((Star) element).Color ) )
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }
        if (this.isMouseDown)
        {
            using (Pen pen = new Pen(Color.Red, 3))
            {
                e.Graphics.DrawLine(pen, userStart, userEnd);
            }
        }
        DrawImageOnAngle(e, GameConfig.laser,(float)
            MathHelper.ConvertRadiansToDegrees(GameConfig.laser.Angle), AssetsClass.LaserImage);

    }
    private void DrawImageOnAngle(PaintEventArgs e,Element el, float angle, Image image) 
    {
        System.Drawing.Drawing2D.Matrix oldMatrix = e.Graphics.Transform;
        e.Graphics.TranslateTransform(el.X + image.Width / 2, el.Y + image.Height / 2);
        e.Graphics.RotateTransform(angle);
        e.Graphics.DrawImage(image, new Point(-image.Width / 2, -image.Height / 2));
        e.Graphics.Transform = oldMatrix;
    }
}
