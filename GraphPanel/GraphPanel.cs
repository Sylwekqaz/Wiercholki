using System.Threading;
using System.Windows.Forms;

namespace GraphPanel
{
    public partial class GraphPanel : UserControl
    {
        double[,] FloidMarshalMatrix;


        public GraphPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);


            Graph = new Graph(){AllowLoopEdges = true,AllowMultipleEdge = true,DirectedEdges = true};


            Workspace_Resize(null, null);
            BtnState = BtnStates.Select;
        }

 


        private void UpdateFloidMarshal()
        {
            FloidMarshalMatrix = Graph.FloydWarschalAlghoritm();

        }




        
    }
}