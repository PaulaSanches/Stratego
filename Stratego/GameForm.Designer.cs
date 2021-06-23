
namespace Stratego
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.tableGameboard = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimeLabel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlPaused = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPlayer2 = new System.Windows.Forms.RadioButton();
            this.radioPlayer1 = new System.Windows.Forms.RadioButton();
            this.lblGameState = new System.Windows.Forms.Label();
            this.lblTurnTitle = new System.Windows.Forms.Label();
            this.lblTurnPlayer = new System.Windows.Forms.Label();
            this.pnlWin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWinnerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPaused.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableGameboard
            // 
            this.tableGameboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableGameboard.ColumnCount = 6;
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableGameboard.Location = new System.Drawing.Point(59, 52);
            this.tableGameboard.Margin = new System.Windows.Forms.Padding(0);
            this.tableGameboard.Name = "tableGameboard";
            this.tableGameboard.RowCount = 6;
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableGameboard.Size = new System.Drawing.Size(600, 600);
            this.tableGameboard.TabIndex = 0;
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.AutoSize = true;
            this.lblTimeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLabel.Location = new System.Drawing.Point(702, 201);
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Size = new System.Drawing.Size(182, 29);
            this.lblTimeLabel.TabIndex = 1;
            this.lblTimeLabel.Text = "Elapsed Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(873, 202);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 29);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(722, 365);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(215, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(722, 405);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(101, 34);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(722, 494);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 73);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlPaused
            // 
            this.pnlPaused.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlPaused.Controls.Add(this.label1);
            this.pnlPaused.Location = new System.Drawing.Point(87, 225);
            this.pnlPaused.Name = "pnlPaused";
            this.pnlPaused.Size = new System.Drawing.Size(543, 151);
            this.pnlPaused.TabIndex = 6;
            this.pnlPaused.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paused";
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(829, 405);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(108, 34);
            this.btnResume.TabIndex = 7;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPlayer2);
            this.groupBox1.Controls.Add(this.radioPlayer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(815, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Player control";
            // 
            // radioPlayer2
            // 
            this.radioPlayer2.AutoSize = true;
            this.radioPlayer2.Location = new System.Drawing.Point(21, 52);
            this.radioPlayer2.Name = "radioPlayer2";
            this.radioPlayer2.Size = new System.Drawing.Size(83, 24);
            this.radioPlayer2.TabIndex = 1;
            this.radioPlayer2.Text = "Player 2";
            this.radioPlayer2.UseVisualStyleBackColor = true;
            this.radioPlayer2.Click += new System.EventHandler(this.radioPlayer2_Click);
            // 
            // radioPlayer1
            // 
            this.radioPlayer1.AutoSize = true;
            this.radioPlayer1.Checked = true;
            this.radioPlayer1.Location = new System.Drawing.Point(21, 25);
            this.radioPlayer1.Name = "radioPlayer1";
            this.radioPlayer1.Size = new System.Drawing.Size(83, 24);
            this.radioPlayer1.TabIndex = 0;
            this.radioPlayer1.TabStop = true;
            this.radioPlayer1.Text = "Player 1";
            this.radioPlayer1.UseVisualStyleBackColor = true;
            this.radioPlayer1.Click += new System.EventHandler(this.radioPlayer1_Click);
            // 
            // lblGameState
            // 
            this.lblGameState.AutoSize = true;
            this.lblGameState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameState.Location = new System.Drawing.Point(718, 268);
            this.lblGameState.Name = "lblGameState";
            this.lblGameState.Size = new System.Drawing.Size(115, 20);
            this.lblGameState.TabIndex = 9;
            this.lblGameState.Text = "Current Phase:";
            // 
            // lblTurnTitle
            // 
            this.lblTurnTitle.AutoSize = true;
            this.lblTurnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnTitle.Location = new System.Drawing.Point(788, 301);
            this.lblTurnTitle.Name = "lblTurnTitle";
            this.lblTurnTitle.Size = new System.Drawing.Size(45, 20);
            this.lblTurnTitle.TabIndex = 10;
            this.lblTurnTitle.Text = "Turn:";
            // 
            // lblTurnPlayer
            // 
            this.lblTurnPlayer.AutoSize = true;
            this.lblTurnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnPlayer.Location = new System.Drawing.Point(839, 301);
            this.lblTurnPlayer.Name = "lblTurnPlayer";
            this.lblTurnPlayer.Size = new System.Drawing.Size(58, 20);
            this.lblTurnPlayer.TabIndex = 11;
            this.lblTurnPlayer.Text = "Player";
            // 
            // pnlWin
            // 
            this.pnlWin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlWin.Controls.Add(this.pictureBox1);
            this.pnlWin.Controls.Add(this.lblWinnerName);
            this.pnlWin.Controls.Add(this.label2);
            this.pnlWin.Location = new System.Drawing.Point(87, 79);
            this.pnlWin.Name = "pnlWin";
            this.pnlWin.Size = new System.Drawing.Size(543, 549);
            this.pnlWin.TabIndex = 7;
            this.pnlWin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stratego.Properties.Resources.winner;
            this.pictureBox1.Location = new System.Drawing.Point(34, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblWinnerName
            // 
            this.lblWinnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWinnerName.AutoSize = true;
            this.lblWinnerName.Font = new System.Drawing.Font("Dubai", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerName.Location = new System.Drawing.Point(276, 395);
            this.lblWinnerName.Name = "lblWinnerName";
            this.lblWinnerName.Size = new System.Drawing.Size(207, 108);
            this.lblWinnerName.TabIndex = 1;
            this.lblWinnerName.Text = "Player";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 108);
            this.label2.TabIndex = 0;
            this.label2.Text = "Winner: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "STRATEGO";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhase.Location = new System.Drawing.Point(839, 268);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(59, 20);
            this.lblPhase.TabIndex = 13;
            this.lblPhase.Text = "Phase";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(722, 445);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(215, 34);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 673);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlWin);
            this.Controls.Add(this.lblTurnPlayer);
            this.Controls.Add(this.lblTurnTitle);
            this.Controls.Add(this.lblGameState);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.pnlPaused);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeLabel);
            this.Controls.Add(this.tableGameboard);
            this.Name = "GameForm";
            this.Text = "Stratego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.pnlPaused.ResumeLayout(false);
            this.pnlPaused.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlWin.ResumeLayout(false);
            this.pnlWin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableGameboard;
        private System.Windows.Forms.Label lblTimeLabel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlPaused;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPlayer2;
        private System.Windows.Forms.RadioButton radioPlayer1;
        private System.Windows.Forms.Label lblGameState;
        private System.Windows.Forms.Label lblTurnTitle;
        private System.Windows.Forms.Label lblTurnPlayer;
        private System.Windows.Forms.Panel pnlWin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinnerName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
    }
}

