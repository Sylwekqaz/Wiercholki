using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace WindowsFormsApplication1
{
    internal class Graph
    {
        public Graph()
        {
            Edges = new List<Edge>();
            Vertices = new List<Vertex>();
        }

        public List<Vertex> Vertices { get; private set; }
        public List<Edge> Edges { get; private set; }
        public bool AutoCompleteGraph { get; set; }
        public bool DirectedEdges { get; set; }


        public void AddVertex(PointF location)
        {
            var newVertices = new Vertex() {Location = location};
            Vertices.Add(newVertices);
            if (AutoCompleteGraph)
            {
                foreach (Vertex vertex in Vertices)
                {
                    if (newVertices == vertex)
                    {
                        continue;
                    }
                    AddEdge(newVertices, vertex);
                }
            }
        }

        public Vertex GetVertex(PointF location)
        {
            return Vertices.FirstOrDefault(vertex => vertex.Location.GetDistance(location) < 12);
        }


        public void AddEdge(Vertex startVertex, Vertex endVertex, bool directed = false)
        {
            if (!(Vertices.Contains(startVertex) && Vertices.Contains(endVertex)))
            {
                throw new Exception("Wierzchołek nie istnieje");
            }
            Edges.Add(new Edge()
            {
                StartVertex = startVertex,
                EndVertex = endVertex,
                Directed = DirectedEdges
            });

            CurveEdges(startVertex, endVertex);
        }


        public void CurveEdges()
        {
            foreach (Vertex startVertex in Vertices)
            {
                foreach (Vertex endVertex in Vertices)
                {
                    CurveEdges(startVertex, endVertex);
                }
            }
        }

        private void CurveEdges(Vertex startVertex, Vertex endVertex)
        {
            Edge[] edges =
                Edges.Where(
                    edge =>
                        (edge.StartVertex == startVertex && edge.EndVertex == endVertex) ||
                        (edge.StartVertex == endVertex && edge.EndVertex == startVertex)).ToArray();
            // get multiple (loop) edges 

            if (startVertex != endVertex) // curve Multiple Edges
            {
                var vector = endVertex.Location.SubtractPoint(startVertex.Location);
                var middlepoint = startVertex.Location.AddPoint(vector.MultiplyPoint(0.5));
                //vector = vector.Orthogonal().MultiplyPoint(0.125);


                vector = vector.Orthonormal().MultiplyPoint(20);
                var startVector = vector.MultiplyPoint(((edges.Length - 1)/(double) 2));

                foreach (var edge in edges)
                {
                    edge.Path = new GraphicsPath();
                    edge.Path.AddBezier(
                        edge.StartVertex.Location,
                        middlepoint.SubtractPoint(startVector),
                        middlepoint.SubtractPoint(startVector),
                        edge.EndVertex.Location
                        );
                    startVector = startVector.SubtractPoint(vector);
                }
            }
            else // curve loop edges  
            {
                for (int i = 0; i < edges.Length; i++)
                {
                    var edge = edges[i];
                    edge.Path = new GraphicsPath();
                    edge.Path.AddBezier(edge.StartVertex.Location,
                        edge.StartVertex.Location.AddPoint(new PointF(20*(i + 2), 0)),
                        edge.StartVertex.Location.AddPoint(new PointF(0, 20*(i + 2))), edge.EndVertex.Location);
                }
            }
        }

        public Edge GetEdge(PointF location)
        {
            return Edges.FirstOrDefault(edge => edge.Path.IsOutlineVisible(location, new Pen(Color.Black, 6)));
        }

        public void RemoveVertex(Vertex selectedVertex)
        {
            Edges.RemoveAll(edge => edge.StartVertex == selectedVertex || edge.EndVertex == selectedVertex);
            Vertices.Remove(selectedVertex);
        }

        public void RemoveEdge(Edge selectedEdge)
        {
            Edges.Remove(selectedEdge);
        }

        public int GetVertexDegree(Vertex selectedVertex)
        {
            return Edges.Count(edge => edge.StartVertex == selectedVertex) +
                   Edges.Count(edge => edge.EndVertex == selectedVertex);
        }
    }

    #region additional types

    internal class Vertex
    {
        public PointF Location { get; set; }

        public String Label { get; set; }
    }


    internal class Edge
    {
        public Vertex StartVertex { get; set; }

        public Vertex EndVertex { get; set; }


        public GraphicsPath Path { get; internal set; }


        public bool Directed { get; set; }
    }

    #endregion
}