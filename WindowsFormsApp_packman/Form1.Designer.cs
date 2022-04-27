
namespace WindowsFormsApp_packman
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picturePhantomV = new System.Windows.Forms.PictureBox();
            this.picturePhantom = new System.Windows.Forms.PictureBox();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturePhantomV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhantom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picturePhantomV
            // 
            this.picturePhantomV.BackgroundImage = global::WindowsFormsApp_packman.Properties.Resources.panthomvd;
            this.picturePhantomV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePhantomV.Location = new System.Drawing.Point(200, 100);
            this.picturePhantomV.Name = "picturePhantomV";
            this.picturePhantomV.Size = new System.Drawing.Size(50, 46);
            this.picturePhantomV.TabIndex = 3;
            this.picturePhantomV.TabStop = false;
            // 
            // picturePhantom
            // 
            this.picturePhantom.BackgroundImage = global::WindowsFormsApp_packman.Properties.Resources.Phantom01;
            this.picturePhantom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePhantom.Location = new System.Drawing.Point(100, 100);
            this.picturePhantom.Name = "picturePhantom";
            this.picturePhantom.Size = new System.Drawing.Size(50, 46);
            this.picturePhantom.TabIndex = 2;
            this.picturePhantom.TabStop = false;
            // 
            // picFrame
            // 
            this.picFrame.BackgroundImage = global::WindowsFormsApp_packman.Properties.Resources.pacmani01;
            this.picFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrame.Location = new System.Drawing.Point(83, 99);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(58, 50);
            this.picFrame.TabIndex = 1;
            this.picFrame.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picturePhantomV);
            this.Controls.Add(this.picturePhantom);
            this.Controls.Add(this.picFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picturePhantomV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhantom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picFrame;
        private System.Windows.Forms.PictureBox picturePhantom;
        private System.Windows.Forms.PictureBox picturePhantomV;
        private System.Windows.Forms.Timer timer2;
    }
}

