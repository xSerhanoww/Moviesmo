namespace movie_catalog_beta
{
    partial class MoviePoster
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            movieImage = new PictureBox();
            movieTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)movieImage).BeginInit();
            SuspendLayout();
            // 
            // movieImage
            // 
            movieImage.Location = new Point(7, 12);
            movieImage.Name = "movieImage";
            movieImage.Size = new Size(162, 253);
            movieImage.TabIndex = 0;
            movieImage.TabStop = false;
            movieImage.Click += MoviePoster_Click;
            // 
            // movieTitle
            // 
            movieTitle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            movieTitle.ForeColor = Color.White;
            movieTitle.Location = new Point(7, 269);
            movieTitle.Name = "movieTitle";
            movieTitle.Size = new Size(162, 38);
            movieTitle.TabIndex = 1;
            movieTitle.Text = "Title\r\n\r\n";
            movieTitle.TextAlign = ContentAlignment.MiddleCenter;
            movieTitle.Click += MoviePoster_Click;
            // 
            // MoviePoster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(movieTitle);
            Controls.Add(movieImage);
            Cursor = Cursors.Hand;
            Name = "MoviePoster";
            Size = new Size(176, 310);
            Click += MoviePoster_Click;
            MouseEnter += MoviePoster_MouseEnter;
            MouseLeave += MoviePoster_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)movieImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected internal PictureBox movieImage;
        protected internal Label movieTitle;
    }
}
