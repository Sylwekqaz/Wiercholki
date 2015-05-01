using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            graphPanel1.Graph.AllowLoopEdges = false;
            graphPanel1.Graph.AllowMultipleEdge = false;
        }

        private void graphPanel1_Load(object sender, EventArgs e)
        {

        }


        private int[,] StwórzMacierzSąciedzctwa(int dimension)  
        {
            throw new NotImplementedException();
            
        }


        private void WgrajMacierzSąciedzctwa(int[,] macierz)
        {
            throw new NotImplementedException();
        }





    }
}
