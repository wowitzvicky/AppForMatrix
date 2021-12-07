using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppForMatrix
{
    public partial class MatrixOutput : Form
    {
        public Matrix Matrix
        {
            set;
            get;
        }
        public MatrixOutput(Matrix matrix)
        {
            Matrix = matrix;
            InitializeComponent();
            this.Size = new Size(500, 500);
            this.MaximumSize = new Size(500, 500);
            this.MinimumSize = new Size(500, 500);
            DgOutputMatrix.ColumnCount = Matrix.N;
            DgOutputMatrix.RowCount = Matrix.N;
            BtnOK.DialogResult = DialogResult.OK;
        }

        private void MatrixOutput_Load(object sender, EventArgs e)
        {
            int[,] values = Matrix.Values;
            int n = Matrix.N;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    DgOutputMatrix.Rows[i].Cells[j].Value = values[i, j].ToString();
                }
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int n = Matrix.N;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    string cell = DgOutputMatrix.Rows[i].Cells[j].Value.ToString();
                    var val = Convert.ToInt32(cell);
                    Matrix.Values[i, j] = val;
                }
            }
        }
    }
}