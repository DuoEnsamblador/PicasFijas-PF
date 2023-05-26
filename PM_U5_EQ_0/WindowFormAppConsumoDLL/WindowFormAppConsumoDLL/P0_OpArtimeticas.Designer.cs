namespace WindowFormAppConsumoDLL
{
    partial class P0_OpArtimeticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ExecuteSum = new System.Windows.Forms.Button();
            this.txt_numA = new System.Windows.Forms.TextBox();
            this.txt_numB = new System.Windows.Forms.TextBox();
            this.txt_SumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Aritmeticas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result:";
            // 
            // btn_ExecuteSum
            // 
            this.btn_ExecuteSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExecuteSum.Location = new System.Drawing.Point(34, 136);
            this.btn_ExecuteSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ExecuteSum.Name = "btn_ExecuteSum";
            this.btn_ExecuteSum.Size = new System.Drawing.Size(76, 25);
            this.btn_ExecuteSum.TabIndex = 4;
            this.btn_ExecuteSum.Text = "Execute";
            this.btn_ExecuteSum.UseVisualStyleBackColor = true;
            this.btn_ExecuteSum.Click += new System.EventHandler(this.btn_ExecuteSum_Click);
            // 
            // txt_numA
            // 
            this.txt_numA.Location = new System.Drawing.Point(34, 44);
            this.txt_numA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_numA.Name = "txt_numA";
            this.txt_numA.Size = new System.Drawing.Size(76, 20);
            this.txt_numA.TabIndex = 9;
            // 
            // txt_numB
            // 
            this.txt_numB.Location = new System.Drawing.Point(34, 69);
            this.txt_numB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_numB.Name = "txt_numB";
            this.txt_numB.Size = new System.Drawing.Size(76, 20);
            this.txt_numB.TabIndex = 10;
            // 
            // txt_SumResult
            // 
            this.txt_SumResult.Location = new System.Drawing.Point(70, 106);
            this.txt_SumResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SumResult.Name = "txt_SumResult";
            this.txt_SumResult.Size = new System.Drawing.Size(76, 20);
            this.txt_SumResult.TabIndex = 11;
            // 
            // P0_OpArtimeticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 171);
            this.Controls.Add(this.txt_SumResult);
            this.Controls.Add(this.txt_numB);
            this.Controls.Add(this.txt_numA);
            this.Controls.Add(this.btn_ExecuteSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "P0_OpArtimeticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P0_OpArtimeticas";
            this.Load += new System.EventHandler(this.Programa_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ExecuteSum;
        private System.Windows.Forms.TextBox txt_numA;
        private System.Windows.Forms.TextBox txt_numB;
        private System.Windows.Forms.TextBox txt_SumResult;
    }
}