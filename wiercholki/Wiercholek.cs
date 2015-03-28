using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace wiercholki
{
    interface IGraf
    {
        void AddVertex(IVertex elem);
        void RemoveVertex(IVertex elem);

        void AddEdge(IEdge elem);
        void RemoveEdge(IEdge elem);

        IVertex FindNearestVertex(int x, int y, int range);
    }

    interface IVertex
    {
        int X { get; set; }
        int Y { get; set; }
        int Size { get; set; }
        IEdge Connect(IVertex vertex);
    }

    enum Direction { Both, ToFirst, ToSecond };
    interface IEdge
    {
        IVertex FirstVertex { get; set; }
        IVertex SecondVertex { get; set; }
        Direction direction { get; set; }
    }

    class Vertex : IVertex
    {
        public int X { get; set; }

        public int Y { get; set; }
        public int Size { get; set; }

        public IEdge Connect(IVertex vertex)
        {
 	        throw new NotImplementedException();
        }

       
    }

    class Edge : IEdge
    {
        public IVertex FirstVertex { get; set; }
        public IVertex SecondVertex { get; set; }
        public Direction direction { get; set; }

        public Point[] bezierPoints;
    }

    class Graf : IGraf
    {
        private HashSet<IVertex> wierzcholki;
        private HashSet<IEdge> krawedzie;

        public Graf()
        {
            wierzcholki = new HashSet<IVertex>();
            krawedzie = new HashSet<IEdge>();
        }
        public void AddVertex(IVertex elem)
        {
            wierzcholki.Add(elem);
        }

        public void RemoveVertex(IVertex elem)
        {
            var relatedEdges = krawedzie.Where(x => (x.FirstVertex == elem || x.SecondVertex == elem));
            var list = relatedEdges.ToList();
            foreach (var edge in list)
            {
                RemoveEdge(edge);
            }


            if (wierzcholki.Contains(elem))
                wierzcholki.Remove(elem);
        }

        public void AddEdge(IEdge elem)
        {
            krawedzie.Add(elem);
        }

        public void RemoveEdge(IEdge elem)
        {
            if (krawedzie.Contains(elem))
                krawedzie.Remove(elem);
        }

        public void Display(Graphics e)
        {
            Random rand = new Random();
            foreach (var vertex in wierzcholki)
            {
                e.DrawEllipse(Pens.BlueViolet, vertex.X - vertex.Size / 2, vertex.Y - vertex.Size / 2, vertex.Size, vertex.Size);
            }
            foreach (var edge in krawedzie)
            {
                if (edge.FirstVertex == edge.SecondVertex)
                {
                    var casted = edge as Edge;
                    if (casted.bezierPoints != null) //wyswietl pętelkę jeśli jest
                    {
                        e.DrawBeziers(Pens.Coral, casted.bezierPoints);
                    }
                    else //stwórz pętelkę
                    {
                        casted.bezierPoints = new Point[4];
                        casted.bezierPoints[0].X = edge.FirstVertex.X;
                        casted.bezierPoints[0].Y = edge.FirstVertex.Y;

                        var offset1 = rand.Next(40, 60);
                        var offset2 = rand.Next(20, 50);
                        casted.bezierPoints[1].X = edge.FirstVertex.X + offset1;
                        casted.bezierPoints[1].Y = edge.FirstVertex.Y + offset2;

                        casted.bezierPoints[2].X = edge.FirstVertex.X - offset1;
                        casted.bezierPoints[2].Y = edge.FirstVertex.Y + rand.Next(20, 50); ; // edge.FirstVertex.Y + rand.Next(-100, 100);

                        casted.bezierPoints[3].X = casted.bezierPoints[0].X;
                        casted.bezierPoints[3].Y = casted.bezierPoints[0].Y;
                    }
                }
                else
                {
                    e.DrawLine(Pens.Coral, edge.FirstVertex.X, edge.FirstVertex.Y, edge.SecondVertex.X,
                        edge.SecondVertex.Y);
                }
                if (edge.direction != Direction.Both)
                {
                    if (edge.direction == Direction.ToFirst)
                    {
                        Point first = new Point((edge.FirstVertex.X + edge.SecondVertex.X)/2 + 3, (edge.FirstVertex.Y + edge.SecondVertex.Y)/2 );
                        Point mid = new Point(edge.FirstVertex.X, edge.FirstVertex.Y);
                        Point last = new Point((edge.FirstVertex.X + edge.SecondVertex.X)/2 - 3, (edge.FirstVertex.Y + edge.SecondVertex.Y)/2 );
                        
                        e.DrawLines(Pens.Coral, new []{first, mid, last});
                    }
                }
            }
        }

        public IVertex FindNearestVertex(int x, int y, int range)
        {
            IVertex nearest = null;
            int distance = range;
            foreach (var vertex in wierzcholki)
            {
                if (Math.Pow(x - vertex.X, 2) + Math.Pow(y - vertex.Y, 2) < distance)
                    nearest = vertex;
            }
            return nearest;
        }
        public IEdge FindNearestEdge(int x, int y, int range)
        {
            IEdge nearest = null;
            int distance = range;
            foreach (var edge in krawedzie)
            {
                if (Math.Pow(x - edge.FirstVertex.X, 2) + Math.Pow(y - edge.FirstVertex.Y, 2) + Math.Pow(x - edge.SecondVertex.X, 2) + Math.Pow(y - edge.SecondVertex.Y, 2) < distance)
                    nearest = edge;
            }
            return nearest;
        }
    }
}
