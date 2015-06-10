using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GraphPanel
{
    public partial class GraphPanel : UserControl
    {
        double[,] FloidMarshalMatrix;
        int?[,] FloidMarshalMatrixPrev;

        List<Edge> selectedEdges = new List<Edge>();
        Vertex[] selectedVertices = new Vertex[2];


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
            Graph.FloydWarschalAlghoritm(out FloidMarshalMatrix,out FloidMarshalMatrixPrev);
            CheckNegativeCycle();
        }


        private void CheckNegativeCycle()
        {
            

            for (int i = 0; i < FloidMarshalMatrix.GetLength(0); i++)
            {
                if (FloidMarshalMatrix[i, i] != 0)
                {
                    if (!tbEditEdgeValue.Focus())
                    {
                        MessageBox.Show("Wykryto ujemny cykl", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        selectedEdges.Clear();

                    }

                    return;
                }
            }
        }

        private List<Edge> GetWay(int start, int end)
        {
            if (!FloidMarshalMatrixPrev[start, end].HasValue)
            {
                return new List<Edge>();
            }
            return GetWay(start, end, new List<Edge>());
        }
        private List<Edge> GetWay(int start, int end ,List<Edge> wayEdges  )
        {
            if (start==end)
            {
                return wayEdges;
            }

            int prev = FloidMarshalMatrixPrev[start, end].Value;


            GetWay(start, prev, wayEdges);
            wayEdges.Add(Graph.Edges.First(edge =>
            {
                return (
                    edge.StartVertex == Graph.Vertices[prev] &&
                    edge.EndVertex == Graph.Vertices[end]
                    )
                       ||
                       (
                           edge.EndVertex == Graph.Vertices[prev]
                           && edge.StartVertex == Graph.Vertices[end] &&
                           edge.Directed == false
                           );
            }));

            return wayEdges;

        }

        
    }
}