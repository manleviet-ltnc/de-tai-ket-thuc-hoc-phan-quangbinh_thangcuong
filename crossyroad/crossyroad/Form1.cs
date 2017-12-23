using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crossyroad
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }
        int x_Car1;
        int x_Car2;
        int x_Chicken;
        int y_Chicken;
        int KhoangCachGiua2Car = 200;
        int x_Cap1;

        private void frmGame_Load(object sender, EventArgs e)
        {
            ptbCar1.Size = new Size(145, 72);
            ptbCar2.Size = new Size(135, 77);
            ptbChicken.Size = new Size(75, 78);
            x_Cap1 = this.Width + 300;
            ptbCar1.Location = new Point(x_Cap1, x_Car1);
            x_Car1 = 500;
            ptbCar2.Location = new Point(x_Cap1, x_Car2);
            x_Car2 = (500 + x_Car1) + KhoangCachGiua2Car;
            x_Chicken = ptbChicken.Location.X;
            y_Chicken = ptbChicken.Location.Y;
            timer1.Interval = 10;
            timer2.Interval = 50;
         
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = ptbCar1.Location.X;
            int y = ptbCar1.Location.Y;

            x -= 8;

            if (x < 0) x = 500;

            ptbCar1.Location = new Point(x, y);
            y -= 10;

            if (y < 0) y = 600;
            ptbCar2.Location = new Point(x, y);


            //x_Cap1 -= 10;
            //ptbCar1.Location = new Point(x_Cap1, x_Car1);
            //ptbCar2.Location = new Point(x_Cap1, x_Car2);
            //if (x_Cap1 + ptbCar1.Width <= 0)
            //x_Cap1 = 500 + ptbCar2.Width + 200;
            //ptbCar1.Location = new Point(x_Cap1, x_Car1);
            //ptbCar2.Location = new Point(x_Cap1, x_Car2);

        }
        int dem = 0;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            dem++;
            if( dem % 2!=0)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }

        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Space)
            {
                y_Chicken -= 50;
            }
            if (e.KeyCode == Keys.Up)
                {
                    LenTren();

                }
                if (e.KeyCode == Keys.Down)
                {
                    XuongDuoi();
                }
                if(e.KeyCode == Keys.Left)
                {
                     SangTrai();
                 }
                if( e.KeyCode == Keys.Right)
                {
                     SangPhai();
                 }

            }
        private void LenTren()
        {

        }
        private void XuongDuoi()
        {

        }
        private void SangTrai()
        {

        }
        private void SangPhai()
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (y_Chicken >= 0)// + ptbChicken.Height <= this.Height)
            {
                y_Chicken -= 10;
                ptbChicken.Location = new Point(x_Chicken, y_Chicken);
            }
            else
                timer2.Stop();
        }
    }
}
