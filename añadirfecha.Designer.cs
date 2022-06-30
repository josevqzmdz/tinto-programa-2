namespace tinto_programa_2
{
    partial class añadirfecha
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
            this.fechabtn = new System.Windows.Forms.Button();
            this.dialbl = new System.Windows.Forms.Label();
            this.DiaTxt = new System.Windows.Forms.TextBox();
            this.MesTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AñoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechabtn
            // 
            this.fechabtn.Location = new System.Drawing.Point(123, 138);
            this.fechabtn.Name = "fechabtn";
            this.fechabtn.Size = new System.Drawing.Size(132, 23);
            this.fechabtn.TabIndex = 0;
            this.fechabtn.Text = "introducir fecha";
            this.fechabtn.UseVisualStyleBackColor = true;
            this.fechabtn.Click += new System.EventHandler(this.fechabtn_Click);
            // 
            // dialbl
            // 
            this.dialbl.AutoSize = true;
            this.dialbl.Location = new System.Drawing.Point(33, 38);
            this.dialbl.Name = "dialbl";
            this.dialbl.Size = new System.Drawing.Size(29, 17);
            this.dialbl.TabIndex = 1;
            this.dialbl.Text = "Dia";
            // 
            // DiaTxt
            // 
            this.DiaTxt.Location = new System.Drawing.Point(123, 35);
            this.DiaTxt.Name = "DiaTxt";
            this.DiaTxt.Size = new System.Drawing.Size(100, 22);
            this.DiaTxt.TabIndex = 2;
            // 
            // MesTxt
            // 
            this.MesTxt.Location = new System.Drawing.Point(123, 77);
            this.MesTxt.Name = "MesTxt";
            this.MesTxt.Size = new System.Drawing.Size(100, 22);
            this.MesTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes";
            // 
            // AñoTxt
            // 
            this.AñoTxt.Location = new System.Drawing.Point(123, 107);
            this.AñoTxt.Name = "AñoTxt";
            this.AñoTxt.Size = new System.Drawing.Size(100, 22);
            this.AñoTxt.TabIndex = 6;
            this.AñoTxt.TextChanged += new System.EventHandler(this.FechaTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // añadirfecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 206);
            this.Controls.Add(this.AñoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MesTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiaTxt);
            this.Controls.Add(this.dialbl);
            this.Controls.Add(this.fechabtn);
            this.Name = "añadirfecha";
            this.Text = "añadirfecha";
            this.Load += new System.EventHandler(this.añadirfecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fechabtn;
        private System.Windows.Forms.Label dialbl;
        private System.Windows.Forms.TextBox DiaTxt;
        private System.Windows.Forms.TextBox MesTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AñoTxt;
        private System.Windows.Forms.Label label3;
    }
}