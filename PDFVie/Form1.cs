using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFVie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            



            axAcroPDF1.src = fd.FileName;
            //axAcroPDF1.l


            axAcroPDF1.setViewRect(10, 10, 100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // axAcroPDF1.Document = OpenDocument(@"C:\work\20171018132454082.pdf");
            //pdfViewer1.Renderer.Cursor = Cursors.Help;
            //pdfViewer1.Cursor = Cursors.Cross;
        }

        private void axAcroPDF1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void axAcroPDF1_MouseCaptureChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("MouseCaptureChanged");
        }

        private void axAcroPDF1_RegionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("RegionChanged");
        }

        private void axAcroPDF1_Move(object sender, EventArgs e)
        {
            MessageBox.Show("Move");
        }

        private void axAcroPDF1_LocationChanged(object sender, EventArgs e)
        {
            MessageBox.Show("LocationChange");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Rectangle xxx = axAcroPDF1.;


            //textBox1.Text = xxx.X.ToString();
            


        }
    }
}
