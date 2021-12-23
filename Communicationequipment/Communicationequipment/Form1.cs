using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mrrstation;

namespace Communicationequipment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Mrrstation mrrstation = new Mrrstation();   // Mobile radio relay stations
                label5.Text = mrrstation.sdistance.ToString();
                richTextBox1.Text = mrrstation.info.ToString();
                pictureBox1.Image = Communicationequipment.Properties.Resources._1;
            }
            if (radioButton2.Checked)
            {
                Radiostation radiostation = new Radiostation();
                label5.Text = radiostation.sdistance.ToString();
                richTextBox1.Text = radiostation.info.ToString();
                pictureBox1.Image = Communicationequipment.Properties.Resources._2;
            }
            if (radioButton3.Checked)
            {
                Walkietalkie walkietalkie = new Walkietalkie();   
                label5.Text = walkietalkie.sdistance.ToString();
                richTextBox1.Text = walkietalkie.info.ToString();
                pictureBox1.Image = Communicationequipment.Properties.Resources._3;
            }
            if (radioButton4.Checked)
            {
                Smartphone smartphone = new Smartphone();
                label5.Text = smartphone.sdistance.ToString();
                richTextBox1.Text = smartphone.info.ToString();
                pictureBox1.Image = Communicationequipment.Properties.Resources._4;
            }
            if (radioButton5.Checked)
            {
                Megaphone megaphone = new Megaphone();
                label5.Text = megaphone.sdistance.ToString();
                richTextBox1.Text = megaphone.info.ToString();
                pictureBox1.Image = Communicationequipment.Properties.Resources._5;
            }
            if (radioButton6.Checked)
            {
                Searchlight searchlight = new Searchlight();
                label5.Text = searchlight.sdistance.ToString();
                richTextBox1.Text = searchlight.info.ToString();
                pictureBox1.Image = Communicationequipment.Properties.Resources._6;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
abstract class Communication
{
    internal string info { get; set; } //info
    internal int sdistance { get; set; } //Signal distance
}

internal class Mrrstation : Communication                        //Mobile radio relay stations
{
    protected internal int maxHighofmast;                 //макс висота мачти
    protected internal int numberAdevices;                 //кількість antenna devices
   
    protected internal Mrrstation()
    {
        info = "Radio relay communication (RRL) is a type of radio communication formed as a result of the operation of a chain of receiving and transmitting radio stations. Terrestrial radio relay communication operates on millimeter, centimeter and decimeter waves. RRL networks play an important role in cellular communications, as they allow you to transfer very large volumes of traffic at minimal cost.";
        sdistance = 50000;
        maxHighofmast = 0;
        numberAdevices = 0;
    }
    protected internal Mrrstation(int Numberofhigh)
    {
        info = "Radio relay communication (RRL) is a type of radio communication formed as a result of the operation of a chain of receiving and transmitting radio stations. Terrestrial radio relay communication operates on millimeter, centimeter and decimeter waves. RRL networks play an important role in cellular communications, as they allow you to transfer very large volumes of traffic at minimal cost.";
        sdistance = 100000;
        maxHighofmast = Numberofhigh;
        numberAdevices = 0;
    }
    protected internal void loadDevices()
    {
        if (numberAdevices < numberAdevices)
        {
            numberAdevices = +4;
        }
        else { Console.WriteLine("All places full"); }
    }
    protected internal void unloadDevices()
    {
        if (numberAdevices > 0)
        {
            numberAdevices = -4;
        }
        else { Console.WriteLine("All places empty"); }
    }
    protected internal int getnumberDevices()
    {
        return (numberAdevices);
    }
    internal class Radiostation : Communication
    {
        protected string armourlevel;
        public Radiostation()
        {
            info = "Стандартна пожежна машина доставляє пожежників до місця події";
            sdistance = 15000;
            armourlevel = "PM 3";
        }
        public string getInfo
        {
            get
            {
                return info;
            }
        }
    }


    abstract class Public : Communication                   
    {
        private protected string function;
    }

    class Walkietalkie : Public          
    {
        public Walkietalkie()
        {
            info = "A walkie-talkie, more formally known as a handheld transceiver (HT), is a hand-held, portable, two-way radio transceiver. Its development during the Second World War has been variously credited to Donald Hings, radio engineer Alfred J. Gross, Henryk Magnuski and engineering teams at Motorola.";
            function = "To provide quick access to emergency and information channels.";
            sdistance = 7000;
        }
        public string getFunction
        {
            get
            {
                return function;
            }
        }
    }
    class Smartphone : Public         
    {
        public Smartphone()
        {
            info = "A smartphone is a portable device that combines mobile telephone and computing functions into one unit.";
            function = "A smartphone is a mobile phone that can also be used as a computer. They work as a computer but are mobile devices small enough to fit in a user's hand.";
            sdistance = 1000000;
        }
        public string getFunction
        {
            get
            {
                return function;
            }
        }
    }
    class Special : Communication              
    {
        internal string type;
    }
    class Megaphone : Special        
    {
        public int maximumVolume;                  
        public Megaphone(int MaximumVolume)
        {
            info = "A megaphone is usually a portable or portable cone-shaped sound horn used to amplify a person's voice or other sounds and direct them in a given direction.";
            maximumVolume = MaximumVolume;
            type = "electric";
            sdistance = 1;
        }
        public string getType()
        {
            return type;
        }

    }
    class Searchlight : Special              //гусеничний автокран
    {
        public string location;                //Тип гусениці
        public Searchlight(string Location)
        {
            info = "A searchlight is an apparatus that combines an extremely bright source with a mirrored parabolic reflector to project a powerful beam of light of approximately parallel rays in a particular direction.";
            location = Location;
            type = "Lighthouse searchlight";
            sdistance = 27000;
        }
        public string getType()
        {
            return type;
        }
    }

}