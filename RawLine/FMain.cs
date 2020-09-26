﻿using RawLine._2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RawLine
{
    public partial class FMain : Form
    {
        private string Active;
        private Point point;
        private Image img;
        private bool flag;
        private List<Graph> List;
        private List<Polygon> polys;
        private bool polyflag;
        private bool polyfirst;
        private Polygon poly;

        public FMain()
        {
            InitializeComponent();
            flag = false;
            polyflag = false;
            polyfirst = true;
            point = new Point(-1, -1);
            List = new List<Graph>();
            polys = new List<Polygon>();
            this.KeyPreview = true;
            pnScroll.Location = new Point(pnScroll.Location.X, 155);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            foreach(var control in Controls)
            {
                if(control.GetType() == typeof(GroupBox))
                {
                    GroupBox g = (GroupBox)control;
                    foreach(var inside in g.Controls)
                    {
                        RadioButton radio = (RadioButton)inside;
                        if (radio.Name != rd.Name)
                            radio.Checked = false;
                    }
                }
            }
            this.Active = rd.Text;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(picBox.Image != null)
                toolTip.SetToolTip(picBox, "X:" + e.X + " Y:" + e.Y);
            if(polyflag == true && polyfirst == false)
            {
                picBox.Image = DrawLine.DDA((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                Console.WriteLine("entrou |" + e.X);
            }
            else
            {
                if (flag == true && picBox.Image != null && polyflag == false)
                {
                    switch (this.Active)
                    {
                        case "Equação Real da Reta":
                            picBox.Image = DrawLine.RealLine((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "DDA":
                            picBox.Image = DrawLine.DDA((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Bresenham":
                            picBox.Image = DrawLine.Bresenham((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Trigonometria":
                            picBox.Image = DrawCircle.Trigonometry((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Ponto Médio":
                            picBox.Image = DrawCircle.Midpoint((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Ponto Médio Elipse":
                            picBox.Image = DrawEllipse.Midpoint((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        default:
                            picBox.Image = DrawCircle.RealCircle((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;
                    }
                }
            }
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(picBox.Image == null)
            {
                Bitmap b = new Bitmap(picBox.Width, picBox.Height);
                img = b;
                picBox.Image = img;
                picBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            if(e.Button == MouseButtons.Right)
            {
                img = poly.ReDraw((Bitmap)img, Color.Black);
                picBox.Image = img;
                polys.Add(poly);
                polist.Items.Add(poly);
                polyflag = false;
                polyfirst = true;
            }
            else
            {
                if (polyflag)
                {
                    if (polyfirst)
                    {
                        polyfirst = !polyfirst;
                        poly = new Polygon();
                        poly.AddVertice(e.X, e.Y);
                        point = new Point(e.X, e.Y);
                    }
                    else
                    {
                        img = DrawLine.DDA((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                        picBox.Image = img;
                        poly.AddVertice(e.X, e.Y);
                        point = new Point(e.X, e.Y);
                    }
                }
                else
                {
                    if (flag == false && polyflag == false)
                    {
                        point = new Point(e.X, e.Y);
                        flag = true;
                    }
                }
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            Graph g;
            if (flag == true && polyflag == false)
            {
                switch(this.Active)
                {
                    case "Equação Real da Reta":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Reta", "Real");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "DDA":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Reta", "DDA");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Bresenham":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Reta", "Bresenham");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Trigonometria":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Circunferência", "Trigonometria");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Ponto Médio":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Circunferência", "Ponto Médio");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Ponto Médio Elipse":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Elipse", "Ponto Médio");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    default:
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Circunferência", "Real");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;
                }
                picBox.Image = img;
                flag = false;
            }
        }

        private void Graphs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Graphs.SelectedIndex >= 0)
            {
                foreach(Graph g in List)                
                    img = g.ReDraw((Bitmap)img, Color.Black);
                img = List[Graphs.SelectedIndex].ReDraw((Bitmap)img, Color.Blue);
                picBox.Image = img;
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(Graphs.SelectedItem != null)
            {
                img = List[Graphs.SelectedIndex].ReDraw((Bitmap)img, Color.White);
                picBox.Image = img;
                List.RemoveAt(Graphs.SelectedIndex);
                Graphs.Items.Clear();
                foreach(Graph g in List)
                {
                    img = g.ReDraw((Bitmap)img, Color.Black);
                    picBox.Image = img;
                    Graphs.Items.Add(g);
                }
            }
        }

        private void FMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z && List.Count > 0)
            {
                img = List[List.Count - 1].ReDraw((Bitmap)img, Color.White);
                List.RemoveAt(List.Count - 1);
                Graphs.Items.Clear();
                foreach(Graph g in List)
                {
                    img = g.ReDraw((Bitmap)img, Color.Black);
                    Graphs.Items.Add(g);
                }
                picBox.Image = img;
            }            
        }

        private void slideEscala_Scroll(object sender, EventArgs e)
        {
            int value = slideEscala.Value - 100;
            int sig = 0;
            if(value < 0)
            {
                if (Math.Abs(value) >= 10)
                {
                    if (Math.Abs(value) >= 100)
                    {
                        sig = 12;
                    }
                    else
                        sig = 8;
                }
                else
                    sig = 4;
            }

            Point loc = new Point(116 - sig, 19);
            loc.X += value;
            loc.X = (loc.X > 217) ? 217 : loc.X;
            txtValueEscala.Location = loc;
            txtValueEscala.Text = value.ToString();
        }

        private void slideTransalacao_Scroll(object sender, EventArgs e)
        {
            int value = slideTransalacao.Value - 100;
            int sig = 0;
            if (value < 0)
            {
                if (Math.Abs(value) >= 10)
                {
                    if (Math.Abs(value) >= 100)
                    {
                        sig = 12;
                    }
                    else
                        sig = 8;
                }
                else
                    sig = 4;
            }

            Point loc = new Point(116 - sig, 19);
            loc.X += value;
            loc.X = (loc.X > 217) ? 217 : loc.X;
            txtValueTranslacao.Location = loc;
            txtValueTranslacao.Text = value.ToString();
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pnScroll.Location = new Point(pnScroll.Location.X, 155 - scrollBar.Value);
        }

        private void btCriaPoly_Click(object sender, EventArgs e)
        {
            polyflag = true;
            polyfirst = true;
        }

        private void polist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(polist.SelectedItems.Count == 1)
            {
                foreach (var item in polys)
                    img = item.ReDraw((Bitmap)img, Color.Black);
                img = polys[polist.SelectedIndex].ReDraw((Bitmap)img, Color.Blue);
                picBox.Image = img;
            }
        }

        private void btApagaPoly_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count == 1)
            {                
                img = polys[polist.SelectedIndex].ReDraw((Bitmap)img, Color.White);
                polys.RemoveAt(polist.SelectedIndex);
                polist.Items.Clear();
                foreach (var item in polys)
                {
                    img = item.ReDraw((Bitmap)img, Color.Black);
                    polist.Items.Add(item);
                }
                picBox.Image = img;

            }
        }
    }
}
