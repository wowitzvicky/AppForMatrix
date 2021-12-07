using System.ComponentModel;

namespace AppForMatrix
{
    partial class MatrixOutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgOutputMatrix = new System.Windows.Forms.DataGridView();
            this.BtnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.DgOutputMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // DgOutputMatrix
            // 
            this.DgOutputMatrix.AllowUserToAddRows = false;
            this.DgOutputMatrix.AllowUserToDeleteRows = false;
            this.DgOutputMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgOutputMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgOutputMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgOutputMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgOutputMatrix.Location = new System.Drawing.Point(0, 0);
            this.DgOutputMatrix.Name = "DgOutputMatrix";
            this.DgOutputMatrix.RowTemplate.Height = 24;
            this.DgOutputMatrix.Size = new System.Drawing.Size(800, 450);
            this.DgOutputMatrix.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 402);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(76, 36);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // MatrixOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.DgOutputMatrix);
            this.Name = "MatrixOutput";
            this.Text = "MatrixOutput";
            this.Load += new System.EventHandler(this.MatrixOutput_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DgOutputMatrix)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BtnOK;

        private System.Windows.Forms.DataGridView DgOutputMatrix;

        #endregion
    }
}