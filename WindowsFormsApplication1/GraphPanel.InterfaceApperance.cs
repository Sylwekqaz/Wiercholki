using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class GraphPanel
    {
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

                _panelState = PanelStates.Idle;
                _selectedVertex = null;
                _selectedEdge = null;

                BottomMenu.SelectTab((int) value);
                Redraw();
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

        private void BtnSelectClick(object sender, EventArgs e)
        {
            BtnState = BtnStates.Select;
        }

        private void BtnAddVertexClick(object sender, EventArgs e)
        {
            BtnState = BtnStates.AddVertex;
        }

        private void BtnAddEdgeClick(object sender, EventArgs e)
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
                                _selectedEdge = null;
                                BottomMenu.SelectedIndex = 3;
                                BottomMenu_SelectedIndexChanged(null, null);
                                return;
                            }
                            _selectedEdge = _graph.GetEdge(e.Location);
                            if (_selectedEdge != null)
                            {
                                BottomMenu.SelectedIndex = 4;
                            }
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
                    BottomMenu_SelectedIndexChanged(null, null);
                    Redraw();
                    break;
                case PanelStates.AddingEdge:
                    DrawTempEdge(e.Location);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}