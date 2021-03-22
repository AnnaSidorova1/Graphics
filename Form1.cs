using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КГ_лаба1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(this.tBx1.Text);
                double y1 = Convert.ToDouble(this.tBy1.Text);
                double x2 = Convert.ToDouble(this.tBx2.Text);
                double y2 = Convert.ToDouble(this.tBy2.Text);
                //для прямой существует каноническое уравнение 
                //задает в прямоугольной системе координат Oxy прямую линию, 
                //проходящую через точку A1 и имеющую направляющий вектор a

                //для начала получим координаты направляющего вектора
                //вычтем из координат одной точки (конца вектора) координаты другой (начала)

                double ax = x2 - x1;
                double ay = y2 - y1;

                string t1 = Convert.ToString(x1);
                string t2 = Convert.ToString(y1);
                if (x1 < 0)
                    t1 = "(" + t1 + ")";
                if (y1 < 0)
                    t2 = "(" + t2 + ")";

                if (x1 == x2 && y1 == y2)
                    MessageBox.Show("Точки совпадают");

                //зная координаты точки, через которую проходит прямая, и зная координаты 
                //направляющего вектора, составим каноническое уравнение прямой, проходящей через 2 точки
                else
                    this.ans1.Text = "( x - " + t1 + " ) " + "/ (" + Convert.ToString(ax) + ")"
                        + " = " + "( y - " + t2 + " ) " + "/ (" + Convert.ToString(ay) + ")";

                //если в знаменателе получен 0, значит прямая параллельна той оси, у которой в знаменателе не 0
            }
            catch(Exception ex)
            {
                MessageBox.Show("Вы не ввели данные или ввели неверно");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //чтобы определить, принадлежит ли точка прямой, нужно убедиться, что расстояние
            //от точки до каждого из концов отрезка равно длине отрезка
            //потому что если точка не лежит на отрезке, то сумма длин двух сторон больше длины одной стороны,
            //согласно неравенству треугольника

            try
            {
                double x1 = Convert.ToDouble(this.tBx21.Text);
                double y1 = Convert.ToDouble(this.tBy21.Text);
                double x2 = Convert.ToDouble(this.tBx22.Text);
                double y2 = Convert.ToDouble(this.tBy22.Text);
                double x3 = Convert.ToDouble(this.tBx23.Text);
                double y3 = Convert.ToDouble(this.tBy23.Text);

                //вычислим длину отрезка по известной формуле длины вектора

                double length = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2 - y1), 2));

                //теперь сравним длину отрезка с расстоянием от точки С до каждой из точек отрезка

                double length_C_A = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
                double length_C_B = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                if (x1 == x2 && y1 == y2)
                    MessageBox.Show("Точки совпадают");
                else
                {

                    if (length_C_A + length_C_B == length)
                        this.ans2.Text = "Точка С принадлежит отрезку АВ";
                    else
                        this.ans2.Text = "Точка С не принадлежит отрезку АВ";
                }

                //если в знаменателе получен 0, значит прямая параллельна той оси, у которой в знаменателе не 0
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы не ввели данные или ввели неверно");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //чтобы определить вид угла, нужно найти угол между векторами, которые составляют этот угол

            //а чтобы найти угол между векторами, мы выразим косинус из скалярного произведения этих векторов
            //косинус угла равен частному от деления произведения попарно координат векторов и произведения
            //длин этих векторов

            try
            {
                double x1 = Convert.ToDouble(this.tBx31.Text);
                double y1 = Convert.ToDouble(this.tBy31.Text);
                double z1 = Convert.ToDouble(this.tBz31.Text);
                double x2 = Convert.ToDouble(this.tBx32.Text);
                double y2 = Convert.ToDouble(this.tBy32.Text);
                double z2 = Convert.ToDouble(this.tBz32.Text);
                double x3 = Convert.ToDouble(this.tBx33.Text);
                double y3 = Convert.ToDouble(this.tBy33.Text);
                double z3 = Convert.ToDouble(this.tBz33.Text);

                //для начала вычислим координаты и длину каждого вектора

                double ab_x = x1 - x2;
                double ab_y = y1 - y2;
                double ab_z = z1 - z2;
                double cb_x = x3 - x2;
                double cb_y = y3 - y2;
                double cb_z = z3 - z2;

                double length_ab = Math.Sqrt(Math.Pow(ab_x, 2) + Math.Pow(ab_y, 2) + Math.Pow(ab_z, 2));
                double length_cb = Math.Sqrt(Math.Pow(cb_x, 2) + Math.Pow(cb_y, 2) + Math.Pow(cb_z, 2));

                //теперь вычислим косинус

                double cos_ABC = (ab_x * cb_x + ab_y * cb_y + ab_z * cb_z)/
                    (length_ab*length_cb);

                if (x1 == x2 && y1 == y2 && z1 == z2 || x1 == x3 && y1 == y3 && z1 == z3 
                    || x2 == x3 && y2 == y3 && z2 == z3)
                    MessageBox.Show("Точки совпадают");
                else
                {
                    if (cos_ABC == 0)
                        this.ans3.Text = "Угол АВС прямой";
                    if (cos_ABC > 0)
                        this.ans3.Text = "Угол АВС острый";
                    if (cos_ABC < 0)
                        this.ans3.Text = "Угол АВС тупой";
                }

                //если в знаменателе получен 0, значит прямая параллельна той оси, у которой в знаменателе не 0
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы не ввели данные или ввели неверно");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ans4.Clear();
            //есть аксиома, которая гласит что если 3 точки не совпадают друг с другом
            //и не лежат на одной прямой, то в трехмерном пространстве через них проходит одна плоскость
            try
            {
                double x1 = Convert.ToDouble(this.tbx41.Text);
                double y1 = Convert.ToDouble(this.tby41.Text);
                double z1 = Convert.ToDouble(this.tbz41.Text);
                double x2 = Convert.ToDouble(this.tbx42.Text);
                double y2 = Convert.ToDouble(this.tby42.Text);
                double z2 = Convert.ToDouble(this.tbz42.Text);
                double x3 = Convert.ToDouble(this.tbx43.Text);
                double y3 = Convert.ToDouble(this.tby43.Text);
                double z3 = Convert.ToDouble(this.tbz43.Text);

                if (x1 == x2 && y1 == y2 && z1 == z2 || x1 == x3 && y1 == y3 && z1 == z3
                    || x2 == x3 && y2 == y3 && z2 == z3)
                    MessageBox.Show("Точки совпадают");
                else
                {
                    //проверим, не лежат ли все точки на одной прямой
                    //для этого составим каноническое уравнение прямой из координат двух точек  
                    //и подставим туда координаты третьей точки

                    if((x3-x1)*(y2-y1) == (y3-y1)*(x2-x1) && (x3 - x1) * (z2 - z1) == (z3 - z1)*(x2 - x1) )
                        MessageBox.Show("Точки на одной прямой");
                    else
                    {
                        //конечное уравнение плоскости, проходящей через 3 точки
                        //можно написать, посчитав определитель, то есть смешанное произведение
                        //векторов, составленных из любой точки этой плоскости и трех известных

                        //этот подход основан на условии компланарности векторов, то есть их смешанное
                        //произведение должно равняться 0

                        double a = (y2 - y1) * (z3 - z1) - (z2 - z1) * (y3 - y1);
                        double b = -((x2 - x1) * (z3 - z1) - (z2 - z1) * (x3 - x1));
                        double c = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
                        double d = -x1*a-y1*b-z1*c;

                        string a_s = Convert.ToString(a);
                        string b_s = Convert.ToString(b);
                        string c_s = Convert.ToString(c);
                        string d_s = Convert.ToString(d);
                        if (a < 0)
                            a_s = "(" + a_s + ")";
                        if (b < 0)
                            b_s = "(" + b_s + ")";
                        if (c < 0)
                            c_s = "(" + c_s + ")";
                        if (d < 0)
                            d_s = "(" + d_s + ")";


                        if (a != 0)
                            this.ans4.Text = a_s + "x "; 
                        if (b != 0 && this.ans4.Text == "")
                            this.ans4.Text = b_s + "y ";
                        else if(b != 0)
                            this.ans4.Text += " + " + b_s + "y ";

                        if (c != 0 && this.ans4.Text == "")
                            this.ans4.Text = c_s + "z ";
                        else if (c != 0)
                            this.ans4.Text += " + " + c_s + "z ";

                        if (d != 0 && this.ans4.Text == "")
                            this.ans4.Text = d_s;
                        else if (d != 0)
                            this.ans4.Text += " + " + d_s;

                        this.ans4.Text += " = 0";
                    }
                }

                //если в знаменателе получен 0, значит прямая параллельна той оси, у которой в знаменателе не 0
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы не ввели данные или ввели неверно");
            }

        }
    }
}
