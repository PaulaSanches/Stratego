using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Stratego
{
    public partial class GameForm : Form
    {
        Game game;
        Tile[,] tiles;
        
        DateTime lastTickTime;
        private TimeSpan elapsedGameTime;

        public GameForm()
        {
            InitializeComponent();

            GameStatics.GridSize = tableGameboard.RowCount;
            tiles = new Tile[GameStatics.GridSize, GameStatics.GridSize];

            elapsedGameTime = TimeSpan.Zero;
            lblTime.Text = elapsedGameTime.ToString();

            lastTickTime = DateTime.Now;
            initBoard();

            game = new Game(this, tiles);
        }
        private void initBoard()
        {
            for (int i = 0; i < GameStatics.GridSize; i++)
            {
                for (int j = 0; j < GameStatics.GridSize; j++)
                {
                    tiles[i,j] = new Tile();
                    tableGameboard.Controls.Add(tiles[i,j], i, j);
                }
            }
        }
        private bool quit()
        {
            return true;
            
        }


        ///////////////////////////////////////////////
        /// Timer functionality
        ///////////////////////////////////////////////
        public void startTimer()
        {
            timer1
        }
        public void pauseTimer()
        {
      
        }
        public void resumeTimer()
        {
            lastTickTime = DateTime.Now;

        }
        public void resetTimer()
        {

        }
        public void timer_Tick(object sender, EventArgs e)
        {
            elapsedGameTime += DateTime.Now.Subtract(lastTickTime);
            lastTickTime = DateTime.Now;
            updateTimerText(true);
        }
        private void updateTimerText(bool isTimerRunning)
        {
            if (!isTimerRunning)
            {
                lblTime.Text = "00:00";
                return;
            }
            lblTime.Text = string.Format("{0:D2}:{1:D2}", elapsedGameTime.Minutes, elapsedGameTme.Seconds;

        public void setTime(TimeSpan newSpan)
        {
            elapsedGameTime = newSpan;
            updateTimerText
        }
        public TimeSpan getTime()
        {
            return elapsedGameTime;
        }

        ///////////////////////////////////////////////
        /// Game info display updates
        ///////////////////////////////////////////////
        public void setPausedOverlay(bool visible)
        {
            this.pnlPaused.Visible = visible;
        }
        public void setWinnerOverlay(Owner winner, bool visible)
        {
                lblWinnerName.Text = winner.ToString();
                pnlWin.Visible = visible;
        }
        // Altera label da Phase
        public void setPhaseDisplay(GameState state)
        {
            if (state == GameState.PreGame)
                lblPhase.Text = "Formation";
            if (state == GameState.InGame)
                lblPhase.Text = "In Game";
            if (state == GameState.PostGame)
                lblPhase.Text = "Post Game";
            if (state == GameState.Paused)
                lblPhase.Text = "Paused";
        
         }

            lblPhase.Text = lblPhase.mESSAGE;

        public void setCurrentPlayerDisplay(Owner player)
        {
            if (player == Stratego.Owner.Player1)
                radioPlayer1_Checked = true;
            //if (player == Stratego.Owner.Player2)
              //  lblTurnPlayer.Text = "Player 2";
        }


        ///////////////////////////////////////////////
        /// Form interaction events
        ///////////////////////////////////////////////
        private void btnStart_Click(object sender, EventArgs e)
        {

        }
        private void btnPause_Click(object sender, EventArgs e)
        {
                game.pauseGame();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
         game.
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
                game.stopGame();
        }
        private void btnResume_Click(object sender, EventArgs e)
        {
                game.resumeGame();
        }
        private void radioPlayer1_Click(object sender, EventArgs e)
        {
            game.setPlayer(Stratego.Owner.Player1);
        }
        private void radioPlayer2_Click(object sender, EventArgs e)
        {
            game.setPlayer(Stratego.Owner.Player2);
        }
        private void menuFileLoad_Click(object sender, EventArgs e)
        {
         // is the game state inGame
         // confimr to override cuuretgame
         // show opnefile dialog 
         // game.loadgamefromfile (file name)
        }
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            // if game is onderwway puased it
            // if game is paused 
            // shownad say file dialog
            // game.Savegane (filegame)
            // dispaly results
        }
        private void menuFileQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void menuHelpInstructions_Click(object sender, EventArgs e)
        {

        }
        private void menuHelpWiki_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://en.wikipedia.org/wiki/Stratego");
            Process.Start(sInfo);
        }
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!quit)             {
                e.Cancel = true;
            }
        }
    }
}
