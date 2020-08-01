using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintproject
{
    public partial class Form1 : Form

    {
        private readonly Bitmap bmp = new Bitmap(1024, 768);
        private readonly Pen p = new Pen(Color.Black, 5);
        private readonly bool drawing = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1.InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Drawing_paint_app)
                Drawing_paint_app = false;
            else
            Drawing_paint_app = true;

        }
    }
   
