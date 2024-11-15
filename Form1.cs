using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        int MatrixSize = 0;
        double[,] matrix;
        double[,] matrix2;
        double[] tempRow;
        double[] xx;
        double[] yi;
        double[,] Y;

        public double divKoof;
        string f;
        double[] X;//лямбда
        public Form1()
        {
            InitializeComponent();
        }
        void ReadMatrixFromGrid()
        {
            matrix = new double[MatrixSize, MatrixSize];//создаем матрицу

            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dgMatrix.Rows[i].Cells[j].Value);//запоминаем значения
                }
            }
            ShowMatrixInGrid();//показываем матрицу
        }


        void ShowMatrixInGrid()
        {
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();//выводим матрицу
                }
            }
        }

        void CreateMatrixTest()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            int i = 0;
            for (i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }

            dgMatrix.Rows.Add(MatrixSize);

            i = 0;
            dgMatrix.Rows[i].Cells[0].Value = "1";
            dgMatrix.Rows[i].Cells[1].Value = "1,2";
            dgMatrix.Rows[i].Cells[2].Value = "2";
            dgMatrix.Rows[i].Cells[3].Value = "0,5";

            i = 1;
            dgMatrix.Rows[i].Cells[0].Value = "1,2";
            dgMatrix.Rows[i].Cells[1].Value = "1";
            dgMatrix.Rows[i].Cells[2].Value = "0,4";
            dgMatrix.Rows[i].Cells[3].Value = "1,2";

            i = 2;
            dgMatrix.Rows[i].Cells[0].Value = "2";
            dgMatrix.Rows[i].Cells[1].Value = "0,4";
            dgMatrix.Rows[i].Cells[2].Value = "2";
            dgMatrix.Rows[i].Cells[3].Value = "1,5";

            i = 3;
            dgMatrix.Rows[i].Cells[0].Value = "0,5";
            dgMatrix.Rows[i].Cells[1].Value = "1,2";
            dgMatrix.Rows[i].Cells[2].Value = "1,5";
            dgMatrix.Rows[i].Cells[3].Value = "1";
        }

        void CreateMatrix2()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            for (int i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }

            dgMatrix.Rows.Add(MatrixSize);
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = "1"; // записываем значеня в соответсвующие места
                }
            }
        }

        double[] Multiply(double[,] A, double[] b)
        {
            double[] b_i = new double[MatrixSize];
            double S;
            for(int i = 0; i < MatrixSize; i++)
            {
                S = 0;
                for (int j = 0; j < MatrixSize; j++)
                {
                    S = S + A[i, j] * b[j];
                }
                b_i[i] = S;
            }
            return b_i;
        }

        void F()
        {
            f = " ";
            for (int i = 0; i < MatrixSize + 1; i++)
            {
                if (i == 0) f = $"x^{MatrixSize} +";
                else
                {
                    if(i < MatrixSize) f += $"({xx[i - 1]}) * x^{MatrixSize - i} +";
                    else f += $"({xx[i - 1]}) * x^{MatrixSize - i}";
                }
            }
        }

        void Krulov()
        {
            matrix = new double[MatrixSize, MatrixSize];
            ReadMatrixFromGrid();
            double[] y0 = new double[MatrixSize];
            yi = new double[MatrixSize];
            Y = new double[MatrixSize, MatrixSize];
            for (int i = 0; i < MatrixSize; i++)
            {
                if (i == 0) y0[i] = 1;
                else y0[i] = 0;
            }
            for (int i = 0; i < MatrixSize; i++)
            {
                Y[i, MatrixSize - 1] = y0[i];
            }
            for (int j = MatrixSize - 2; j >= 0; j--)
            {
                yi = Multiply(matrix, y0);
                for (int i = 0; i < MatrixSize; i++)
                {
                    Y[i, j] = yi[i];
                }
                for(int k = 0; k < MatrixSize; k++)
                {
                    y0[k] = yi[k];
                }
            }
            yi = Multiply(matrix, y0);
            for (int k = 0; k < MatrixSize; k++)
            {
                yi[k] = -yi[k];
            }
            Gausa();
            Lobachevskogo();
        }

        void ExetuteDivisionToSetKoofOne(int rowIndex)// функція для далення на коефіцієнт першого члена
        {
            int iRow = rowIndex;
            divKoof = matrix2[rowIndex, rowIndex];
            tempRow = new double[MatrixSize + 1];
            if (divKoof == 0)
            {
                listBox1.Items.Add("a11 = 0");
            }
            for (int j = rowIndex; j < MatrixSize + 1; j++)//- rowIndex
            {
                matrix2[iRow, j] = matrix2[iRow, j] / divKoof;
                tempRow[j] = matrix2[iRow, j];
            }
        }
        void Gausa()
        {
            matrix2 = new double[MatrixSize, MatrixSize+1];
            for(int i = 0; i < MatrixSize; i++)
            {
                matrix2[i, MatrixSize] = yi[i];
                for(int j = 0; j < MatrixSize; j++)
                {
                    matrix2[i, j] = Y[i, j];
                }
            }
            tempRow = new double[MatrixSize + 1];
            int row;
            double multKoof;
            for (row = 0; row < MatrixSize - 1; row++)
            {
                ExetuteDivisionToSetKoofOne(row);
                for (int nextRow = row + 1; nextRow < MatrixSize; nextRow++)
                {
                    multKoof = matrix2[nextRow, row];

                    for (int j = row; j < MatrixSize + 1; j++)
                    {
                        matrix2[row, j] = tempRow[j] * multKoof;
                        matrix2[nextRow, j] = matrix2[nextRow, j] - matrix2[row, j];
                        matrix2[row, j] = tempRow[j];
                    }
                }
            }
            xx = new double[MatrixSize];
            xx[MatrixSize - 1] = matrix2[MatrixSize - 1, MatrixSize];
            for (int i = MatrixSize - 1; i > 0; i--)
            {
                xx[i] = Math.Round(matrix2[i, MatrixSize], 3) / Math.Round(matrix2[MatrixSize - 1, MatrixSize - 1], 3);
                for (i = MatrixSize - 2; i >= 0; i--)
                {
                    xx[i] = Math.Round(matrix2[i, MatrixSize], 3);
                    for (int j = i + 1; j < MatrixSize; j++)
                    {
                        xx[i] -= Math.Round(matrix2[i, j], 3) * Math.Round(xx[j], 3);

                    }
                }
            }
        }

        void Lobachevskogo()
        {
            F();
            MathExpression fun = new MathExpression(f);
            listBox1.Items.Clear();
            double E = 0.01;
            double[] A1 = new double[MatrixSize + 1];
            double[] A2 = new double[MatrixSize + 1];
            X = new double[MatrixSize];
            int k, iter, iter1, k1, k2;
            double S, res, m, x, tmp, max;
            for (int i = 0; i < MatrixSize + 1; i++)
            {
                if (i == 0) A1[i] = 1;
                else A1[i] = xx[i - 1];
            }
            iter = 0;
            do
            {
                k = 0;
                for (int i = 0; i < MatrixSize + 1; i++)
                {
                    S = 0;
                    k1 = i - 1;
                    k2 = i + 1;
                    iter1 = 1;
                    while (true)
                    {
                        if (k1 < 0 || k2 > MatrixSize) break;
                        else
                        {
                            if (iter1 % 2 == 0) S = S + 2 * (A1[k1] * A1[k2]);//шукаю проміжні результати для знаходження наступних значень
                            else S = S - 2 * (A1[k1] * A1[k2]);
                        }

                        iter1++;
                        k1 = i - iter1;
                        k2 = i + iter1;
                    }
                    A2[i] = Math.Pow(A1[i], 2) + S;//шукаю по формулам масив значень після піднесення в степінь
                }

                for (int i = 0; i < MatrixSize + 1; i++)
                {
                    res = Math.Round(Math.Pow(A1[i], 2), 3);
                    tmp = Math.Round(A2[i], 3) - res;
                    max = Math.Abs(xx.Max());

                    if (max < 16)
                    {
                        if (Math.Abs(tmp) <= E || iter == 6) k++;//перевіряю умову виходу з ітераційного процессу
                    }
                    else
                    {
                        if (Math.Abs(tmp) <= E || iter == 5) k++;
                    }
                }

                for (int i = 0; i < MatrixSize + 1; i++)
                {
                    A1[i] = A2[i];
                }
                iter++;
            }
            while (k != MatrixSize + 1);

            m = Math.Pow(2, iter);

            for (int i = 0; i <= MatrixSize - 1; i++)
            {
                x = -A1[i + 1] / A1[i];//по формулам рахую х
                if (x < 0) X[i] = (-1) * Math.Pow(Math.Abs(x), 1 / m);
                else X[i] = Math.Pow(x, 1 / m);
            }
            for (int i = 0; i < MatrixSize; i++)//MatrixSize - count
            {
                double f = fun.Calculate(X[i]);
                if (Math.Round(f) != 0) X[i] = X[i] * (-1);
                f = fun.Calculate(X[i]);
                if (Math.Round(f) == 0) listBox1.Items.Add("l" + i.ToString() + " = " + Math.Round(X[i],4));//виводжу лямбда
            }
        }

        void Vectors()
        {
            listBox2.Items.Clear();
            matrix = new double[MatrixSize, MatrixSize];
            ReadMatrixFromGrid();
            double[] y = new double[MatrixSize];
            double[] q = new double[MatrixSize];
            double[] x = new double[MatrixSize];

            int iter = 0;
            do
            {
                
                q[0] = 1;
                y[0] = 1;
                x[0] = 0;
                for (int i = 1; i < MatrixSize; i++)
                {
                    q[i] = q[i - 1] * X[iter] + xx[i - 1];
                    y[i] = 0;
                    x[i] = 0;
                }
                for(int i = 0; i < MatrixSize; i++)
                {
                    for (int j = 0; j < MatrixSize; j++)
                    {
                        if(i == 0)
                        {
                            x[j] = y[j] * q[MatrixSize - 1];
                        }
                        else
                        {
                            x[j] = x[j] + y[j] * q[MatrixSize - i - 1];
                        }
                    }
                    y = Multiply(matrix, y);
                }
                for(int i = 0; i < MatrixSize; i++)
                {
                    listBox2.Items.Add(Math.Round(x[i],3));
                }
                listBox2.Items.Add("--------------");
                iter++;
            } while (iter != MatrixSize);
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            CreateMatrix2();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CreateMatrixTest();
        }

        private void btnKrulov_Click(object sender, EventArgs e)
        {
            Krulov();
        }

        private void btnVectors_Click(object sender, EventArgs e)
        {
            Vectors();
        }
    }
}
