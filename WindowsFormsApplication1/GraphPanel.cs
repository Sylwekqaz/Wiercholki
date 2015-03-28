using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GraphPanel : UserControl
    {
        public GraphPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            BtnState = BtnStates.Select;
            _graph = new Graph();


            Workspace_Resize(null, null);
        }


        private Graphics _graphLayerGraphics;
        private Graphics _tempLayerGraphics;
        private Graphics _selectLayerGraphics;


        private Bitmap _graphLayerBitmap;
        private Bitmap _tempLayerBitmap;
        private Bitmap _selectLayerBitmap;

        public enum BtnStates
        {
            Select,
            AddVertex,
            AddEdge
        }


        private BtnStates _btnState;

        public BtnStates BtnState
        {
            get { return _btnState; }
            set
            {
                btnSelect.Enabled = value != BtnStates.Select;
                btnAddVertex.Enabled = value != BtnStates.AddVertex;
                btnAddEdge.Enabled = value != BtnStates.AddEdge;
                _btnState = value;
            }
        }

        private enum PanelStates
        {
            Idle,
            MovingVertex,
            AddingEdge
        }

        private PanelStates _panelState = PanelStates.Idle;


        private Vertex _selectedVertex;
        private Edge _selectedEdge;
        private Graph _graph;


        private void button1_Click(object sender, EventArgs e)
        {
            BtnState = BtnStates.Select;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnState = BtnStates.AddVertex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnState = BtnStates.AddEdge;
        }


        private void GrapchMouseDown(object sender, MouseEventArgs e)
        {
            switch (_panelState)
            {
                case PanelStates.Idle:
                    switch (BtnState)
                    {
                        case BtnStates.Select:
                            _selectedVertex = _graph.GetVertex(e.Location);
                            if (_selectedVertex != null)
                            {
                                _panelState = PanelStates.MovingVertex;
                                return;
                            }
                            _selectedEdge = _graph.GetEdge(e.Location);
                            break;
                        case BtnStates.AddVertex:
                            break;
                        case BtnStates.AddEdge:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                case PanelStates.MovingVertex:
                    break;
                case PanelStates.AddingEdge:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Redraw();
        }

        private void GrapchMouseUp(object sender, MouseEventArgs e)
        {
            switch (_panelState)
            {
                case PanelStates.Idle:
                    switch (BtnState)
                    {
                        case BtnStates.Select:


                            break;
                        case BtnStates.AddVertex:
                            _graph.AddVertex(e.Location);
                            break;
                        case BtnStates.AddEdge:

                            var startVertex = _graph.GetVertex(e.Location);
                            if (startVertex != null)
                            {
                                _selectedVertex = startVertex;
                                _panelState = PanelStates.AddingEdge;
                            }


                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                case PanelStates.MovingVertex:
                    _panelState = PanelStates.Idle;
                    break;
                case PanelStates.AddingEdge:
                    if (e.Button == MouseButtons.Right)
                    {
                        _panelState = PanelStates.Idle;
                        return;
                    }


                    var endVertex = _graph.GetVertex(e.Location);
                    if (endVertex != null)
                    {
                        _graph.AddEdge(_selectedVertex, endVertex);

                        _panelState = PanelStates.Idle;
                        _selectedVertex = null;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Redraw();
        }

        private void GrapchMouseMove(object sender, MouseEventArgs e)
        {
            switch (_panelState)
            {
                case PanelStates.Idle:
                    break;
                case PanelStates.MovingVertex:
                    _selectedVertex.Location = e.Location;
                    Redraw();
                    break;
                case PanelStates.AddingEdge:
                    DrawTempEdge(e.Location);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        //private Graphics graphLayerGraphics;
        //private Graphics tempLayerGraphics;
        //private Graphics selectLayerGraphics;
        private readonly Pen _verticlePen = new Pen(Color.Black, 1);
        private readonly Pen _verticleSelectedPen = new Pen(Color.DeepSkyBlue, 3);
        private readonly Pen _edgeDirectedPen = new Pen(Color.Black, 1) {CustomEndCap = new AdjustableArrowCap(3, 7)};

        private readonly Pen _edgeDirectedSelectedPen = new Pen(Color.DeepSkyBlue, 4)
        {
            CustomEndCap = new AdjustableArrowCap(3, 7)
        };

        private readonly Pen _edgePen = new Pen(Color.Black, 1);
        private readonly Pen _edgeSelectedPen = new Pen(Color.DeepSkyBlue, 4);


        private void DrawTempEdge(PointF location)
        {
            Vertex closestPoint = _graph.GetVertex(location);
            if (closestPoint != null)
            {
                location = closestPoint.Location;
            }
            _tempLayerGraphics.Clear(Color.Transparent);
            _tempLayerGraphics.DrawLine(_edgeSelectedPen, _selectedVertex.Location, location);
            Redraw(true);
        }

        private void Redraw(bool fastRedraw = false)
        {
            if (!fastRedraw)
            {
                _graphLayerGraphics.Clear(Color.Transparent);
                _tempLayerGraphics.Clear(Color.Transparent);
                _selectLayerGraphics.Clear(Color.Transparent);

                foreach (Vertex vertex in _graph.Vertices)
                {
                    var rectangle = new RectangleF(vertex.Location.X - 5, vertex.Location.Y - 5, 10, 10);

                    _graphLayerGraphics.DrawEllipse(vertex == _selectedVertex ? _verticleSelectedPen : _verticlePen,
                        rectangle);
                }


                foreach (Edge edge in _graph.Edges)
                {
                    _graph.CurveEdges();
                    _graphLayerGraphics.DrawPath(edge.Directed ? _edgeDirectedPen : _edgePen, edge.Path);
                    if (edge == _selectedEdge)
                    {
                        _selectLayerGraphics.DrawPath(edge.Directed ? _edgeDirectedSelectedPen : _edgeSelectedPen,
                            edge.Path);
                    }
                }
            }


            Graphics workspaceGraphics = Workspace.CreateGraphics();
            Bitmap tempBitmap = new Bitmap(Workspace.Width, Workspace.Height);
            Graphics tempGraphics = Graphics.FromImage(tempBitmap);
            tempGraphics.Clear(Color.White);

            tempGraphics.DrawImage(_selectLayerBitmap, 0, 0);
            tempGraphics.DrawImage(_graphLayerBitmap, 0, 0);
            tempGraphics.DrawImage(_tempLayerBitmap, 0, 0);
            workspaceGraphics.DrawImage(tempBitmap, 0, 0);
            //Workspace.ResumeLayout();
            //Workspace.Update();

            //Workspace.setstyle;
        }


        private void Workspace_Resize(object sender, EventArgs e)
        {
            _graphLayerBitmap = new Bitmap(Workspace.Width, Workspace.Height);
            _tempLayerBitmap = new Bitmap(Workspace.Width, Workspace.Height);
            _selectLayerBitmap = new Bitmap(Workspace.Width, Workspace.Height);

            _graphLayerBitmap.MakeTransparent();
            _tempLayerBitmap.MakeTransparent();
            _selectLayerBitmap.MakeTransparent();


            _graphLayerGraphics = Graphics.FromImage(_graphLayerBitmap);
            _tempLayerGraphics = Graphics.FromImage(_tempLayerBitmap);
            _selectLayerGraphics = Graphics.FromImage(_selectLayerBitmap);

            _graphLayerGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            _tempLayerGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            _selectLayerGraphics.SmoothingMode = SmoothingMode.AntiAlias;

            Redraw();
        }

        private void Workspace_Paint(object sender, PaintEventArgs e)
        {
            Redraw();
        }
    }
}