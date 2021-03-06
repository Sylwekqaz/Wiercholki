﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace GraphPanel
{
    partial class GraphPanel
    {
        private Graphics _graphLayerGraphics;
        private Graphics _tempLayerGraphics;
        private Graphics _selectLayerGraphics;
        private Bitmap _graphLayerBitmap;
        private Bitmap _tempLayerBitmap;
        private Bitmap _selectLayerBitmap;

        private readonly Pen _verticlePen = new Pen(Color.Black, 1);
        private readonly Pen _verticleSelectedPen = new Pen(Color.DeepSkyBlue, 3);
        private readonly Pen _edgeDirectedPen = new Pen(Color.Black, 1) {CustomEndCap = new AdjustableArrowCap(3, 5)};

        private readonly Pen _edgeDirectedSelectedPen = new Pen(Color.DeepSkyBlue, 4)
        {
            CustomEndCap = new AdjustableArrowCap(3, 5)
        };

        private readonly Pen _edgePen = new Pen(Color.Black, 1);
        private readonly Pen _edgeSelectedPen = new Pen(Color.DeepSkyBlue, 4);

        private void DrawTempEdge(PointF location)
        {
            Vertex closestPoint = Graph.GetVertex(location);
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

                foreach (Vertex vertex in Graph.Vertices)
                {
                    var rectangle = new RectangleF(vertex.Location.X - 5, vertex.Location.Y - 5, 10, 10);


                    _graphLayerGraphics.DrawEllipse(vertex == _selectedVertex || selectedVertices.Contains(vertex) ? _verticleSelectedPen : _verticlePen,
                        rectangle);

                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    _graphLayerGraphics.DrawString(
                        vertex.Label,
                        new Font("Arial", 8, FontStyle.Regular),
                        Brushes.Black,
                        vertex.Location.SubtractPoint(new PointF(0, 15)),
                        sf);
                }


                foreach (Edge edge in Graph.Edges)
                {
                    Graph.CurveEdges();
                    _graphLayerGraphics.DrawPath(edge.Directed ? _edgeDirectedPen : _edgePen, edge.Path);
                    if (edge == _selectedEdge || selectedEdges.Contains(edge))
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


            _graphLayerGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            _tempLayerGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            _selectLayerGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            Redraw();
        }

        private void Workspace_Paint(object sender, PaintEventArgs e)
        {
            Redraw();
        }
    }
}