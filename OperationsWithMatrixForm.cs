using System;
using System.Windows.Forms;

namespace AppForMatrix
{
    public partial class OperationsWithMatrixForm : Form
    {
        private string Operation
        {
            set;
            get;
        }

        public Matrix Matrix1
        {
            set;
            get;
        }
        
        public Matrix Matrix2
        {
            set;
            get;
        }

        public Matrix MatrixResult
        {
            set;
            get;
        }

        private static bool _flag1 = false;
        private static bool _flag2 = false;
        public OperationsWithMatrixForm(string op)
        {
            InitializeComponent();
            Operation = op;
            if (op == "+")
            {
                this.Text = "Сложение матриц";
            }
            if (op == "-")
            {
                this.Text = "Вычитание матриц";
            }
            if (op == "*")
            {
                this.Text = "Умножение матриц";
            }
        }

        private void BtnMatrix1_Click(object sender, EventArgs e)
        {
            if (TbInputN.Text == "")
            {
                MessageBox.Show("Не введено значение n!");
                return;
            }

            int n = Convert.ToInt32(TbInputN.Text);
            if (n > 10)
            {
                MessageBox.Show("Значение n должно быть меньше 10!");
                return;
            }

            Matrix1 = new Matrix(n);
            MatrixOutput output = new MatrixOutput(Matrix1);
            if (output.ShowDialog() == DialogResult.OK)
            {
                Matrix m = output.Matrix;
                for (var i = 0; i < m.N; i++)
                for (var j = 0; j < m.N; j++)
                    Matrix1.Values[i, j] = m.Values[i, j];
                _flag1 = true;
                label2.Text = _flag1.ToString();
            }
        }
        
        private void BtnMatrix2_Click(object sender, EventArgs e)
        {
            if (!_flag1)
            {
                MessageBox.Show("Заполните первую матрицу");
                return;
            }
            if (TbInputN.Text == "")
            {
                MessageBox.Show("Не введено значение n!");
                return;
            }

            int n = Convert.ToInt32(TbInputN.Text);
            if (n > 10)
            {
                MessageBox.Show("Значение n должно быть меньше 10!");
                return;
            }

            Matrix2 = new Matrix(n);
            MatrixOutput output = new MatrixOutput(Matrix2);
            if (output.ShowDialog() == DialogResult.OK)
            {
                Matrix m = output.Matrix;
                for (var i = 0; i < m.N; i++)
                for (var j = 0; j < m.N; j++)
                    Matrix2.Values[i, j] = m.Values[i, j];
                _flag2 = true;
                label3.Text = _flag2.ToString();
            } 
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (!_flag1 && !_flag2)
            {
                MessageBox.Show("Матрицы не заполнены");
                return;
            }
            if (Operation == "+")
            {
                MatrixResult = Matrix1.Plus(Matrix2);
            }
            if (Operation == "-")
            {
                MatrixResult = Matrix1.Minus(Matrix2); 
            }
            if (Operation == "*")
            {
                MatrixResult = Matrix1.Multiply(Matrix2);
            }

            MatrixOutput res = new MatrixOutput(MatrixResult);
            res.Show();
        }

        private void RowCellSwitch_Click(object sender, EventArgs e)
        {
            
        }
    }
}