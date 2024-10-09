using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Text;
using System.Windows.Forms;

namespace DetectorDeBordes
{
    public partial class Form1 : Form
    {
        private Bitmap ImOriginal;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog AbrirDialogo = new OpenFileDialog())
            {
                AbrirDialogo.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (AbrirDialogo.ShowDialog() == DialogResult.OK)
                {
                    ImOriginal = new Bitmap(AbrirDialogo.FileName);

                    pictureBox1.Image = ImOriginal;
                }
            }
        }

        private void detecBord_Click(object sender, EventArgs e)
        {
            if (ImOriginal != null)
            {
                Grayscale EscGrices = new Grayscale(0.2125, 0.7154, 0.07221);
                Bitmap ImGris = EscGrices.Apply(ImOriginal);

                SobelEdgeDetector Deter = new SobelEdgeDetector();

                Bitmap Imagen = Deter.Apply(ImGris);

                pictureBox2.Image = Imagen;
            }
            else
            {
                MessageBox.Show("Cargar Imagen ");
            }
        }
    }
}
