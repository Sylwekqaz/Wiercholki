using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiercholki
{
    enum InputState { DrawVertex, DrawEdge, NoInput }

    public partial class Form1 : Form
    {
        private InputState state;
        private Graf graf;

        private Vertex hoveredVertex;
        private Edge hoveredEdge;

        public Form1()
        {
            InitializeComponent();
            state = InputState.NoInput;

            mainPanel.Bitmap = new Bitmap(mainPanel.Width, mainPanel.Height);
            //no edge is in build
            completedEdge = true;
        }

        //edge-build stage
        private bool completedEdge;
        private Edge currentEdge;
        //

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (state == InputState.DrawVertex)
            {
                //dodaj wierzchołek
                if (e.Button == MouseButtons.Left)
                {
                    Vertex v = new Vertex();
                    v.X = e.X;
                    v.Y = e.Y;
                    v.Size = 10;
                    graf.AddVertex(v);
                    mainPanel.Refresh();
                }
                //usun wierzchołek
                if (e.Button == MouseButtons.Right)
                {
                    if (hoveredVertex != null)
                    {
                        graf.RemoveVertex(hoveredVertex);
                    }
                }
            }
            
            if (state == InputState.DrawEdge)
            {
                //rysuj
                if (e.Button == MouseButtons.Left)
                { 
                    //magnet
                    if (hoveredVertex != null)
                    {
                        //rozpocznij rysowanie od wierzchołka
                        if (completedEdge == true)
                        {
                            currentEdge = new Edge();
                            currentEdge.FirstVertex = hoveredVertex;
                            completedEdge = false;
                        }
                        //koncz rysowanie
                        else
                        {
                            currentEdge.SecondVertex = hoveredVertex;
                            graf.AddEdge(currentEdge);
                            completedEdge = true;
                        }

                        mainPanel.Refresh();
                    }
                }
                //przerwij rysowanie krawedzi
                if (e.Button == MouseButtons.Right)
                {
                    currentEdge = null;
                    completedEdge = true;
                }
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (graf != null)
            {
                var nearest = graf.FindNearestVertex(e.X, e.Y, 50);

                //magnetic snap
                if (nearest != null)
                {
                    hoveredVertex = nearest as Vertex;
                    mainPanel.Refresh();
                    using (var graphics = mainPanel.CreateGraphics())
                    {
                        using (Brush brush = new SolidBrush(Color.FromArgb(100, 60, 60, 60)))
                        {
                            graphics.FillRectangle(brush, nearest.X - nearest.Size / 2, nearest.Y - nearest.Size / 2,
                                nearest.Size + 1, nearest.Size + 1);
                            
                            if (completedEdge == false && currentEdge != null)
                            {
                                graphics.DrawLine(Pens.BurlyWood, currentEdge.FirstVertex.X, currentEdge.FirstVertex.Y,
                                    nearest.X, nearest.Y);
                            }
                        }
                    }
                }
                //no snap
                else
                {
                    hoveredVertex = null;
                    mainPanel.Refresh();
                    using (var graphics = mainPanel.CreateGraphics())
                    {
                        if (completedEdge == false && currentEdge != null)
                        {
                            graphics.DrawLine(Pens.BurlyWood, currentEdge.FirstVertex.X, currentEdge.FirstVertex.Y,
                                e.X, e.Y);
                        }
                    }
                }
            }
        }

        private void newGraphButton_Click(object sender, EventArgs e)
        {
            graf = new Graf();
            mainPanel.Refresh();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (graf != null)
            {
                using (var graphics = Graphics.FromImage(mainPanel.Bitmap))
                {
                    graphics.Clear(Color.Black);
                    graf.Display(graphics);
                }
            }
        }

        private void vertexModeButton_Click(object sender, EventArgs e)
        {
            state = InputState.DrawVertex;
        }

        private void edgeModeButton_Click(object sender, EventArgs e)
        {
            state = InputState.DrawEdge;
        }
    }
}
