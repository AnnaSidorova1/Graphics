using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace КГ_лаба2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double[]> Matrix = new List<double[]>();

        private void DrawGraph()
        {
            //отрисовка любой фигуры

            //настройка области
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            pane.XAxis.Title.Text = "Ось X";
            pane.YAxis.Title.Text = "Ось Y";
            pane.XAxis.MajorGrid.IsZeroLine = true;

            //координаты отображаемой области
            pane.XAxis.Scale.Min = -15;
            pane.XAxis.Scale.Max = 15;
            pane.YAxis.Scale.Min = -15;
            pane.YAxis.Scale.Max = 15;
            zgc.AxisChange();

            //списки точек 
            PointPairList list = new PointPairList();//звезда
            PointPairList list2 = new PointPairList();//полукруг

            list2.Add(Matrix[8][0], Matrix[8][1]);
            list2.Add(Matrix[11][0], Matrix[11][1]);
            list2.Add(Matrix[0][0], Matrix[0][1]);
            list2.Add(Matrix[12][0], Matrix[12][1]);
            list2.Add(Matrix[2][0], Matrix[2][1]);

            for (int i = 0; i < 11; ++i)
            {
                list.Add(Matrix[i][0], Matrix[i][1]);
            }

            LineItem myFig = pane.AddCurve("", list, Color.Black, SymbolType.None);
            LineItem Krug = pane.AddCurve("", list2, Color.Red, SymbolType.None);
            Krug.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            Krug.Line.IsSmooth = true;
        }

        private void Original_shape ()
        {
            //набор точек для исходной фигуры
            List<double[]> Points = new List<double[]>();
            double[] points1 = { 5, 11, 1 };
            double[] points2 = { 6.5, 7, 1 };
            double[] points3 = { 10, 7, 1 };
            double[] points4 = { 7.5, 4.5, 1 };
            double[] points5 = { 8.5, 0.8, 1 };
            double[] points6 = { 5, 3, 1 };
            double[] points7 = { 1.5, 0.8, 1 };
            double[] points8 = { 2.5, 4.5, 1 };
            double[] points9 = { 0, 7, 1 };
            double[] points10 = { 3.5, 7, 1 };
            double[] points11 = { 5, 11, 1 };
            double[] points12 = { 1.5, 9.4, 1 };
            double[] points13 = { 8.5, 9.4, 1 };

            Points.Add(points1);
            Points.Add(points2);
            Points.Add(points3);
            Points.Add(points4);
            Points.Add(points5);
            Points.Add(points6);
            Points.Add(points7);
            Points.Add(points8);
            Points.Add(points9);
            Points.Add(points10);
            Points.Add(points11);
            Points.Add(points12);
            Points.Add(points13);

            Matrix = Points;
        }

        private void Moving_along_axisX()
        {
            //перенос вдоль оси Х
            try
            {
                //количество шагов, заданное пользователем
                double koeff = Convert.ToDouble(tbX.Text);

                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { 1, 0, koeff }, { 0, 1, 0 }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Moving_along_axisY()
        {
            //перенос вдоль оси У
            try
            {
                //количество шагов, заданное пользователем
                double koeff = Convert.ToDouble(tbX.Text);

                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { 1, 0, 0 }, { 0, 1, koeff }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Reflection_Ox()
        {
            //отражение относительно оси Х
            try
            {
                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Reflection_Oy()
        {
            //отражение относительно оси У
            try
            {
                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Reflection_XY()
        {
            //отражение относительно оси У
            try
            {
                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { 0, 1, 0 }, { 1, 0, 0 }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Zoom_Ox()
        {
            //отражение относительно оси У
            try
            {
                //зум, заданный пользователем
                double koeff = Convert.ToDouble(tbX.Text);

                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { koeff, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Zoom_Oy()
        {
            //отражение относительно оси У
            try
            {
                //зум, заданный пользователем
                double koeff = Convert.ToDouble(tbX.Text);

                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { 1, 0, 0 }, { 0, koeff, 0 }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Turn_center()
        {
            //Поворот на угол относительно центра координат
            try
            {
                //угол, заданный пользователем
                double koeff = Convert.ToDouble(fi1.Text) * Math.PI / 180; //перевод из градусов в радианы
                List<double[]> Points = new List<double[]>();
                double[,] matrix = { { Math.Cos(koeff), -Math.Sin(koeff), 0 }, { Math.Sin(koeff), Math.Cos(koeff), 0 }, { 0, 0, 1 } };
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix));
                }
                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private void Turn_point()
        {
            //Поворот на угол относительно заданной точки
            try
            {
                //угол, заданный пользователем
                double koeff = Convert.ToDouble(fi2.Text) * Math.PI / 180; //перевод из градусов в радианы

                double x1 = Convert.ToDouble(x2.Text);
                double y1 = Convert.ToDouble(y2.Text);
                List<double[]> Points = new List<double[]>();
                List<double[]> Points2 = new List<double[]>();
                double[,] matrix3 = { { 1, 0, x1 }, { 0, 1, y1 }, { 0, 0, 1 } }; //сдвиг обратно
                double [,] matrix2 = { { 1, 0, -x1 }, { 0, 1, -y1 }, { 0, 0, 1 } }; //сдвиг туда
                double[,] matrix = { { Math.Cos(koeff), -Math.Sin(koeff), 0 }, { Math.Sin(koeff), Math.Cos(koeff), 0 }, { 0, 0, 1 } };

                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Matrix[i], matrix2));
                }

                for (int i = 0; i < 13; ++i)
                {
                    Points2.Add(Multiplication_Matrix(Points[i], matrix));
                }
                Points.Clear();
                for (int i = 0; i < 13; ++i)
                {
                    Points.Add(Multiplication_Matrix(Points2[i], matrix3));
                }

                Matrix = Points;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " - у вас ошибка");
            }
        }

        private double[] Multiplication_Matrix(double[] vector, double [,] matrix)
        {
            //умножение вектора на матрицу
            double[] newvector = new double[3];
            double tmp = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    tmp += vector[j] * matrix[i,j];
                }
                newvector[i] = tmp;
                tmp = 0;
            }
            return newvector;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //исходная фигура
            Original_shape();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Сдвиг вдоль Ох
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Moving_along_axisX();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Сдвиг вдоль Оу
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Moving_along_axisY();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Отражение относительно Ох
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Reflection_Ox();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Отражение относительно Оу
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Reflection_Oy();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Отражение относительно прямой у = х 
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Reflection_XY();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Масшатбирование по Ох
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Zoom_Ox();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Масшатбирование по Оу
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Zoom_Oy();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Поворот на угол относительно центра координат
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Turn_center();
            DrawGraph();
            zgc.Invalidate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Поворот на угол относительно заданной точки
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            Turn_point();
            DrawGraph();
            zgc.Invalidate();
        }
    }
}
