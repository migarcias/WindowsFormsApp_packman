using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_packman
{
    public partial class Form1 : Form
    {

        private Image[] pacmanImage = new Image[4];
        private int currentMouthPosition = 0;
        private int xPosition = 0;
        private int yPosition = 0;
        private int PxPh = 100;
        private int PyPh = 100;
        private int incdecx = 5;
        private int incdecy = 5;
        private int movpacd = 1;

        // The index of the current frame.
        private int FrameNum = 0;

 

        public Form1()
        {
            InitializeComponent();
            //this.KeyDown += newSystem.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }
        private void picFrame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(pacmanImage[currentMouthPosition], xPosition, yPosition, 32, 32);

        }

        // Load the images.
        private void Pacman_Load(object sender, EventArgs e)
        {
            pacmanImage[0] = Image.FromFile("..\\..\\pacman01.gif");
            pacmanImage[1] = Image.FromFile("..\\..\\pacman02.gif");
            pacmanImage[2] = Image.FromFile("..\\..\\pacman03.gif");
            pacmanImage[3] = Image.FromFile("..\\..\\pacman04.gif");
            // Display the first frame.
            picFrame.Image = pacmanImage[FrameNum];
        }


     

        // Display the next image.
        private void tmrNextFrame_Tick(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % pacmanImage.Length;
            picFrame.Image = pacmanImage[FrameNum];
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        // This is where I have tried to get the pictureBox to move
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    //picFrame.Location = new Point(10,10);
                    picFrame.Left -= 5;
                    picFrame.BackgroundImage =
                              WindowsFormsApp_packman.Properties.Resources.pacmand01; 

                    break;
                case Keys.Right:
                    picFrame.Left += 5;
                    break;
                case Keys.Up:
                    picFrame.Top -= 5;
                    break;
                case Keys.Down:
                    picFrame.Top += 5;
                    break;
            }
        }

  

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MuevePanthom();
        }
        void MuevePanthom()
        {
            if (PxPh > 600)
                incdecx = -5; ;
            if (PxPh < 1)
                incdecx = 5;
            PxPh += incdecx;
            picturePhantom.Left += incdecx;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MuevePanthomV();
        }
        void MuevePanthomV()
        {
            if (PyPh > 400)
                incdecy = -5; ;
            if (PyPh < 1)
                incdecy = 5;
            PyPh += incdecy;
            picturePhantomV.Top += incdecy;
        }
    }
}
