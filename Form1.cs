using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moorhuhn_Klon
{
    /*
     * TODO: ganz viele geier die für 2 sekunden aufploppen, würmer aus dem boden
     */
    public partial class Form1 : Form
    {
        int points = 0;
        int difference = 0;
        Timer timer = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();
        public Form1()
        {
            InitializeComponent();
            labelPoints.Text = points.ToString();
            labelPoints.Font = new Font(labelPoints.Font.Name, 32);

            newLeopard();

            timer.Interval = 15;
            timer.Tick += timer_Tick;
            timer.Start();
            moveLeopard();

            timer2.Interval = 30;
            timer2.Tick += timer_Tick2;
            timer2.Start();
            moveLeopard();

            timer3.Interval = 5;
            timer3.Tick += timer_Tick3;
            timer3.Start();
            moveLeopard();
        }

        void newLeopard()
        {
            var leopard = new PictureBox
            {
                Name = "pb_leopard",
                Size = new Size(133, 50),
                Location = new Point(10, 646),
                Image = Image.FromFile(@"C:\Development\leopard_gif.gif"),
                BackColor = Color.Transparent
            };
            this.Controls.Add(leopard);

            timer.Interval = 15;
            timer.Tick += timer_Tick;
            timer.Start();

            difference = 5;
        }

        void moveLeopard()
        {
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            timer.Start();

            difference = 5;
        }        

        void timer_Tick(object sender, EventArgs e)
        {
            pB_leopard1.Left += difference;
          
        }

        void timer_Tick2(object sender, EventArgs e)
        {
            
            pB_leopard2.Left += difference;
            
        }

        void timer_Tick3(object sender, EventArgs e)
        {
            
            pB_leopard3.Left += difference;
        }

        private void hitLeopard(object sender, EventArgs e)
        {
            pB_leopard1.Visible = false;
            points = points + 3;
            labelPoints.Text = points.ToString();
        }

        private void hitLeopard2(object sender, EventArgs e)
        {
            pB_leopard2.Visible = false;
            points = points + 3;
            labelPoints.Text = points.ToString();
        }

        private void hitLeopard3(object sender, EventArgs e)
        {
            pB_leopard3.Visible = false;
            points = points + 3;
            labelPoints.Text = points.ToString();
        }
    }
}
