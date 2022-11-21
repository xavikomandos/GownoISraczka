namespace KrzyzykIKolko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SrodekGorny = new System.Windows.Forms.Button();
            this.PrawyGorny = new System.Windows.Forms.Button();
            this.LewySrodek = new System.Windows.Forms.Button();
            this.Srodek = new System.Windows.Forms.Button();
            this.PrawySrodek = new System.Windows.Forms.Button();
            this.SrodekDol = new System.Windows.Forms.Button();
            this.LewyGorny = new System.Windows.Forms.Button();
            this.PrawyDol = new System.Windows.Forms.Button();
            this.LewyDol = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obecny Ruch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.SrodekGorny, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrawyGorny, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LewySrodek, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Srodek, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PrawySrodek, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SrodekDol, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LewyGorny, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrawyDol, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LewyDol, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 276);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // SrodekGorny
            // 
            this.SrodekGorny.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SrodekGorny.Location = new System.Drawing.Point(107, 3);
            this.SrodekGorny.Name = "SrodekGorny";
            this.SrodekGorny.Size = new System.Drawing.Size(98, 88);
            this.SrodekGorny.TabIndex = 1;
            this.SrodekGorny.UseVisualStyleBackColor = true;
            this.SrodekGorny.Click += new System.EventHandler(this.Mark);
            // 
            // PrawyGorny
            // 
            this.PrawyGorny.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrawyGorny.Location = new System.Drawing.Point(211, 3);
            this.PrawyGorny.Name = "PrawyGorny";
            this.PrawyGorny.Size = new System.Drawing.Size(99, 88);
            this.PrawyGorny.TabIndex = 2;
            this.PrawyGorny.UseVisualStyleBackColor = true;
            this.PrawyGorny.Click += new System.EventHandler(this.Mark);
            // 
            // LewySrodek
            // 
            this.LewySrodek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LewySrodek.Location = new System.Drawing.Point(3, 97);
            this.LewySrodek.Name = "LewySrodek";
            this.LewySrodek.Size = new System.Drawing.Size(98, 88);
            this.LewySrodek.TabIndex = 3;
            this.LewySrodek.UseVisualStyleBackColor = true;
            this.LewySrodek.Click += new System.EventHandler(this.Mark);
            // 
            // Srodek
            // 
            this.Srodek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Srodek.Location = new System.Drawing.Point(107, 97);
            this.Srodek.Name = "Srodek";
            this.Srodek.Size = new System.Drawing.Size(98, 88);
            this.Srodek.TabIndex = 4;
            this.Srodek.UseVisualStyleBackColor = true;
            this.Srodek.Click += new System.EventHandler(this.Mark);
            // 
            // PrawySrodek
            // 
            this.PrawySrodek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrawySrodek.Location = new System.Drawing.Point(211, 97);
            this.PrawySrodek.Name = "PrawySrodek";
            this.PrawySrodek.Size = new System.Drawing.Size(99, 88);
            this.PrawySrodek.TabIndex = 5;
            this.PrawySrodek.UseVisualStyleBackColor = true;
            this.PrawySrodek.Click += new System.EventHandler(this.Mark);
            // 
            // SrodekDol
            // 
            this.SrodekDol.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SrodekDol.Location = new System.Drawing.Point(107, 191);
            this.SrodekDol.Name = "SrodekDol";
            this.SrodekDol.Size = new System.Drawing.Size(98, 82);
            this.SrodekDol.TabIndex = 7;
            this.SrodekDol.UseVisualStyleBackColor = true;
            this.SrodekDol.Click += new System.EventHandler(this.Mark);
            // 
            // LewyGorny
            // 
            this.LewyGorny.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LewyGorny.Location = new System.Drawing.Point(3, 3);
            this.LewyGorny.Name = "LewyGorny";
            this.LewyGorny.Size = new System.Drawing.Size(98, 88);
            this.LewyGorny.TabIndex = 0;
            this.LewyGorny.UseVisualStyleBackColor = true;
            this.LewyGorny.Click += new System.EventHandler(this.Mark);
            // 
            // PrawyDol
            // 
            this.PrawyDol.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrawyDol.Location = new System.Drawing.Point(211, 191);
            this.PrawyDol.Name = "PrawyDol";
            this.PrawyDol.Size = new System.Drawing.Size(99, 82);
            this.PrawyDol.TabIndex = 8;
            this.PrawyDol.UseVisualStyleBackColor = true;
            this.PrawyDol.Click += new System.EventHandler(this.Mark);
            // 
            // LewyDol
            // 
            this.LewyDol.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LewyDol.Location = new System.Drawing.Point(3, 191);
            this.LewyDol.Name = "LewyDol";
            this.LewyDol.Size = new System.Drawing.Size(98, 82);
            this.LewyDol.TabIndex = 6;
            this.LewyDol.UseVisualStyleBackColor = true;
            this.LewyDol.Click += new System.EventHandler(this.Mark);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button LewyGorny;
        private Button SrodekGorny;
        private Button PrawyGorny;
        private Button LewySrodek;
        private Button Srodek;
        private Button PrawySrodek;
        private Button LewyDol;
        private Button SrodekDol;
        private Button PrawyDol;
    }
}