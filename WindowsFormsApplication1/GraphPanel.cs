using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GraphPanel : UserControl
    {
        public GraphPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);


            _graph = new Graph(){AllowLoopEdges = true,AllowMultipleEdge = true,DirectedEdges = true};


            Workspace_Resize(null, null);
            BtnState = BtnStates.Select;
        }
    }
}