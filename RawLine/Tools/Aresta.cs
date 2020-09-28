using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawLine.Tools
{
    class Aresta
    {
        private int maxY;
        private int minX;
        private double incX;

        public int MaxY { get => this.maxY; set => this.maxY = value; }
        public int MinX { get => this.minX; set => this.minX = value; }
        public double IncX { get => this.incX; set => this.incX = value; }

        public Aresta(int maxY, int minX, double incX)
        {
            this.maxY = maxY;
            this.minX = minX;
            this.incX = incX;
        }

        public void Add()
        {
            this.minX = Convert.ToInt32(this.minX + this.incX);
        }
    }
}
