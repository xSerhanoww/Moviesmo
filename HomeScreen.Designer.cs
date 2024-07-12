namespace movie_catalog_beta
{
    partial class HomeScreen
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
            topPicksPanel = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            PosterPanel = new Panel();
            label3 = new Label();
            topPicksPanel.SuspendLayout();
            PosterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPicksPanel
            // 
            topPicksPanel.BackColor = Color.Black;
            topPicksPanel.Controls.Add(label4);
            topPicksPanel.Dock = DockStyle.Top;
            topPicksPanel.Location = new Point(0, 411);
            topPicksPanel.Name = "topPicksPanel";
            topPicksPanel.Size = new Size(1383, 403);
            topPicksPanel.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(16, 6);
            label4.Name = "label4";
            label4.Size = new Size(146, 32);
            label4.TabIndex = 0;
            label4.Text = "TOP PICKS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 27);
            panel2.TabIndex = 4;
            // 
            // PosterPanel
            // 
            PosterPanel.Controls.Add(label3);
            PosterPanel.Dock = DockStyle.Top;
            PosterPanel.Location = new Point(0, 0);
            PosterPanel.Name = "PosterPanel";
            PosterPanel.Size = new Size(1383, 384);
            PosterPanel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 50F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(1289, 147);
            label3.Name = "label3";
            label3.Size = new Size(76, 81);
            label3.TabIndex = 0;
            label3.Text = ">";
            label3.Click += label3_Click;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseHover += label3_MouseHover;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1400, 693);
            Controls.Add(topPicksPanel);
            Controls.Add(panel2);
            Controls.Add(PosterPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeScreen";
            Text = "HomeScreen";
            topPicksPanel.ResumeLayout(false);
            topPicksPanel.PerformLayout();
            PosterPanel.ResumeLayout(false);
            PosterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected internal Panel topPicksPanel;
        protected internal Label label4;
        protected internal Panel panel2;
        protected internal Panel PosterPanel;
        protected internal Label label3;
    }
}