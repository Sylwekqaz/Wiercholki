using System;
using System.Drawing;
using System.Globalization;

namespace WindowsFormsApplication1
{
    partial class GraphPanel
    {
        private void BottomMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BottomMenu.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cbAutoCompleteGraph.Checked = _graph.AutoCompleteGraph;
                    break;
                case 2:
                    cbDirected.Checked = _graph.DirectedEdges;
                    break;
                case 3:
                    if (_selectedVertex == null)
                    {
                        BottomMenu.SelectedIndex = 0;
                    }
                    _autoFillInprogress = true;
                    // ReSharper disable once PossibleNullReferenceException
                    tbVertexLabel.Text = _selectedVertex.Label;
                    tbVertexX.Text = _selectedVertex.Location.X.ToString(CultureInfo.CurrentCulture);
                    tbVertexY.Text = _selectedVertex.Location.Y.ToString(CultureInfo.InvariantCulture);
                    lblVertexDegree.Text = _graph.GetVertexDegree(_selectedVertex).ToString();
                    _autoFillInprogress = false;
                    break;
                case 4:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void cbAutoCompleteGraph_CheckedChanged(object sender, EventArgs e)
        {
            _graph.AutoCompleteGraph = cbAutoCompleteGraph.Checked;
        }

        private void cbDirected_CheckedChanged(object sender, EventArgs e)
        {
            _graph.DirectedEdges = cbDirected.Checked;
        }

        private bool _autoFillInprogress;

        private void VertexTextChanged()
        {
            if (!_autoFillInprogress)
            {
                if (_selectedVertex == null)
                {
                    BottomMenu.SelectedIndex = 0;
                    return;
                }

                _selectedVertex.Label = tbVertexLabel.Text;

                try
                {
                    var newpoint = new PointF(int.Parse(tbVertexX.Text), int.Parse(tbVertexY.Text));
                    _selectedVertex.Location = newpoint;
                }
                catch (Exception)
                {
                    // ignored
                }
                Redraw();
            }
        }

        private void tbVertexX_ValueChanged(object sender, EventArgs e)
        {
            if (tbVertexX.Focus())
            {
                VertexTextChanged();
            }
        }

        private void tbVertexY_ValueChanged(object sender, EventArgs e)
        {
            if (tbVertexY.Focus())
            {
                VertexTextChanged();
            }
        }

        private void btnRemoveVertex_Click(object sender, EventArgs e)
        {
            if (_selectedVertex != null)
            {
                _graph.RemoveVertex(_selectedVertex);
                _selectedVertex = null;
            }
            Redraw();
            BottomMenu.SelectedIndex = 0;
        }

        private void btnRemoveEdge_Click(object sender, EventArgs e)
        {
            if (_selectedEdge != null)
            {
                _graph.RemoveEdge(_selectedEdge);
                _selectedVertex = null;
            }
            Redraw();
            BottomMenu.SelectedIndex = 0;
        }

        private void tbVertexLabel_TextChanged(object sender, EventArgs e)
        {
            if (tbVertexLabel.Focus())
            {
                VertexTextChanged();
            }
        }
    }
}