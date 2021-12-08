using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppForMatrix
{
    public partial class DopZadForm : Form
    {
        private static int ROWS = 7;
        private static int COLUMNS = 7;
        public int rowColumn = 0;

        public int[,] arr = new int[ROWS, COLUMNS];
        public DopZadForm()
        {
            InitializeComponent();
            dataGridView1.RowCount = ROWS;
            dataGridView1.ColumnCount = COLUMNS;
            
            dataGridView2.RowCount = ROWS;
            dataGridView2.ColumnCount = COLUMNS;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Введите значение n!");
                return;
            }

            var n = Convert.ToInt32(textBox1.Text) - 1;
            
            if (n > ROWS || n < 0)
            {
                MessageBox.Show("Значение n введено некорректно.");
                return;
            }
            
            for (var i = 0; i < ROWS; i++)
            {
                (arr[n, i], arr[rowColumn, i]) = (arr[rowColumn, i], arr[n, i]);
            }
            
            for (var i = 0; i < ROWS; i++)
            {
                (arr[i, n], arr[i, rowColumn]) = (arr[i, rowColumn], arr[i, n]);
            }
            
            for (var i = 0; i < ROWS; i++)
            {
                for (var j = 0; j < COLUMNS; j++)
                {
                    var cell = dataGridView2.Rows[i].Cells[j];
                    cell.Value = arr[i, j];
                    
                    if (i == j)
                    {
                        cell.Style.BackColor = Color.Salmon;
                    }
                }
            }

            dataGridView2.Rows[n].Cells[n].Style.BackColor = Color.Chartreuse;
        }

        private void DopZadForm_Load(object sender, EventArgs e)
        {
            this.Updating();
        }

        private void Updating()
        {
            var rnd = new Random();

            for (var i = 0; i < ROWS; i++)
            {
                for (var j = 0; j < COLUMNS; j++)
                {
                    var cell = dataGridView1.Rows[i].Cells[j];
                    arr[i, j] = rnd.Next(-50, 50);
                    cell.Value = arr[i, j];
                    
                    if (i == j)
                    {
                        cell.Style.BackColor = Color.Salmon;
                    }
                }
            }

            int min = arr[0, 0];
            
            for (var i = 1; i < ROWS; i++)
            {
                if (arr[i, i] < min)
                {
                    min = arr[i, i];
                    rowColumn = i;
                }
            }

            dataGridView1.Rows[rowColumn].Cells[rowColumn].Style.BackColor = Color.Chartreuse;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Updating();
        }
    }
}