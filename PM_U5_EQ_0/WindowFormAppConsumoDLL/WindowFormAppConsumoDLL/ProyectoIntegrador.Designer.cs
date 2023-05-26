namespace WindowFormAppConsumoDLL
{
    partial class ProyectoIntegrador
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
            this.btn_jugar = new System.Windows.Forms.Button();
            this.txt_num_pc = new System.Windows.Forms.TextBox();
            this.txt_num_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_digits = new System.Windows.Forms.TextBox();
            this.btm_establecer = new System.Windows.Forms.Button();
            this.btn_auto_solucion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_jugar
            // 
            this.btn_jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jugar.Location = new System.Drawing.Point(267, 322);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(169, 40);
            this.btn_jugar.TabIndex = 0;
            this.btn_jugar.Text = "JUGAR";
            this.btn_jugar.UseVisualStyleBackColor = true;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // txt_num_pc
            // 
            this.txt_num_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_pc.Location = new System.Drawing.Point(236, 160);
            this.txt_num_pc.Name = "txt_num_pc";
            this.txt_num_pc.ReadOnly = true;
            this.txt_num_pc.Size = new System.Drawing.Size(174, 38);
            this.txt_num_pc.TabIndex = 20;
            this.txt_num_pc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_num_user
            // 
            this.txt_num_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_user.Location = new System.Drawing.Point(241, 241);
            this.txt_num_user.Name = "txt_num_user";
            this.txt_num_user.Size = new System.Drawing.Size(174, 38);
            this.txt_num_user.TabIndex = 2;
            this.txt_num_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "PC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "USER:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL DIGITS:";
            // 
            // txt_total_digits
            // 
            this.txt_total_digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_digits.Location = new System.Drawing.Point(241, 47);
            this.txt_total_digits.Name = "txt_total_digits";
            this.txt_total_digits.Size = new System.Drawing.Size(195, 38);
            this.txt_total_digits.TabIndex = 5;
            this.txt_total_digits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btm_establecer
            // 
            this.btm_establecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_establecer.Location = new System.Drawing.Point(241, 91);
            this.btm_establecer.Name = "btm_establecer";
            this.btm_establecer.Size = new System.Drawing.Size(195, 40);
            this.btm_establecer.TabIndex = 1;
            this.btm_establecer.Text = "ESTABLECER";
            this.btm_establecer.UseVisualStyleBackColor = true;
            this.btm_establecer.Click += new System.EventHandler(this.btm_establecer_Click);
            // 
            // btn_auto_solucion
            // 
            this.btn_auto_solucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auto_solucion.Location = new System.Drawing.Point(49, 322);
            this.btn_auto_solucion.Name = "btn_auto_solucion";
            this.btn_auto_solucion.Size = new System.Drawing.Size(169, 40);
            this.btn_auto_solucion.TabIndex = 8;
            this.btn_auto_solucion.Text = "AUTO SOL.";
            this.btn_auto_solucion.UseVisualStyleBackColor = true;
            this.btn_auto_solucion.Click += new System.EventHandler(this.btn_auto_solucion_Click);
            // 
            // ProyectoIntegrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 442);
            this.Controls.Add(this.btn_auto_solucion);
            this.Controls.Add(this.btm_establecer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_total_digits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num_user);
            this.Controls.Add(this.txt_num_pc);
            this.Controls.Add(this.btn_jugar);
            this.Name = "ProyectoIntegrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProyectoIntegrador";
            this.Load += new System.EventHandler(this.ProyectoIntegrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.TextBox txt_num_pc;
        private System.Windows.Forms.TextBox txt_num_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total_digits;
        private System.Windows.Forms.Button btm_establecer;
        private System.Windows.Forms.Button btn_auto_solucion;
    }
}