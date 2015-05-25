using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace GraphPanel
{
    public class Graph
    {
        public Graph()
        {
            Edges = new List<Edge>();
            Vertices = new List<Vertex>();
        }

        public List<Vertex> Vertices { get; private set; }
        public List<Edge> Edges { get; private set; }
        public bool AutoCompleteGraph { get; set; }
        public int Numerator = 0;
        /// <summary>
        /// Sets new edges as directed / undirected
        /// </summary>
        public bool DirectedEdges { get; set; }

        /// <summary> 
        /// WARNING change property only prevent add new loop edge
        /// </summary>
        public bool AllowLoopEdges { get; set; }

        /// <summary>
        /// false - allow one bi-directional edge or two one-directional edge
        /// true - allow all edges 
        /// WARNING change property only prevent add new multi edge 
        /// </summary>
        public bool AllowMultipleEdge { get; set; }

        

        public void AddVertex(PointF location)
        {
            string num = Numerator.ToString();
            var newVertices = new Vertex() {Location = location, Label = num};
            Numerator++;
       
            Vertices.Add(newVertices);
        }

        public Vertex GetVertex(PointF location)
        {
            return Vertices.FirstOrDefault(vertex => vertex.Location.GetDistance(location) < 12);
        }

        public int CountVerticles()
        {
            int suma = 0;

            foreach (var vert in Vertices)
            {
                suma++;
            }
            return suma;
        }

        public int?[,]  FloydWarschalAlghoritm(int?[,] matrix)
        {
            // macierz n x n jest zadeklarowana wczesniej.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j )
                    {
                        matrix[i, j] = 0;  //0 na przekątnej, gdzie indziej null.
                    }
                }
            }
            foreach (var edge in Edges)  //wazna kolejnosc krawedzi
                //domyslnie wiercholki numerujemy od 0 do n. Moze byc alfabetycznie
                //dlatego krawedzie mamy po kolei.
            {
              // dla kazdej krawedzi edytuje macierz

             //Następnie dla każdej krawędzi u–v grafu w komórce d[u,v] 
             //   umieszczamy wagę krawędzi w(u–v). Wartość d[i,j] = null oznacza, że wierzchołek i-ty nie łączy się krawędzią 
             //   z wierzchołkiem j-tym (ale, jak zobaczymy dalej, może istnieć ścieżka łącząca te wierzchołki, a wtedy algorytm wprowadzi do d[i,j] jej koszt).
                int start = Convert.ToInt32(edge.StartVertex.Label);
                int end = Convert.ToInt32(edge.EndVertex.Label);
                //domyslnie value ustawiłem na 1.
                if (start != end) matrix[start, end] = edge.Value;
                if (edge.Directed == false) matrix[end, start] = edge.Value;
            }


            for (int k = 0; k < matrix.GetLength(0) ;  k++) //dla kazdego wierzcholka
            {
                for (int u = 0; u < matrix.GetLength(0); u++)
                {
                    for (int v = 0; v < matrix.GetLength(0); v++)
                    {
                       
                        if (matrix[u, v] > matrix[u, k] + matrix[k, v])  //&& matrix[u, k] + matrix[k, v] != null
                            //max_int > max_int + 5    =  true..
                            //&& matrix[u,v] != null
                            //null>3 -> false
                            //2,3->null  a 5 
                        //   null > 0 + null;  -> false
                        //  k = 0, u = 1, v = 3   zmiana
                            //  k = 0, u=3, v =2   zmiana

                            // k = 1, v = 0, u = 2 ;     u,v = 10.0000 >  u,k = 10.0000  +  k,v = - 4  
                        {
                            matrix[u, v] = matrix[u, k] + matrix[k, v];
                        }
                    }
                //}
                }
            }
           return matrix;
        }

        public void AddEdge(Vertex startVertex, Vertex endVertex, int value, bool directed)
        {
            // terminate when loop edge is not allowed
            if (startVertex == endVertex && !AllowLoopEdges)
            {
                return;
            }


            // chek if two vertex exist in graph
            if (!(Vertices.Contains(startVertex) && Vertices.Contains(endVertex)))
            {
                throw new Exception("Wierzchołek nie istnieje w grafie");
            }


            // terminate when multi-edge is not allowed
            if (!AllowMultipleEdge)
            {
                var tempEdge =
                    Edges.FirstOrDefault(edge => edge.StartVertex == startVertex && edge.EndVertex == endVertex);
                if (tempEdge != null)
                {
                    return;
                }
                tempEdge =
                    Edges.FirstOrDefault(
                        edge => edge.StartVertex == endVertex && edge.EndVertex == endVertex && edge.Directed == false);
                if (tempEdge != null)
                {
                    return;
                }
            }


            // add vertex
            Edges.Add(new Edge()
            {
                Value = value,
                StartVertex = startVertex,
                EndVertex = endVertex,
                Directed = directed
            });


            // update curves in loop-egde and multi-edge
            CurveEdges(startVertex, endVertex);
        }

        public void AddEdge(Vertex startVertex, Vertex endVertex,int value)
        {
            AddEdge(startVertex, endVertex,value, DirectedEdges);
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

    public class Vertex
    {
        public PointF Location { get; set; }

        public string Label { get; set; }

    }


    public class Edge
    {
        public Vertex StartVertex { get; set; }

        public Vertex EndVertex { get; set; }


        public GraphicsPath Path { get; internal set; }


        public bool Directed { get; set; }

        public int Value  { get; set; }
    }

    #endregion
}