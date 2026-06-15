using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FiltroSuavizado
{
    public partial class Form1 : Form
    {
        // Reemplaza esto con tu cadena de conexión real de SQL Server
        private string connectionString = @"Server=laptop-m1nfrjkl\sqlexpress;Database=ProcesamientoImagenesDB;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Cargar la imagen desde la PC
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxOriginal.Image = new Bitmap(ofd.FileName);
            }
        }

        // 2. Lógica matemática del Filtro de Promedio 3x3
        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image == null)
            {
                MessageBox.Show("Por favor, carga una imagen primero.");
                return;
            }

            Bitmap imagenOriginal = (Bitmap)pictureBoxOriginal.Image;
            // Clonamos la imagen para mantener los bordes originales
            Bitmap imagenFiltrada = new Bitmap(imagenOriginal);

            // Recorremos la imagen omitiendo el borde de 1 píxel (para que la ventana 3x3 no se salga de los límites)
            for (int x = 1; x < imagenOriginal.Width - 1; x++)
            {
                for (int y = 1; y < imagenOriginal.Height - 1; y++)
                {
                    int sumaR = 0, sumaG = 0, sumaB = 0;

                    // Recorremos la ventana de 3x3 alrededor del píxel central (x, y)
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = imagenOriginal.GetPixel(x + i, y + j);
                            sumaR += pixel.R;
                            sumaG += pixel.G;
                            sumaB += pixel.B;
                        }
                    }

                    // Calculamos el promedio dividiendo entre 9 (el total de píxeles en la ventana)
                    int promR = sumaR / 9;
                    int promG = sumaG / 9;
                    int promB = sumaB / 9;

                    // Asignamos el nuevo color promediado al píxel en la imagen resultante
                    imagenFiltrada.SetPixel(x, y, Color.FromArgb(promR, promG, promB));
                }
            }

            pictureBoxFiltrada.Image = imagenFiltrada;
            MessageBox.Show("¡Filtro de suavizado aplicado con éxito!");
        }

        // 3. Guardar la imagen en el SGBD
        private void btnGuardarBD_Click(object sender, EventArgs e)
        {
            if (pictureBoxFiltrada.Image == null)
            {
                MessageBox.Show("No hay imagen filtrada para guardar.");
                return;
            }

            try
            {
                // Convertir la imagen a un arreglo de bytes
                byte[] imagenBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxFiltrada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }

                // Insertar en la base de datos usando parámetros
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ImagenesFiltradas (Nombre, Imagen) VALUES (@Nombre, @Imagen)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", "ImagenSuavizada_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                        cmd.Parameters.AddWithValue("@Imagen", imagenBytes);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Imagen guardada en el SGBD correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
        }
    }
}