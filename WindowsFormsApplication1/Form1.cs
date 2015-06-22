using System;
using System.Windows.Forms;

namespace FloydWarshall
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





    }
}
