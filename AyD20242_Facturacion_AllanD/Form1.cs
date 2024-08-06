using System.Security.Cryptography.X509Certificates;

namespace AyD20242_Facturacion_AllanD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //acá escribimos el código para la funcionalidad de agregar un usuario

            //trabajo asincrónico semana 13 inicia acá. 

            //consideren que para obtener el valor de por ejemplo el nombre lo hacen de la siguiente 
            //forma 
            string n = TxtNombreCompleto.Text; //esto es solo ejemplo, deben borrar

            //paso 1 secuencia SQ Usuario Agregar
            //.... 


        }

        private void BtnConsultarCorreo_Click(object sender, EventArgs e)
        {
            //a partir de ese punto empezamos a explicar la secuencia:
            //SQ Consultar Usuario Por Correo

            //solo con fines didácticos voy a escribir la numeración de los pasos 
            //de la secuencia. En la práctica no es necesario hacerlo 

            //pasos 1.1 y 1.2 
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            //1.3 y 1.3.6
            bool Respuesta = MiUsuario.ConsultarPorCorreo();

            //1.4 
            if (Respuesta)
            {
                MessageBox.Show("El correo digitado existe", "Mensaje", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El correo digitado NO existe", "Mensaje", MessageBoxButtons.OK);
            }

        }

        
    }
}
