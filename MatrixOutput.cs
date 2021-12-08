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
            var values = Matrix.Values;
            var n = Matrix.N;
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
            var n = Matrix.N;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var cell = DgOutputMatrix.Rows[i].Cells[j];
                    cell.Style.BackColor = Color.Brown;
                    var value = cell.Value;
                    var val = Convert.ToInt32(value);
                    Matrix.Values[i, j] = val;
                }
            }
        }
    }
}