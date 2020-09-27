﻿using RawLine.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

        private void SetPixel(int x, int y, Color cor, BitmapData data)
        {
            int stride = data.Stride;
            unsafe
            {
                byte* pointer = (byte*)data.Scan0.ToPointer();
                byte* init = pointer;
                pointer = (byte*)(init + (y * stride) + (x * 3));
                *(pointer++) = cor.B;
                *(pointer++) = cor.G;
                *(pointer++) = cor.R;
            }
        }

        private Color GetPixel(int x, int y, BitmapData data)
        {
            int stride = data.Stride;
            int[] p = new int[3];
            unsafe
            {
                byte* pointer = (byte*)data.Scan0.ToPointer();
                byte* init = pointer;
                pointer = (byte*)(init + (y * stride) + (x * 3));
                p[0] = *(pointer++);
                p[1] = *(pointer++);
                p[2] = *(pointer++);
            }
            return Color.FromArgb(p[0], p[1], p[2]);
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

        public Point GetSeed()
        {
            double xmed = 0;
            double ymed = 0;
            int count = 0;
            
            for(int i = 0; i < this.vertices.Count - 1; i++)
            {
                Point p = new Point(
                    (this.vertices[i].X + this.vertices[i + 1].X) / 2, 
                    (this.vertices[i].Y + this.vertices[i + 1].Y) / 2
                );
                xmed += p.X;
                ymed += p.Y;
                count++;
            }
            xmed += (this.vertices[this.vertices.Count - 1].X + this.vertices[0].X) / 2;
            ymed += (this.vertices[this.vertices.Count - 1].Y + this.vertices[0].Y) / 2;
            count++;
            xmed /= count;
            ymed /= count;
            return new Point((int)xmed, (int)ymed);
        }

        public Bitmap ScanLine(Bitmap img, Color cor)
        {
            BitmapData DataSrc = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {

            }
            img.UnlockBits(DataSrc);
            return img;
        }

        public Bitmap FloodFill(Bitmap img, Color borda, Color inside)
        {
            int width = img.Width;
            int height = img.Height;
            BitmapData data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                Stack<Point> stack = new Stack<Point>();
                Color back = this.GetPixel(this.GetSeed().X, this.GetSeed().Y, data);
                stack.Push(this.GetSeed());
                while (stack.Count > 0)
                {
                    Point p = stack.Pop();
                    if (p.X < width && p.X > 0 && p.Y < height && p.Y > 0)
                    {
                        Color cor = this.GetPixel(p.X, p.Y, data);
                        if (cor == back)
                        {
                            this.SetPixel(p.X, p.Y, inside, data);
                            stack.Push(new Point(p.X + 1, p.Y));
                            stack.Push(new Point(p.X, p.Y + 1));
                            stack.Push(new Point(p.X - 1, p.Y));
                            stack.Push(new Point(p.X, p.Y - 1));
                        }
                    }
                }                
            }
            img.UnlockBits(data);
            return img;
        }

        public Bitmap Translation(Bitmap img, Color cor, int desloc)
        {
            double[] M1 = new double[2];
            double[] M2 = new double[2];
            for(int i = 0; i < this.vertices.Count; i++)
            {
                M1[0] = this.vertices[i].X; M1[1] = this.vertices[i].Y;
                M2[0] = desloc; M2[1] = desloc;
                double[] M = Matrix.SUM(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap Scala(Bitmap img, Color cor, double scala)
        {
            double[][] M1 = new double[2][];
            M1[0] = new double[2];
            M1[1] = new double[2];
            double[] M2 = new double[2];
            M1[0][0] = scala; M1[0][1] = 0;
            M1[1][0] = 0; M1[1][1] = scala;
            for (int i = 0; i < this.vertices.Count; i++)
            {
                //M2[0] = this.vertices[i].X;
                //M2[1] = this.vertices[i].Y;
                //double[] M = Matrix.MULT(M1, M2);
                //this.vertices[i] = new Point((int)M[0], (int)M[1]);
                this.vertices[i] = new Point(Convert.ToInt32(this.vertices[i].X * scala), Convert.ToInt32(this.vertices[i].Y * scala));
            }
            return this.ReDraw(img, cor);
        }

        public override string ToString()
        {
            return this.GetHashCode() + " - " + this.vertices.Count + " lados";
        }

    }
}
