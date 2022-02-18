using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7segment
{
    public partial class Base : Form
    {

        public DateTime time;
        public string hour, min, sec, hour1, hour2, min1, min2, sec1, sec2;
        public Color timeColor = Color.Red, backColor = Color.Black;








        private void Timer_Tick(object sender, EventArgs e)
        {
            Clock_Update();
        }

        public Button[] B1, B2, B3, B4, B5, B6;

        private void Base_Load(object sender, EventArgs e)
        {
            //hour
            B1 = new Button[7] { HLB1, HLB2, HLB7, HLB6, HLB3, HLB5, HLB4 };
            B2 = new Button[7] { HRB1, HRB2, HRB7, HRB6, HRB3, HRB5, HRB4 };
            //min
            B3 = new Button[7] { MLB1, MLB2, MLB7, MLB6, MLB3, MLB5, MLB4 };
            B4 = new Button[7] { MRB1, MRB2, MRB7, MRB6, MRB3, MRB5, MRB4 };
            //sec
            B5 = new Button[7] { SLB1, SLB2, SLB7, SLB6, SLB3, SLB5, SLB4 };
            B6 = new Button[7] { SRB1, SRB2, SRB7, SRB6, SRB3, SRB5, SRB4 };
        }



        public Base()
        {
            InitializeComponent();
        }

        public void Update_Segment(Button[] buttons, string number)
        {
            switch (number)
            {
                case "0":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "1":
                    buttons[0].BackColor = backColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "2":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = backColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "3":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "4":
                    buttons[0].BackColor = backColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "5":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = backColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "6":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = backColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "7":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "8":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "9":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
            }
        }


        public void Clock_Update()
        {
            time = DateTime.Now;
            hour = $"{time:hh}";
            min = $"{time:mm}";
            sec = $"{time:ss}";
            hour1 = hour.Substring(0, 1);
            hour2 = hour.Substring(1, 1);
            min1 = min.Substring(0, 1);
            min2 = min.Substring(1, 1);
            sec1 = sec.Substring(0, 1);
            sec2 = sec.Substring(1, 1);
            Update_Segment(B1, hour1);
            Update_Segment(B2, hour2);
            Update_Segment(B3, min1);
            Update_Segment(B4, min2);
            Update_Segment(B5, sec1);
            Update_Segment(B6, sec2);
        }



    }
}
