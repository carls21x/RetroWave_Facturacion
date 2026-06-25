using RetroWave_Facturacion;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RetroWave_Facturacion
{
    public partial class FormRegister : Form
    {
        public FormRegister()

        {

            InitializeComponent();
        }
        private string connectionString = @"Data Source=CARLOS;Initial Catalog=DB_RetroWave;Integrated Security=True";

        private void FormRegister_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Enter += RemoveText;
                    txt.Leave += AddText;
                }
            }
        }

        private void RemoveText(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == txt.Tag.ToString())
            {
                txt.Text = "";
                txt.ForeColor = Color.White;

                if (txt == txtContrasena)
                    txt.UseSystemPasswordChar = true;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = txt.Tag.ToString();
                txt.ForeColor = Color.Gray;

                if (txt == txtContrasena)
                    txt.UseSystemPasswordChar = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos ni con el texto de placeholder (Tag)
            if (txtNombre.Text == txtNombre.Tag.ToString() || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                txtApellido.Text == txtApellido.Tag.ToString() || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                txtUsuario.Text == txtUsuario.Tag.ToString() || string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                txtContrasena.Text == txtContrasena.Tag.ToString() || string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                txtCedula.Text == txtCedula.Tag.ToString() || string.IsNullOrWhiteSpace(txtCedula.Text) ||
                txtCorreo.Text == txtCorreo.Tag.ToString() || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verificar si el usuario ya existe
                    string checkUserQuery = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario";
                    using (SqlCommand cmdCheck = new SqlCommand(checkUserQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                        int userExists = (int)cmdCheck.ExecuteScalar();
                        if (userExists > 0)
                        {
                            MessageBox.Show("El nombre de usuario ya está en uso. Elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insertar nuevo usuario
                    string insertQuery = @"
                INSERT INTO Usuarios (Nombres, Apellidos, Usuario, Clave, Cedula, Correo)
                VALUES (@nombres, @apellidos, @usuario, @clave, @cedula, @correo)";

                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@nombres", txtNombre.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@apellidos", txtApellido.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@clave", txtContrasena.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@cedula", txtCedula.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());

                        cmdInsert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario registrado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar este formulario y volver al login
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void linkVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void linkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
