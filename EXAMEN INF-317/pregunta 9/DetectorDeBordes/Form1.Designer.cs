namespace DetectorDeBordes
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
            CarImagen = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            detecBord = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CarImagen
            // 
            CarImagen.Location = new Point(1435, 21);
            CarImagen.Name = "CarImagen";
            CarImagen.Size = new Size(132, 61);
            CarImagen.TabIndex = 0;
            CarImagen.Text = "Cargar Imagen";
            CarImagen.UseVisualStyleBackColor = true;
            CarImagen.Click += CarImagen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 853);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(729, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 853);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // detecBord
            // 
            detecBord.Location = new Point(1435, 102);
            detecBord.Name = "detecBord";
            detecBord.Size = new Size(132, 61);
            detecBord.TabIndex = 3;
            detecBord.Text = "Detectar Bordes";
            detecBord.UseVisualStyleBackColor = true;
            detecBord.Click += detecBord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 877);
            Controls.Add(detecBord);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(CarImagen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CarImagen;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button detecBord;
    }
}
