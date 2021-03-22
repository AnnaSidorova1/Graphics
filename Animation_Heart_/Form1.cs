using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Heart
{
    public partial class Form1 : Form
    {
        List<double[]> Points = new List<double[]>();

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer() { Interval = 1000 };

        public Form1()
        {
            //отрисовка сердца и старт таймера
            InitializeComponent();
            DrawHeart();
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void DrawHeart()
        {
            GraphPane pane = zgc.GraphPane;
            pane.YAxis.IsVisible = false;

            pane.CurveList.Clear();

            //координаты отображаемой области
            pane.XAxis.Scale.Min = -15;
            pane.XAxis.Scale.Max = 15;
            pane.YAxis.Scale.Min = -15;
            pane.YAxis.Scale.Max = 15;
            zgc.AxisChange();

            //фигура
            PointPairList list = new PointPairList();
            double[] point1 = new double[] { 0, 3, 1 };
            double[] point2 = new double[] { 5, 8, 1 };
            double[] point3 = new double[] { 9, 8, 1 };
            double[] point4 = new double[] { 10, 3, 1 };
            double[] point5 = new double[] { 7, -3, 1 };
            double[] point6 = new double[] { 0, -11, 1 };
            double[] point7 = new double[] { -7, -3, 1 };
            double[] point8 = new double[] { -10, 3, 1 };
            double[] point9 = new double[] { -9, 8, 1 };
            double[] point10 = new double[] { -5, 8, 1 };
            double[] point11 = new double[] { 0, 3, 1 };

            Points.Add(point1);
            Points.Add(point2);
            Points.Add(point3);
            Points.Add(point4);
            Points.Add(point5);
            Points.Add(point6);
            Points.Add(point7);
            Points.Add(point8);
            Points.Add(point9);
            Points.Add(point10);
            Points.Add(point11);

            for (int i = 0; i < 11; ++i)
            {
                list.Add(Points[i][0], Points[i][1]);
            }

            LineItem Krug = pane.AddCurve("", list, Color.Red, SymbolType.None);
            Krug.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            Krug.Line.IsSmooth = true;

        }

        private double[] Multiplication_Matrix(double[] vector, double[,] matrix)
        {
            //умножение вектора на матрицу
            double[] newvector = new double[3];
            double tmp = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    tmp += vector[j] * matrix[i, j];
                }
                newvector[i] = tmp;
                tmp = 0;
            }
            return newvector;
        }

        private void Move()
        {
            GraphPane pane = zgc.GraphPane;
            pane.YAxis.IsVisible = false;
            zgc.Invalidate();
            pane.CurveList.Clear();

            //координаты отображаемой области
            pane.XAxis.Scale.Min = -15;
            pane.XAxis.Scale.Max = 15;
            pane.YAxis.Scale.Min = -15;
            pane.YAxis.Scale.Max = 15;
            zgc.AxisChange();

            //увеличение всех координат в 1.2 раза
            PointPairList list = new PointPairList();

            double[,] matrix = { { 1.2, 0, 0 }, { 0, 1.2, 0 }, { 0, 0, 1 } };

            for (int i = 0; i < 11; ++i)
            {
                Points[i] = Multiplication_Matrix(Points[i], matrix);
            }

            for (int i = 0; i < 11; ++i)
            {
                list.Add(Points[i][0], Points[i][1]);
            }

            LineItem Krug = pane.AddCurve("", list, Color.Red, SymbolType.None);
            Krug.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            Krug.Line.IsSmooth = true;
            this.Refresh();
        }

        private void Remove()
        {
            GraphPane pane = zgc.GraphPane;
            pane.YAxis.IsVisible = false;
            zgc.Invalidate();
            pane.CurveList.Clear();

            //координаты отображаемой области
            pane.XAxis.Scale.Min = -15;
            pane.XAxis.Scale.Max = 15;
            pane.YAxis.Scale.Min = -15;
            pane.YAxis.Scale.Max = 15;
            zgc.AxisChange();

            //уменьшение всех координат в 1.2 раза
            PointPairList list = new PointPairList();

            double[,] matrix = { { 1/1.2, 0, 0 }, { 0, 1/1.2, 0 }, { 0, 0, 1 } };

            for (int i = 0; i < 11; ++i)
            {
                Points[i] = Multiplication_Matrix(Points[i], matrix);
            }
            for (int i = 0; i < 11; ++i)
            {
                list.Add(Points[i][0], Points[i][1]);
            }
            LineItem Krug2 = pane.AddCurve("", list, Color.Red, SymbolType.None);
            Krug2.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            Krug2.Line.IsSmooth = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //вызов перерисовки и события таймера
            this.Refresh();
            Thread.Sleep(100);
            Move();
            Thread.Sleep(100);
            Remove();
            Thread.Sleep(100);
        }
    }
}
