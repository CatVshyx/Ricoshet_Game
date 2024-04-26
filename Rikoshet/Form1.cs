using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rikoshet
{
    public partial class Form1 : Form
    {

        private MyArea area;

        private static Size[] resolutions = new Size[3] { new Size(720, 480), new Size(1280, 720), new Size(1920, 1080) };

        public Form1(Size res)
        {
            InitializeComponent();
            this.Size = res;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Resize += On_Resize;
            this.KeyPreview = true;
            this.area = new MyArea(this);


            CenterPanels();
            this.Icon = new Icon("../../../assets/game-icon.ico");

            foreach (Size cur in resolutions)
            {
                resolutionsList.Items.Add($"{cur.Width}x{cur.Height}");
            }

            resolutionsList.SelectedIndex = 1;
        }
        private void CenterPanels()
        {
            mainPanel.Location = new Point((this.Width - mainPanel.Width) / 2, (this.Height - mainPanel.Height) / 2);
            panel2.Location = new Point((this.Width - panel2.Width) / 2, (this.Height - panel2.Height) / 2);
            settingsPanel.Location = new Point((this.Width - settingsPanel.Width) / 2, (this.Height - settingsPanel.Height) / 2);
            InfoPanel.Location = new Point((this.Width - InfoPanel.Width) / 2, (this.Height - InfoPanel.Height) / 2);
        }
        private void On_Resize(object sender, EventArgs e)
        {
            area.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void EnterGamePanel(object sender, EventArgs e)
        {
            GameConfig.InitializeElements(this.Width, this.Height);
            this.Controls.Add(area);
            this.Controls.Remove(mainPanel);
        }
        public void EnterMenu()
        {
            this.Controls.Add(mainPanel);
            this.Controls.Remove(area);

        }

        private void OpenStatistics(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Statistics open");
            panel2.Visible = true;
            
            try
            {
                System.Diagnostics.Debug.WriteLine(GameConfig.config.Statistics.Values);
                gamesStatistic.Text = "Games played:" + GameConfig.config.Statistics["gamesPlayed"];
                enemiesStatistic.Text = "Enemies killed:" + GameConfig.config.Statistics["enemiesKilled"];
                winsText.Text = "Wins:" + GameConfig.config.Statistics["wins"];
                losesText.Text = "Loses:" + GameConfig.config.Statistics["loses"];
            }
            catch (System.Collections.Generic.KeyNotFoundException ex) { }
            
        }

        private void CloseStatistics(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Statistics closed");
            panel2.Visible = false;
        }

        private void CloseSettings(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Settings closed");
            settingsPanel.Visible = false;
        }
        private void OpenSettings(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Settings open");
            settingsPanel.Visible = true;
            panel2.Visible = false;
        }

        private void onSelectedOptionResolution(object sender, EventArgs e)
        {
            int selectedOption = resolutionsList.SelectedIndex;
            this.Size = resolutions[selectedOption];
            area.Invalidate();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void OpenInfo(string text)
        {
            InfoPanel.Visible = true;
            infoText.Text = text;
        }
        private void CloseInfo(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
        }
    }
}