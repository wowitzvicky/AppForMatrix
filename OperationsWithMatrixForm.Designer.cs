using System.ComponentModel;

namespace AppForMatrix
{
    partial class OperationsWithMatrixForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbInputN = new System.Windows.Forms.TextBox();
            this.BtnMatrix1 = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnMatrix2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rowCellSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(118, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "n =";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbInputN
            // 
            this.TbInputN.Location = new System.Drawing.Point(176, 32);
            this.TbInputN.Name = "TbInputN";
            this.TbInputN.Size = new System.Drawing.Size(32, 22);
            this.TbInputN.TabIndex = 1;
            // 
            // BtnMatrix1
            // 
            this.BtnMatrix1.Location = new System.Drawing.Point(135, 80);
            this.BtnMatrix1.Name = "BtnMatrix1";
            this.BtnMatrix1.Size = new System.Drawing.Size(137, 29);
            this.BtnMatrix1.TabIndex = 2;
            this.BtnMatrix1.Text = "Ввод 1 матрицы";
            this.BtnMatrix1.UseVisualStyleBackColor = true;
            this.BtnMatrix1.Click += new System.EventHandler(this.BtnMatrix1_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(135, 168);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(137, 29);
            this.BtnResult.TabIndex = 3;
            this.BtnResult.Text = "Результат";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // BtnMatrix2
            // 
            this.BtnMatrix2.Location = new System.Drawing.Point(135, 124);
            this.BtnMatrix2.Name = "BtnMatrix2";
            this.BtnMatrix2.Size = new System.Drawing.Size(137, 29);
            this.BtnMatrix2.TabIndex = 4;
            this.BtnMatrix2.Text = "Ввод 2 матрицы";
            this.BtnMatrix2.UseVisualStyleBackColor = true;
            this.BtnMatrix2.Click += new System.EventHandler(this.BtnMatrix2_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(290, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "False";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(290, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "False";
            // 
            // button1
            // 
            this.rowCellSwitch.Location = new System.Drawing.Point(357, 252);
            this.rowCellSwitch.Name = "rowCellSwitch";
            this.rowCellSwitch.Size = new System.Drawing.Size(113, 34);
            this.rowCellSwitch.TabIndex = 7;
            this.rowCellSwitch.Text = "Обмен строк";
            this.rowCellSwitch.UseVisualStyleBackColor = true;
            this.rowCellSwitch.Click += new System.EventHandler(this.RowCellSwitch_Click);
            // 
            // OperationsWithMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 318);
            this.Controls.Add(this.rowCellSwitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMatrix2);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.BtnMatrix1);
            this.Controls.Add(this.TbInputN);
            this.Controls.Add(this.label1);
            this.Name = "OperationsWithMatrixForm";
            this.Text = "OperationsWithMatrixForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button rowCellSwitch;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Button BtnMatrix2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbInputN;
        private System.Windows.Forms.Button BtnMatrix1;

        #endregion
    }
}