using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATRIX_2._0
{
    public partial class Form1 : Form
    {
        int row1, col1, row2, col2;
        TextBox[,] Matrix1;
        TextBox[,] Matrix2;
        Matrix_operation mat_oper = new Matrix_operation();

        public Form1()
        {
            InitializeComponent();
        }


        private void Row2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Col2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Col1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Row1_KeyPress(object sender, KeyPressEventArgs e)//чтобы нельзя было вводить другие символы
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Handled - клик нажатия на клавиатуру\
        }


        private void CreateMatrix_Click_1(object sender, EventArgs e)//создать матрицы 
        {
            row1 = Convert.ToInt32(Row1.Text);
            col1 = Convert.ToInt32(Col1.Text);
            row2 = Convert.ToInt32(Row2.Text);
            col2 = Convert.ToInt32(Col2.Text);

            if (!(row1 > 0 & row1 < 8 & row2 > 0 & row2 < 8 & col1 > 0 & col1 < 8 & col2 > 0 & col2 < 8))
            {
                MessageBox.Show(
                "Выберите другое значение",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                TextBox[,] matrix1 = new TextBox[int.Parse(Row1.Text), int.Parse(Col1.Text)];//об-ние матрицы текстбоксов
                TextBox[,] matrix2 = new TextBox[int.Parse(Row2.Text), int.Parse(Col2.Text)];

                pan_mat1.Controls.Clear();//очищение панели
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        matrix1[i, j] = new TextBox() { Name = (i + j).ToString() + "_mat1", Location = new Point((30 * j + 30), i * 25), Text = "1", Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_mat1.Controls.Add(matrix1[i, j]);//доб-ние на панель
                    }
                }

                pan_mat2.Controls.Clear();
                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        matrix2[i, j] = new TextBox() { Name = (i + j).ToString() + "_mat2", Location = new Point((30 * j + 30), i * 25), Text = "1", Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_mat2.Controls.Add(matrix2[i, j]);
                    }
                }
                Matrix1 = matrix1;//прис-ние глоб. переменной знач. локальной
                Matrix2 = matrix2;
            }
        }

        private void Random1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (!(row1 > 0 & row1 < 8 & row2 > 0 & row2 < 8 & col1 > 0 & col1 < 8 & col2 > 0 & col2 < 8))
            {
                MessageBox.Show(
                "Выберите другое значение",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                TextBox[,] matrix1 = new TextBox[int.Parse(Row1.Text), int.Parse(Col1.Text)];//об-ние матрицы текстбоксов
                
                pan_mat1.Controls.Clear();//очищение панели
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        int k = rnd.Next(-100, 100);
                        matrix1[i, j] = new TextBox() { Name = (i + j).ToString() + "_mat1", Location = new Point((30 * j + 30), i * 25), Text = k.ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_mat1.Controls.Add(matrix1[i, j]);//доб-ние на панель
                    }
                }

                
                Matrix1 = matrix1;//прис-ние глоб. переменной знач. локальной
            }
        }

        private void Random2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (!(row1 > 0 & row1 < 8 & row2 > 0 & row2 < 8 & col1 > 0 & col1 < 8 & col2 > 0 & col2 < 8))
            {
                MessageBox.Show(
                "Выберите другое значение",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                TextBox[,] matrix2 = new TextBox[int.Parse(Row2.Text), int.Parse(Col2.Text)];

                pan_mat2.Controls.Clear();
                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        int k = rnd.Next(-100, 100);
                        matrix2[i, j] = new TextBox() { Name = (i + j).ToString() + "_mat2", Location = new Point((30 * j + 30), i * 25), Text = k.ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_mat2.Controls.Add(matrix2[i, j]);
                    }
                }
                Matrix2 = matrix2;
            }
        }

        private void Random3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (!(row1 > 0 & row1 < 8 & row2 > 0 & row2 < 8 & col1 > 0 & col1 < 8 & col2 > 0 & col2 < 8))
            {
                MessageBox.Show(
                "Выберите другое значение",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                TextBox[,] matrix1 = new TextBox[int.Parse(Row1.Text), int.Parse(Col1.Text)];//об-ние матрицы текстбоксов
                TextBox[,] matrix2 = new TextBox[int.Parse(Row2.Text), int.Parse(Col2.Text)];

                pan_mat1.Controls.Clear();//очищение панели
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        int k = rnd.Next(-100, 100);
                        matrix1[i, j] = new TextBox() { Name = (i + j).ToString() + "_mat1", Location = new Point((30 * j + 30), i * 25), Text = k.ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_mat1.Controls.Add(matrix1[i, j]);//доб-ние на панель
                    }
                }

                pan_mat2.Controls.Clear();
                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        int k = rnd.Next(-100, 100);
                        matrix2[i, j] = new TextBox() { Name = (i + j).ToString() + "_mat2", Location = new Point((30 * j + 30), i * 25), Text = k.ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_mat2.Controls.Add(matrix2[i, j]);
                    }
                }
                Matrix1 = matrix1;//прис-ние глоб. переменной знач. локальной
                Matrix2 = matrix2;
            }
        }

        private void SumMatrix_Click(object sender, EventArgs e)
        {
            if (row1 == row2 & col1 == col2)
            {
                TextBox[,] matrix_sum = new TextBox[int.Parse(Row1.Text), int.Parse(Col1.Text)];

                int[,] input_mat1 = new int[row1, col1];
                int[,] input_mat2 = new int[row2, col2];

                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        input_mat1[i, j] = Convert.ToInt32(Matrix1[i, j].Text);
                        input_mat2[i, j] = Convert.ToInt32(Matrix2[i, j].Text);
                    }
                }

                Matrix m1 = new Matrix(input_mat1);
                Matrix m2 = new Matrix(input_mat2);
                Matrix res = mat_oper.Sum(m1, m2);

                pan_res.Controls.Clear();
                for (int i = 0; i < matrix_sum.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix_sum.GetLength(1); j++)
                    {
                        matrix_sum[i, j] = new TextBox() { Name = (i + j).ToString() + "_res_sum", Location = new Point((30 * j + 30), i * 25), Text = res.value[i, j].ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_res.Controls.Add(matrix_sum[i, j]);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                "Матрицы сложить нельзя",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void MinusMatrix_Click(object sender, EventArgs e)
        {
            if (row1 == row2 & col1 == col2)
            {
                TextBox[,] matrix_minus = new TextBox[int.Parse(Row1.Text), int.Parse(Col1.Text)];

                int[,] input_mat1 = new int[row1, col1];
                int[,] input_mat2 = new int[row2, col2];

                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        input_mat1[i, j] = Convert.ToInt32(Matrix1[i, j].Text);
                        input_mat2[i, j] = Convert.ToInt32(Matrix2[i, j].Text);
                    }
                }

                Matrix m1 = new Matrix(input_mat1);
                Matrix m2 = new Matrix(input_mat2);
                Matrix res = mat_oper.Minus(m1, m2);

                pan_res.Controls.Clear();
                for (int i = 0; i < matrix_minus.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix_minus.GetLength(1); j++)
                    {
                        matrix_minus[i, j] = new TextBox() { Name = (i + j).ToString() + "_res_sum", Location = new Point((30 * j + 30), i * 25), Text = res.value[i, j].ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_res.Controls.Add(matrix_minus[i, j]);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                "Матрицы вычитать нельзя",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void MultiplayMatrix_Click(object sender, EventArgs e)
        {
            if (col1 == row2)
            {
                TextBox[,] matrix_multiplay = new TextBox[int.Parse(Row1.Text), int.Parse(Col2.Text)];
                int[,] input_mat1 = new int[row1, col1];
                int[,] input_mat2 = new int[row2, col2];


                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        input_mat1[i, j] = Convert.ToInt32(Matrix1[i, j].Text);
                    }
                }

                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        input_mat2[i, j] = Convert.ToInt32(Matrix2[i, j].Text);
                    }
                }

                Matrix m1 = new Matrix(input_mat1);
                Matrix m2 = new Matrix(input_mat2);
                Matrix res = mat_oper.Multiplay(m1, m2);

                pan_res.Controls.Clear();
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        matrix_multiplay[i, j] = new TextBox() { Name = (i + j).ToString() + "_res_sum", Location = new Point((30 * j + 30), i * 25), Text = res.value[i, j].ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                        pan_res.Controls.Add(matrix_multiplay[i, j]);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                "Матрицы перемножать нельзя",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void MultiplayNum1_Click_1(object sender, EventArgs e)
        {
            pan_num1.Controls.Clear();
            TextBox multiplayNum = new TextBox() { Name = "Num1", Location = new Point(0, 0), Text = "1", Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
            pan_num1.Controls.Add(multiplayNum);
        }


        private void Multiplay1_Click(object sender, EventArgs e)
        {
            TextBox[,] matrix_multiplay_num = new TextBox[int.Parse(Row1.Text), int.Parse(Col1.Text)];
            int[,] input_mat1 = new int[row1, col1];
            int k = Convert.ToInt32(this.Controls.Find("Num1", true)[0].Text);
            int m231;

            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix1.GetLength(1); j++)
                {
                    input_mat1[i, j] = Convert.ToInt32(Matrix1[i, j].Text);
                }
            }

            Matrix m1 = new Matrix(input_mat1);
            Matrix res = mat_oper.MultiplayNum(m1, k);

            pan_res.Controls.Clear();
            for (int i = 0; i < matrix_multiplay_num.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_multiplay_num.GetLength(1); j++)
                {
                    matrix_multiplay_num[i, j] = new TextBox() { Name = (i + j).ToString() + "_res_num", Location = new Point((30 * j + 30), i * 25), Text = res.value[i, j].ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                    pan_res.Controls.Add(matrix_multiplay_num[i, j]);
                }
            }
        }


        private void Transposition1_Click(object sender, EventArgs e)
        {
            TextBox[,] matrix_transposition = new TextBox[int.Parse(Col1.Text), int.Parse(Row1.Text)];

            int[,] input_mat1 = new int[row1, col1];

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    input_mat1[i, j] = Convert.ToInt32(Matrix1[i, j].Text);
                }
            }

            Matrix m1 = new Matrix(input_mat1);
            Matrix res = mat_oper.Transposition(m1);

            pan_res.Controls.Clear();
            for (int i = 0; i < matrix_transposition.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_transposition.GetLength(1); j++)
                {
                    matrix_transposition[i, j] = new TextBox() { Name = (i + j).ToString() + "_res_sum", Location = new Point((30 * j + 30), i * 25), Text = res.value[i, j].ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                    pan_res.Controls.Add(matrix_transposition[i, j]);
                }
            }
        }


        private void Transposition2_Click(object sender, EventArgs e)
        {
            TextBox[,] matrix_transposition = new TextBox[int.Parse(Col2.Text), int.Parse(Row2.Text)];

            int[,] input_mat2 = new int[row2, col2];

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    input_mat2[i, j] = Convert.ToInt32(Matrix2[i, j].Text);
                }
            }

            Matrix m1 = new Matrix(input_mat2);
            Matrix res = mat_oper.Transposition(m1);

            pan_res.Controls.Clear();
            for (int i = 0; i < matrix_transposition.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_transposition.GetLength(1); j++)
                {
                    matrix_transposition[i, j] = new TextBox() { Name = (i + j).ToString() + "_res_sum", Location = new Point((30 * j + 30), i * 25), Text = res.value[i, j].ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                    pan_res.Controls.Add(matrix_transposition[i, j]);
                }
            }
        }


        private void MultiplayNum2_Click(object sender, EventArgs e)
        {
            pan_num2.Controls.Clear();
            TextBox multiplayNum = new TextBox() { Name = "Num2", Location = new Point(0, 0), Text = "1", Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
            pan_num2.Controls.Add(multiplayNum);
        }


        private void Multiplay2_Click(object sender, EventArgs e)
        {
            TextBox[,] matrix_multiplay_num = new TextBox[int.Parse(Row2.Text), int.Parse(Col2.Text)];
            int[,] input_mat2 = new int[row2, col2];
            int k = Convert.ToInt32(this.Controls.Find("Num2", true)[0].Text);

            for (int i = 0; i < Matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix2.GetLength(1); j++)
                {
                    input_mat2[i, j] = Convert.ToInt32(Matrix2[i, j].Text);
                }
            }

            Matrix m1 = new Matrix(input_mat2);
            Matrix res = mat_oper.MultiplayNum(m1, k);

            pan_res.Controls.Clear();
            for (int i = 0; i < matrix_multiplay_num.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_multiplay_num.GetLength(1); j++)
                {
                    matrix_multiplay_num[i, j] = new TextBox() { Name = (i + j).ToString() + "_res_num", Location = new Point((30 * j + 30), i * 25), Text = res.value[i, j].ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                    pan_res.Controls.Add(matrix_multiplay_num[i, j]);
                }
            }
        }


        private void Det1_Click(object sender, EventArgs e)
        {
            if (row1 == col1)
            {
                int[,] input_mat1 = new int[row1, col1];

                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        input_mat1[i, j] = Convert.ToInt32(Matrix1[i, j].Text);
                    }
                }

                Matrix m1 = new Matrix(input_mat1);
                Double res = mat_oper.Determinant(m1, row1);
                //Double res = Matrix.determinantOfMatrix(m1, row1-1);

                

                pan_det1.Controls.Clear();
                TextBox det1 = new TextBox() { Name = "Det1", Location = new Point(0, 0), Text = res.ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                pan_det1.Controls.Add(det1);
            }
            else
            {
                MessageBox.Show(
                "Определитель посчитать нельзя",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }


        private void Det2_Click(object sender, EventArgs e)
        {
            if (row2 == col2)
            {
                int[,] input_mat2 = new int[row2, col2];

                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        input_mat2[i, j] = Convert.ToInt32(Matrix2[i, j].Text);
                    }
                }

                Matrix m2 = new Matrix(input_mat2);
                Double res = mat_oper.Determinant(m2, row1);

                pan_det2.Controls.Clear();
                TextBox det1 = new TextBox() { Name = "Det2", Location = new Point(0, 0), Text = res.ToString(), Height = 40, Width = 40, TextAlign = HorizontalAlignment.Center };
                pan_det2.Controls.Add(det1);
            }
            else
            {
                MessageBox.Show(
                "Определитель посчитать нельзя",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
