using System;
using System.Drawing;

namespace RawLine
{
    class DrawLine
    {
        public static Bitmap RealLine(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            double dx = x2 - x1;
            double dy = y2 - y1;
            double m = (double) dy / dx;
            int inc;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                inc = Math.Sign(dx);
                for (int x = x1; x != x2; x += inc)
                {
                    double y = y1 + m * (x - x1);
                    Paint.Draw(btm, x, (int)Math.Round(y), cor);
                }
            }
            else
            {
                inc = Math.Sign(dy);
                for(int y = y1; y != y2; y += inc)
                {
                    double x = x1 + (y - y1) / m;
                    Paint.Draw(btm, (int)Math.Round(x), y, cor);
                }
            }
            return btm;
        }

        public static Bitmap DDA(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            int lenght = Math.Abs(x2 - x1);
            if (Math.Abs(y2 - y1) > lenght)
                lenght = Math.Abs(y2 - y1);
            double X_INC = (double)(x2 - x1) / lenght;
            double Y_INC = (double)(y2 - y1) / lenght;
            double x = x1;
            double y = y1;
            int cont = 0;
            while(cont < lenght)
            {
                btm = Paint.Draw(btm, (int)Math.Round(x), (int)Math.Round(y), cor);
                x += X_INC;
                y += Y_INC;
                cont++;
            }
            return btm;
        }

        public static Bitmap Bresenham(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            int declive;
            int dx, dy, incE, incNE, d, x, y;
            dx = x2 - x1;
            dy = y2 - y1;
            if(Math.Abs(dx) > Math.Abs(dy))
            {
                if(x1 > x2)
                    btm = DrawLine.Bresenham(btm, x2, y2, x1, y1, cor);
                else
                {
                    if (dy < 0)
                    {
                        declive = -1;
                        dy = -dy;
                    }
                    else
                        declive = 1;
                    incE = 2 * dy;
                    incNE = 2 * dy - 2 * dx;
                    d = 2 * dy - dx;
                    y = y1;
                    for(x = x1; x <= x2; x++)
                    {
                        Paint.Draw(btm, x, y, cor);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }
            }
            else
            {
                if (y1 > y2)
                    btm = DrawLine.Bresenham(btm, x2, y2, x1, y1, cor);
                else
                {
                    if (dx < 0)
                    {
                        declive = -1;
                        dx = -dx;
                    }
                    else
                        declive = 1;
                    incE = 2 * dx;
                    incNE = 2 * dx - 2 * dy;
                    d = 2 * dx - dy;
                    x = x1;
                    for(y = y1; y <= y2; y++)
                    {
                        Paint.Draw(btm, x, y, cor);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }
            }
            return btm;
        }
    }
}
