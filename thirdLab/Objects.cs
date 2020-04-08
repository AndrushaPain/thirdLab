using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace thirdLab
{
    public class Planet
    {
        public int radius = 0;
        public bool atmosphere = false;
        public int gravity = 0;
    }
    public enum StarColor { white, blue, yellow, red, orange }
    public class Star 
    {
        public int density = 0;
        public StarColor color = StarColor.white;
        public int temperature = 0;
    }
    public class Comet
    {
        public int passageThroughSS = 0;
        public string name = "Comet";

    }
}