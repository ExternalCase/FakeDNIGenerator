using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;


            label18.Parent = pictureBox1;
            label18.BackColor = Color.Transparent;

            label18.Parent = foto_rostro__img;
            label18.BackColor = Color.Transparent;

            t_dni.Parent = pictureBox1;
            t_dni.BackColor = Color.Transparent;

            t__.Parent = pictureBox1;
            t__.BackColor = Color.Transparent;

            t_cuit.Parent = pictureBox1;
            t_cuit.BackColor = Color.Transparent;

            t_primer_apellido.Parent = pictureBox1;
            t_primer_apellido.BackColor = Color.Transparent;

            t_segundo_apellido.Parent = pictureBox1;
            t_segundo_apellido.BackColor = Color.Transparent;

            t_nombres.Parent = pictureBox1;
            t_nombres.BackColor = Color.Transparent;

            t_fecha_nacimiento.Parent = pictureBox1;
            t_fecha_nacimiento.BackColor = Color.Transparent;

            t_ubigeo.Parent =  pictureBox1;
            t_ubigeo.BackColor = Color.Transparent;

            t_sexo.Parent = pictureBox1;
            t_sexo.BackColor = Color.Transparent;

            t_estadoc.Parent = pictureBox1;
            t_estadoc.BackColor = Color.Transparent;

            t_apellido.Parent = pictureBox1;
            t_apellido.BackColor = Color.Transparent;

            t_code.Parent = pictureBox1;
            t_code.BackColor = Color.Transparent;

            t_inscripcion.Parent = pictureBox1;
            t_inscripcion.BackColor = Color.Transparent;

            t_emision.Parent = pictureBox1;
            t_emision.BackColor = Color.Transparent;

            t_caducidad.Parent = pictureBox1;
            t_caducidad.BackColor = Color.Transparent;

            foto_rostro__img.Parent = pictureBox1;
            foto_rostro__img.BackColor = Color.Transparent;

            foto_firma__img.Parent = pictureBox1;
            foto_firma__img.BackColor = Color.Transparent;

            foto_miniatura__img.Parent = pictureBox1;
            foto_miniatura__img.BackColor = Color.Transparent;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            var verticaldni = dnivertical.Text;
            var Dni = m_dni.Text;
            var Nombres = m_nombres.Text;
            var Apellido_Paterno = m_apellidopaterno.Text;
            var Apellido_Materno = m_apellidomaterno.Text;
            var FechaNacimiento = m_fecha_nacimiento.Text;
            var Ubigeo = m_ubigeo.Text;
            var Sexo = m_sexo.Text;
            var EstadoCivil = m_estadocivil.Text;
            var FechaInscripcion = m_feInscripcion.Text;
            var FechaEmision = m_feEmision.Text;
            var FechaCaducidad = m_feCaducidad.Text;
            var ApellidoPrincipal = m_apellidopaterno.Text;
            var Cui = m_cuit.Text;
            var CodeBBox = richTextBox1.Text;

            t_code.Text = CodeBBox.ToString();
            t_dni.Text = Dni.ToString();
            t_cuit.Text = Cui.ToString();
            t_nombres.Text = Nombres.ToString();
            t_primer_apellido.Text = Apellido_Paterno.ToString();
            t_segundo_apellido.Text = Apellido_Materno.ToString();
            t_fecha_nacimiento.Text = FechaNacimiento.ToString();
            t_ubigeo.Text = Ubigeo.ToString();
            t_sexo.Text = Sexo.ToString();
            t_estadoc.Text = EstadoCivil.ToString();
            t_inscripcion.Text = FechaInscripcion.ToString();
            t_emision.Text = FechaEmision.ToString();
            t_caducidad.Text = FechaCaducidad.ToString();
            t_apellido.Text = ApellidoPrincipal.ToString();
            label18.Text = verticaldni.ToString();


        }

        private void label18_Paint(object sender, PaintEventArgs e)
        {
            //var verticaldni = dnivertical.Text;
            Font myfont = new Font("Consolas", 15);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(label18.Text, myfont, mybrush, 0, 0);
        }

        private void agregar_foto_cara_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                foto_rostro__img.ImageLocation = abrirImagen.FileName;
                foto_rostro__img.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void foto_firma_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirFirma = new OpenFileDialog();
            if (AbrirFirma.ShowDialog() == DialogResult.OK) ;
            {
                foto_firma__img.ImageLocation = AbrirFirma.FileName;
                foto_firma__img.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void foto_miniatura_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirMiniatura = new OpenFileDialog();
            if (AbrirMiniatura.ShowDialog() == DialogResult.OK) ;
            {
                foto_miniatura__img.ImageLocation = AbrirMiniatura.FileName;
                foto_miniatura__img.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
