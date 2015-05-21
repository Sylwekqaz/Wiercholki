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
                for(int indeks =0; indeks<matrix.GetLength(0);indeks++)
                {
                    for (int indeks2 = 0; indeks2 < matrix.GetLength(1);indeks2++)
                    {
                        matrix[indeks, indeks2] = 100000;
                    }
                }
            Graph.FloydWarschalAlghoritm(matrix);
        }

        private void tbEditEdgeValue_TextChanged(object sender, System.EventArgs e)
        {
            int result;
            int.TryParse(tbEditEdgeValue.Text, out result);
            _selectedEdge.Value = result;
        }
    }
}