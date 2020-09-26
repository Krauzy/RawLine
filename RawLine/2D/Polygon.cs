using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawLine._2D
{
    class Polygon
    {
        private List<Point> vertices;

        public Polygon()
        {
            this.vertices = new List<Point>();
        }

        public List<Point> Vertices { get => this.vertices; set => this.vertices = value; }

        public void AddVertice(int x, int y)
        {
            this.vertices.Add(new Point(x, y));
        }

        public Bitmap TerminatedPolygon(Bitmap img, Color cor)
        {
            img = DrawLine.DDA(img,
                this.vertices[this.vertices.Count - 1].X,
                this.vertices[this.vertices.Count - 1].Y,
                this.vertices[0].X,
                this.vertices[0].Y,
                cor);
            return img;
        }

        public Bitmap ReDraw(Bitmap img, Color cor, bool terminated = true)
        {
            for(int i = 0; i < this.vertices.Count - 1; i++)
                img = DrawLine.DDA(img, 
                    this.vertices[i].X, 
                    this.vertices[i].Y, 
                    this.vertices[i + 1].X, 
                    this.vertices[i + 1].Y, 
                    cor);
            return (terminated) ? this.TerminatedPolygon(img, cor) : img;
        }

        public override string ToString()
        {
            return this.GetHashCode() + " - " + this.vertices.Count + " lados";
        }
    }
}
