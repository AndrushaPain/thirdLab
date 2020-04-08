using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdLab
{
    public class SpaceObject
    {
        public static Random rnd = new Random();
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
            str += base.GetInfo();
            str += String.Format("\nРадиус: {0}", this.radius);
            str += String.Format("\nАтмосфера: {0}", this.atmosphere);
            str += String.Format("\nСила притяжения: {0}", this.gravity);
            return str;
        }
        public static Planet Generate()
        {
            return new Planet
            {
                remoteness = rnd.Next(0, 10000),
                radius = rnd.Next(0, 1000),
                atmosphere = rnd.Next() % 2 == 0,
                gravity = rnd.Next(1, 100)
            };
        }
    }
    public enum StarColor { white, blue, yellow, red, orange } //варианты цветов звезды
    public class Star : SpaceObject
    {
        public int density = 0;
        public StarColor color = StarColor.white;
        public int temperature = 0;
        public override String GetInfo()
        {
            var str = "Я звезда";
            str += base.GetInfo();
            str += String.Format("\nПлотность: {0}", this.density);
            str += String.Format("\nЦвет: {0}", this.color);
            str += String.Format("\nТемпература: {0}", this.temperature);
            return str;
        }
        public static Star Generate()
        {
            return new Star
            {
                remoteness = rnd.Next(0, 10000),
                density = rnd.Next(1000, 1000000),
                color = (StarColor)rnd.Next(5),
                temperature = rnd.Next(-1000, 1000),
            };
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
            str += String.Format("\nПериод прохождения через солнечную систему: {0}", this.passageThroughSS);
            str += String.Format("\nНазвание: {0}", this.name);
            return str;
        }
        public static Comet Generate()
        {
            return new Comet
            {
                name = "Комета " + rnd.Next(1, 10000),
                remoteness = rnd.Next(0, 10000),
                passageThroughSS = rnd.Next(1, 1000),
            };
        }
    }
}