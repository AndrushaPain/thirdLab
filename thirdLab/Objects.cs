using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace thirdLab
{
    public class SpaceObject {
        public int remoteness = 0;
        public virtual String GetInfo()
    {
        
           var str = String.Format("\nУдалённость от Земли: {0}", this.remoteness);
            return str;
        }
        
    }
    public class Planet : SpaceObject
    {
        
        public int radius = 0;
        public bool atmosphere = false;
        public int gravity = 0;
        public override String GetInfo()
        {
            var str = "Я планета";
            str+= base.GetInfo();
            return str;
        }
    }

    public enum StarColor { white, blue, yellow, red, orange }
    public class Star : SpaceObject
    {
       
        public int density = 0;
        public StarColor color = StarColor.white;
        public int temperature = 0;
        public override String GetInfo()
        {
            var str = "Я звезда";
            str += base.GetInfo();
            return str;
        }
    }
    public class Comet : SpaceObject
    {
       
        public int passageThroughSS = 0;
        public string name = "Comet";
        public override String GetInfo()
        {
            var str = "Я комета";
            str += base.GetInfo();
            return str;
        }
    }
    
}