namespace movie_catalog_beta
{
    partial class AllMoviesForm
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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            moviesCatalog = new Panel();
            panel1 = new Panel();
            menuDirectors = new Label();
            directorsStrip = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            label4 = new Label();
            menuCountry = new Label();
            countryStrip = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuLabel = new Label();
            menuStrip = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            directorsStrip.SuspendLayout();
            countryStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Black;
            mainPanel.Controls.Add(moviesCatalog);
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1400, 693);
            mainPanel.TabIndex = 0;
            // 
            // moviesCatalog
            // 
            moviesCatalog.AutoScroll = true;
            moviesCatalog.Dock = DockStyle.Fill;
            moviesCatalog.Location = new Point(0, 100);
            moviesCatalog.Name = "moviesCatalog";
            moviesCatalog.Size = new Size(1400, 593);
            moviesCatalog.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuDirectors);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(menuCountry);
            panel1.Controls.Add(menuLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 100);
            panel1.TabIndex = 3;
            // 
            // menuDirectors
            // 
            menuDirectors.AutoSize = true;
            menuDirectors.ContextMenuStrip = directorsStrip;
            menuDirectors.Cursor = Cursors.Hand;
            menuDirectors.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuDirectors.ForeColor = Color.White;
            menuDirectors.Location = new Point(1277, 61);
            menuDirectors.Name = "menuDirectors";
            menuDirectors.Size = new Size(95, 23);
            menuDirectors.TabIndex = 2;
            menuDirectors.Text = "Directors";
            menuDirectors.MouseLeave += menuDirectors_MouseLeave;
            menuDirectors.MouseHover += menuDirectors_MouseHover;
            // 
            // directorsStrip
            // 
            directorsStrip.BackColor = SystemColors.WindowFrame;
            directorsStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            directorsStrip.Name = "directorsStrip";
            directorsStrip.Size = new Size(233, 30);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(232, 26);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(50, 51);
            label4.Name = "label4";
            label4.Size = new Size(226, 33);
            label4.TabIndex = 1;
            label4.Text = "Recommended";
            // 
            // menuCountry
            // 
            menuCountry.AutoSize = true;
            menuCountry.ContextMenuStrip = countryStrip;
            menuCountry.Cursor = Cursors.Hand;
            menuCountry.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuCountry.ForeColor = Color.White;
            menuCountry.Location = new Point(1170, 61);
            menuCountry.Name = "menuCountry";
            menuCountry.Size = new Size(87, 23);
            menuCountry.TabIndex = 2;
            menuCountry.Text = "Country";
            menuCountry.MouseLeave += menuCountry_MouseLeave;
            menuCountry.MouseHover += menuCountry_MouseHover;
            // 
            // countryStrip
            // 
            countryStrip.BackColor = SystemColors.WindowFrame;
            countryStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            countryStrip.Name = "countryStrip";
            countryStrip.Size = new Size(233, 30);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(232, 26);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.ContextMenuStrip = menuStrip;
            menuLabel.Cursor = Cursors.Hand;
            menuLabel.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuLabel.ForeColor = Color.White;
            menuLabel.Location = new Point(1071, 61);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(71, 23);
            menuLabel.TabIndex = 2;
            menuLabel.Text = "Genre";
            menuLabel.MouseLeave += menuLabel_MouseLeave;
            menuLabel.MouseHover += menuLabel_MouseHover;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.WindowFrame;
            menuStrip.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(195, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(194, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // AllMoviesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 693);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllMoviesForm";
            Text = "AllMoviesForm";
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            directorsStrip.ResumeLayout(false);
            countryStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label menuLabel;
        private ContextMenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label menuCountry;
        private Label menuDirectors;
        private ContextMenuStrip countryStrip;
        private ContextMenuStrip directorsStrip;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Panel moviesCatalog;
        private Panel panel1;
        protected internal Panel mainPanel;
    }
}