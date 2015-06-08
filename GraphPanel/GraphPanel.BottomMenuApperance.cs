using System;
using System.Drawing;
using System.Globalization;

namespace GraphPanel
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
                    break;
                case 2:
                    cbDirected.Checked = Graph.DirectedEdges;
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
                    lblVertexDegree.Text = Graph.GetVertexDegree(_selectedVertex).ToString();
                    _autoFillInprogress = false;
                    break;
                case 4:
                   
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        private void cbDirected_CheckedChanged(object sender, EventArgs e)
        {
            Graph.DirectedEdges = cbDirected.Checked;
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
                Graph.RemoveVertex(_selectedVertex);
                _selectedVertex = null;
            }
            Redraw();
            UpdateFloidMarshal();
            BottomMenu.SelectedIndex = 0;
        }

        private void btnRemoveEdge_Click(object sender, EventArgs e)
        {
            if (_selectedEdge != null)
            {
                Graph.RemoveEdge(_selectedEdge);
                _selectedVertex = null;
            }
            Redraw();
            UpdateFloidMarshal();
            BottomMenu.SelectedIndex = 0;
        }

        private void tbVertexLabel_TextChanged(object sender, EventArgs e)
        {
            if (tbVertexLabel.Focus())
            {
                VertexTextChanged();
            }
        }

        private void tbEditEdgeValue_TextChanged(object sender, System.EventArgs e)
        {
            if (tbEditEdgeValue.Focus())
            {
                int result;
                int.TryParse(tbEditEdgeValue.Text, out result);
                _selectedEdge.Value = result;
                UpdateFloidMarshal();
            }
        }
    }
}