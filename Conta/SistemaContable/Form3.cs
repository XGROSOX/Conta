using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_Tool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string rutaArchivo = "C:\\plan_addr.txt";
        public static string addr = "";
        public static string rutaArchivo2;
        public static string contenido;
        private void Form3_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(stream);
            addr = reader.ReadLine();
            if (addr != null)
            {
                rutaArchivo2 = addr;
                //MessageBox.Show(addr); //Mostrar dirección de plan de cuentas guardada
                reader.Close();
                try
                {
                    contenido = System.IO.File.ReadAllText(rutaArchivo2);
                    tbox_plan_cuentas.Text = contenido; // txtContenido es un TextBox en el formulario
                }
                catch
                {
                    MessageBox.Show("El plan de cuentas establecido fue movido o ya no existe.");
                    cargar_ruta_plan();
                    tbox_plan_cuentas.Text = contenido; // txtContenido es un TextBox en el formulario
                }
            }
            if (addr == null)
            {
                reader.Close();
                cargar_ruta_plan();
                tbox_plan_cuentas.Text = contenido; // txtContenido es un TextBox en el formulario
            }
        }

        private static void cargar_ruta_plan()
        {
            // Crear una nueva instancia del diálogo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar propiedades del diálogo
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"; // Filtro para mostrar solo archivos de texto
            openFileDialog.Title = "Seleccionar archivo de texto";

            // Mostrar el diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                rutaArchivo2 = openFileDialog.FileName;
                FileStream stream2 = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream2);
                writer.WriteLine(rutaArchivo2);
                writer.Close();
                // Leer el contenido del archivo (opcional)
                contenido = System.IO.File.ReadAllText(rutaArchivo2);
            }
        }

        private void btn_cargar_plan_Click(object sender, EventArgs e)
        {
            cargar_ruta_plan();
            tbox_plan_cuentas.Text = contenido; // txtContenido es un TextBox en el formulario
        }

        private void tbox_plan_cuentas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
