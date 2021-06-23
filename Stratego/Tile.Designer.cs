
namespace Stratego
{
    partial class Tile
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
            this.characterImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // characterImg
            // 
            this.characterImg.BackColor = System.Drawing.Color.Transparent;
            this.characterImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.characterImg.InitialImage = null;
            this.characterImg.Location = new System.Drawing.Point(5, 5);
            this.characterImg.Margin = new System.Windows.Forms.Padding(0);
            this.characterImg.Name = "characterImg";
            this.characterImg.Size = new System.Drawing.Size(90, 90);
            this.characterImg.TabIndex = 0;
            this.characterImg.TabStop = false;
            // 
            // Tile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Stratego.Properties.Resources.tile;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.characterImg);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Tile";
            this.Size = new System.Drawing.Size(100, 100);
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox characterImg;
    }
}
