using System.Windows.Forms;

namespace Rikoshet
{
    internal static class Program
    {
        private static Size[] resolutions = new Size[3] { new Size(720, 480), new Size(1280, 720), new Size(1920, 1080) };
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 myForm = new Form1(resolutions[1]);
     
            Application.Run(myForm);
        }
    }
}