using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawbutton_Click(object sender, EventArgs e)
        {

            Graphics formGraphics = this.CreateGraphics();
            Pen drawpen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawbrush = new SolidBrush(Color.Red);
            fg.DrawString("alifornia patriots", drawFont, drawBrush, 125, 130);
            drawpen.Color = Color.FromArgb(150, 150, 150, 0);
            formGraphics.DrawArc(drawpen, 120, 120, 50, 40, 20, 300);



           
        }
    }
}
