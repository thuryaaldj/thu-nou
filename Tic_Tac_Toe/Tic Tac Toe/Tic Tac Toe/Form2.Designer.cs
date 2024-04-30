namespace Tic_Tac_Toe
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pl = new System.Windows.Forms.Button();
            this.ex = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secound Player ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Location = new System.Drawing.Point(282, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox2.Location = new System.Drawing.Point(282, 217);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 24);
            this.textBox2.TabIndex = 3;
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.AliceBlue;
            this.pl.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pl.ForeColor = System.Drawing.Color.Black;
            this.pl.Location = new System.Drawing.Point(195, 289);
            this.pl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(109, 51);
            this.pl.TabIndex = 4;
            this.pl.Text = "Play";
            this.pl.UseVisualStyleBackColor = false;
            this.pl.Click += new System.EventHandler(this.pl_Click);
            // 
            // ex
            // 
            this.ex.BackColor = System.Drawing.Color.AliceBlue;
            this.ex.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ex.ForeColor = System.Drawing.Color.Black;
            this.ex.Location = new System.Drawing.Point(359, 289);
            this.ex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(104, 51);
            this.ex.TabIndex = 5;
            this.ex.Text = "Exit";
            this.ex.UseVisualStyleBackColor = false;
            this.ex.Click += new System.EventHandler(this.ex_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akhbar MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(62, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 68);
            this.label3.TabIndex = 6;
            this.label3.Text = "XO";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(539, 394);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button pl;
        private System.Windows.Forms.Button ex;
        private System.Windows.Forms.Label label3;
    }
}