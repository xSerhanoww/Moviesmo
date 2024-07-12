namespace movie_catalog_beta
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
            panel1 = new Panel();
            SidePanel = new Panel();
            movies_btn = new Button();
            home_btn = new Button();
            exitLbl = new Label();
            label2 = new Label();
            label1 = new Label();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(movies_btn);
            panel1.Controls.Add(home_btn);
            panel1.Controls.Add(exitLbl);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 107);
            panel1.TabIndex = 1;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.DarkRed;
            SidePanel.Location = new Point(-2, 96);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(151, 10);
            SidePanel.TabIndex = 4;
            // 
            // movies_btn
            // 
            movies_btn.Cursor = Cursors.Hand;
            movies_btn.FlatAppearance.BorderSize = 0;
            movies_btn.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            movies_btn.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            movies_btn.FlatStyle = FlatStyle.Flat;
            movies_btn.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            movies_btn.ForeColor = Color.White;
            movies_btn.Location = new Point(150, 44);
            movies_btn.Name = "movies_btn";
            movies_btn.Size = new Size(146, 62);
            movies_btn.TabIndex = 3;
            movies_btn.Text = "MOVIES";
            movies_btn.UseVisualStyleBackColor = true;
            movies_btn.Click += movies_btn_Click;
            // 
            // home_btn
            // 
            home_btn.Cursor = Cursors.Hand;
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            home_btn.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            home_btn.FlatStyle = FlatStyle.Flat;
            home_btn.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            home_btn.ForeColor = Color.White;
            home_btn.Location = new Point(0, 45);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(149, 62);
            home_btn.TabIndex = 3;
            home_btn.Text = "HOME";
            home_btn.UseVisualStyleBackColor = true;
            home_btn.Click += home_btn_Click;
            // 
            // exitLbl
            // 
            exitLbl.AutoSize = true;
            exitLbl.Cursor = Cursors.Hand;
            exitLbl.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitLbl.ForeColor = Color.White;
            exitLbl.Location = new Point(1351, 25);
            exitLbl.Name = "exitLbl";
            exitLbl.Size = new Size(24, 23);
            exitLbl.TabIndex = 2;
            exitLbl.Text = "X";
            exitLbl.Click += exitLbl_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1458, 16);
            label2.Name = "label2";
            label2.Size = new Size(24, 23);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Edwardian Script ITC", 55F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(569, 25);
            label1.Name = "label1";
            label1.Size = new Size(288, 87);
            label1.TabIndex = 0;
            label1.Text = "Moviesmo'";
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 107);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1400, 693);
            mainPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 800);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exitLbl;
        private Label label2;
        private Label label1;
        private Panel mainPanel;
        private Button movies_btn;
        private Button home_btn;
        private Panel SidePanel;
    }
}
