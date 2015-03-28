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


        public void AddVertex(PointF location)
        {
            Vertices.Add(new Vertex() {Location = location});
        }

        public Vertex GetVertex(PointF location)
        {
            return Vertices.FirstOrDefault(vertex => vertex.Location.GetDistance(location) < 12);
        }


        public void AddEdge(Vertex startVertex, Vertex stopVertex, bool directed = false)
        {
            if (!(Vertices.Contains(startVertex) && Vertices.Contains(stopVertex)))
            {
                throw new Exception("Wierzchołek nie istnieje");
            }
            Edges.Add(new Edge()
            {
                StartVertex = startVertex,
                StopVertex = stopVertex,
                Directed = directed
            });

            CurveEdges(startVertex, stopVertex);
        }


        public void CurveEdges()
        {
            foreach (Vertex startVertex in Vertices)
            {
                foreach (Vertex stopVertex in Vertices)
                {
                    CurveEdges(startVertex, stopVertex);
                }
            }
        }

        private void CurveEdges(Vertex startVertex, Vertex stopVertex)
        {
            Edge[] edges =
                Edges.Where(
                    edge =>
                        (edge.StartVertex == startVertex && edge.StopVertex == stopVertex) ||
                        (edge.StartVertex == stopVertex && edge.StopVertex == startVertex)).ToArray(); // get multiple (loop) edges 

            if (startVertex != stopVertex)   // curve Multiple Edges
            {
                var vector = stopVertex.Location.SubtractPoint(startVertex.Location);
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
                        edge.StopVertex.Location
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
                        edge.StartVertex.Location.AddPoint(new PointF(0, 20*(i + 2))), edge.StopVertex.Location);
                }
            }
        }

        public Edge GetEdge(PointF location)
        {
            return Edges.FirstOrDefault(edge => edge.Path.IsOutlineVisible(location, new Pen(Color.Black, 6)));
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

        public Vertex StopVertex { get; set; }


        public GraphicsPath Path { get; internal set; }


        public bool Directed { get; set; }
    }

    #endregion
}