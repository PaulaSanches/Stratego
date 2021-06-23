using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratego
{
    public partial class Tile : UserControl
    {
        private Game game;
        private GamePiece gamepiece;
        private bool isVisible;
        public Tile()
        {
            InitializeComponent();
            this.Size = new Size(120, 120);
            this.gamepiece = new GamePiece();
            this.setGamePiece(Character.None, Owner.None);

            AllowDrop = true;

            MouseDown += Tile_MouseDown;
            DragEnter += Tile_DragEnter;
            DragLeave += Tile_DragLeave;
            DragDrop += Tile_DragDrop;

            characterImg.MouseDown += Tile_MouseDown;
            characterImg.DragEnter += Tile_DragEnter;
            characterImg.DragLeave += Tile_DragLeave;
            characterImg.DragDrop += Tile_DragDrop;
        }
        

        public void bindToGame(Game game)
        {
            this.game = game;
        }

        public GamePiece getGamePiece()
        {
            return this.gamepiece;
        }

        public void setGamePiece(GamePiece gp)
        {
            this.gamepiece = gp;
            updateImg();
        }

        public void setGamePiece(Character character, Owner owner)
        {
            setGamePiece(new GamePiece(character, owner));
        }

        public bool getVisibility()
        {
            return isVisible;
        }

        public void setVisibility(bool newVisible)
        {
            //????
            isVisible = newVisible;
            this.characterImg.Visible = isVisible;            
        }

        private void updateImg()
        {
            this.characterImg.Width = this.characterImg.Height = 90;
            this.characterImg.SizeMode = PictureBoxSizeMode.StretchImage;            

            switch (this.gamepiece.character)
            {
                //TODO: Bonus General/Sergent/Captain/Flag Images
                case Character.Captain:                    
                    this.characterImg.Image = Stratego.Properties.Resources.captain;                    
                    break;
                case Character.Sergeant:
                    this.characterImg.Image = Stratego.Properties.Resources.sergeant;                    
                    break;
                case Character.General:
                    this.characterImg.Image = Stratego.Properties.Resources.general;                    
                    break;
                case Character.Flag:
                    this.characterImg.Image = Stratego.Properties.Resources.flag;                    
                    break;
                default:
                    characterImg.Image = null;
                    break;
            }
            characterImg.Width = 100;
            characterImg.Height = 100;
            characterImg.SizeMode = PictureBoxSizeMode.StretchImage;

            switch (this.gamepiece.owner)
            {
                case Player.Player1:
                    this.BackgroundImage = Stratego.Properties.Resources.tile_blue;
                    break;
                case Player.Player2:
                    this.BackgroundImage = Stratego.Properties.Resources.tile_red;
                    break;
                default;
                    this.BackgroundImage = Stratego.Properties.Resources.tile;
                    break;

            }




        private void Tile_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("tile mouse down");
            form.registerMouseDown(this);
            DoDragDrop(this, DragDropEffects.Move);
        }

        private void Tile_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("tile drag enter");
            form.registerDrag(this);
            e.Effect = DragDropEffects.Move;
        }

        private void Tile_DragLeave(object sender, EventArgs e)
        {
            Console.WriteLine("tile drag leave");
        }

        private void Tile_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("tile drag drop");
            form.Move();
        }
    }
}
