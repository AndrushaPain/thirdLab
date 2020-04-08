using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdLab
{
    public partial class Form1 : Form
    {
        List<SpaceObject> spaceObjectList = new List<SpaceObject>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.spaceObjectList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то планета
                        this.spaceObjectList.Add(new Planet());
                        break;
                    case 1: // если 1 то звезда
                        this.spaceObjectList.Add(new Star());
                        break;
                    case 2: // если 2 то комета
                        this.spaceObjectList.Add(new Comet());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int planetsCount = 0;
            int starsCount = 0;
            int cometsCount = 0;

            // пройдемся по всему списку
            foreach (var spaceObject in this.spaceObjectList)
            {
                 // проверяем какой именно объект
                if (spaceObject is Planet) 
                {
                    planetsCount += 1;
                }
                else if (spaceObject is Star)
                {
                    starsCount += 1;
                }
                else if (spaceObject is Comet)
                {
                    cometsCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Планета\tЗвезда\tКомета"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", planetsCount, starsCount, cometsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.spaceObjectList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            // взяли первый объект
            var spaceObject = this.spaceObjectList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса
            this.spaceObjectList.RemoveAt(0);

            // предложим покупателю его объект
            if (spaceObject is Planet)
            {
                txtOut.Text = "Планета";
            }
            else if (spaceObject is Star)
            {
                txtOut.Text = "Звезда";
            }
            else if (spaceObject is Comet)
            {
                txtOut.Text = "Комета";
            }

            // обновим информацию о количестве объектов на форме
            ShowInfo();
        }
    }
}
