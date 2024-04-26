using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikoshet.configuration
{
    public class AssetsClass
    {
        private static Image[] assetsEnemy = new Image[] {
            new Bitmap(Properties.Resources.enemy_1, new Size(100, 100)),
            new Bitmap(Properties.Resources.enemy_2, new Size(100, 100)),
            new Bitmap(Properties.Resources.enemy_3, new Size(100, 100))
        };

        private static Image mirrorImage = new Bitmap(
            Properties.Resources.mirror, new Size(100, 50)
        );
        private static Image laserImage = new Bitmap(
            Properties.Resources.laser, new Size(40, 30)
        );
        public static Image MirrorImage
        {
            get { return mirrorImage; }
        }
        public static Image LaserImage
        {
            get { return laserImage; }
        }
        public static Image[] AssetsEnemies
        {
            get { return assetsEnemy; }
        }

    }
}
