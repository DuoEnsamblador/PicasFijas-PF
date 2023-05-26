namespace WindowFormAppConsumoDLL
{
    partial class Pc2023_1_Fibunacci
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(111, 129);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "button1";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(111, 32);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(100, 20);
            this.txtT0.TabIndex = 1;
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(111, 76);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(100, 20);
            this.txtT1.TabIndex = 2;
            // 
            // Pc2023_1_Fibunacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 181);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Pc2023_1_Fibunacci";
            this.Text = "Pc2023_1_Fibunacci";
            this.Load += new System.EventHandler(this.Pc2023_1_Fibunacci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.TextBox txtT1;
    }
}