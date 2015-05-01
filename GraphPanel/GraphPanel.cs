using System.Threading;
using System.Windows.Forms;

namespace GraphPanel
{
    public partial class GraphPanel : UserControl
    {
        public GraphPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);


            Graph = new Graph(){AllowLoopEdges = true,AllowMultipleEdge = true,DirectedEdges = true};


            Workspace_Resize(null, null);
            BtnState = BtnStates.Select;
        }

        private void btnGenerateMatrix_Click(object sender, System.EventArgs e)
        {
            int dim = Graph.CountVerticles();
            int? [,] matrix = new int?[dim, dim];
            Graph.FloydWarschalAlghoritm(matrix);
        }
    }
}