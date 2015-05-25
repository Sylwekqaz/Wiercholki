using System;
using System.Windows.Forms;

namespace GraphPanel
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
        public Graph Graph { get; private set; }

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
                            _selectedVertex = Graph.GetVertex(e.Location);
                            if (_selectedVertex != null)
                            {
                                _panelState = PanelStates.MovingVertex;
                                _selectedEdge = null;
                                BottomMenu.SelectedIndex = 3;
                                BottomMenu_SelectedIndexChanged(null, null);
                                return;
                            }
                            _selectedEdge = Graph.GetEdge(e.Location);
                            if (_selectedEdge != null)
                            {
                                tbEditEdgeValue.Text = _selectedEdge.Value.ToString();
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
                            Graph.AddVertex(e.Location);
                            break;
                        case BtnStates.AddEdge:

                            var startVertex = Graph.GetVertex(e.Location);
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


                    var endVertex = Graph.GetVertex(e.Location);
                    if (endVertex != null)
                    {
                        int result;
                        int.TryParse(tbAddEdgeValue.Text, out result);

                        Graph.AddEdge(_selectedVertex, endVertex, result);

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