using System;
using System.Windows.Forms;
using Common;
using Common.BLL;
using Common.OBJ;
using Ciencia;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MDI
{
    public partial class frmLogOn : Form
    {
        private clsUsuario _usuario;
        private String _modo = "Ingresar";

        public clsUsuario Usuario
        {
            get { return _usuario ?? (_usuario = new clsUsuario()); }
            set
            {
                _usuario = value;
            }

        }

        public Boolean validado { get; set; }
        public frmLogOn()
        {
            InitializeComponent();
            validado = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Usuario.User_LogOn = this.txtLogOn.Text;
            this.Usuario.User_Pasw = this.txtPassw.Text;
            if (!this.Logon_new(this.Usuario.User_LogOn, this.Usuario.User_Pasw))
            {
                int num = (int)MessageBox.Show("Usuario y/o Contraseña erronea. Vuelva a intentarlo", "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtLogOn.Text = "";
                this.txtPassw.Text = "";
                this.txtLogOn.Focus();
            }
            else
            {
                this.PermitirAcceso();
                this.Close();
            }
        }

        /*
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario.User_LogOn = txtLogOn.Text;
            Usuario.User_Pasw = txtPassw.Text;
            Usuario.User_Pasw_F = DateTime.Today;
            Common.BLL.UsuarioBuss obj = new UsuarioBuss();
            if (_modo == "Ingresar")
            {
                if ((Usuario = obj.ValidarUsuario(Usuario)) != null)
                {
                    PermitirAcceso();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña erronea. Vuelva a intentarlo", "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLogOn.Text = "";
                    txtPassw.Text = "";
                    txtLogOn.Focus();
                }
            }
            else if (_modo == "Nuevo")
            {
                if(txtPassw.Text != txtConfCont.Text)
                {
                    MessageBox.Show("La contraseña no coincide", "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                try
                {
                    if (obj.NuevoUsuario(Usuario) == true)
                    {
                        MessageBox.Show("Usuario ingresado con éxito", "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoIngresar();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ya existe en el sistema", "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (UserException ex )
                {
                    MessageBox.Show(ex.Message, "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_modo == "Modificar")
            {
                if ((Usuario = obj.ValidarUsuario(Usuario)) == null)
                {
                    MessageBox.Show("Usuario y/o Contraseña erronea. Vuelva a intetarlo", "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLogOn.Text = "";
                    txtPassw.Text = "";
                    txtLogOn.Focus();
                    return;
                }

                ModificarUsuario(obj);
            }
        }*/

        public bool Logon_new(string user, string password)
        {
            object obj = new
            {
                EmpresaC = 1,
                inApiKey = "gfZmfdGo0PmFw2eD64CMaygBktrQrl6sZ0tHN9R4dPNP5SG77xFoAsCRqNzMXX2H",
                SUUsuario = user,
                SUClave = password,
                CaseSensitive = true
                //ValidarRol= 3
            };


            ByteArrayContent byteArrayContent = new ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(obj)));
            HttpClient httpClient = new HttpClient();
            string URL = "https://servicios.icba.com.ar/HCE_WS/rest/ValidarUsuarioREST";

            httpClient.BaseAddress = new Uri(URL);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage result = HttpClientExtensions.PostAsJsonAsync<object>(httpClient, "", obj).Result;
            bool flag;
            //            var response = (await client.PostAsync(URL, content));
            //var result= response.Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (result.IsSuccessStatusCode)
            {
                if (((Task<frmLogOn.RespuestaLogin>)HttpContentExtensions.ReadAsAsync<frmLogOn.RespuestaLogin>(result.Content)).Result.ErrorCod == 0)
                {
                    flag = true;
                    clsUsuario clsUsuario = new clsUsuario();
                }
                else
                    flag = false;
            }
            else
                flag = false;
            httpClient.Dispose();
            return flag;
        }


        void ModificarUsuario(UsuarioBuss obj)
        {
            if (this.txtNvaCont.Text != txtConfCont.Text)
            {
                MessageBox.Show("La contraseña no coincide", "Modificar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                Usuario.User_Pasw = txtNvaCont.Text;
                if (obj.ModificarContraseña(Usuario) == true)
                {
                    MessageBox.Show("Contraseña modificada con éxito", "Modificar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PermitirAcceso();
                }
                else
                {
                    MessageBox.Show("Usuario no existe en el sistema", "Modificar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Modificar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ModoIngresar()
        {
            txtLogOn.Text = "";
            txtPassw.Text = "";
            lblTitulo.Text = "Ingrese Usuario y Contraseña";
            _modo = "Ingresar";
            lbNvaCont.Visible = false;
            txtConfCont.Visible = false;
        }

        void PermitirAcceso()
        {
            Ambiente.Usuario = Usuario;
            Ambiente.Maquina = Environment.MachineName;
            DialogResult = DialogResult.OK;
            var segB = new Common.BLL.PermisosBuss();
            //Seguridad.Permisos = segB.ObetnerPermisosPorUsuario(Usuario);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            validado = false;
            Close();
        }

        private void lblNuevoUsuario_Click(object sender, EventArgs e)
        {
            ModoNuevoUsuario();
        }

        void ModoNuevoUsuario()
        {
            txtLogOn.Text = "";
            txtPassw.Text = "";
            lblTitulo.Text = "Ingrese Nuevo Usuario";
            _modo = "Nuevo"; ;
            lbNvaCont.Visible = true;
            txtConfCont.Visible = true;
        }

        private void frmLogOn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ModoCambiarContraseña();
        }
        void ModoCambiarContraseña()
        {
            lblCambiarCont.Visible = false;
            lblTitulo.Text = "Cambiar Contraseña";
            lblCont.Text = "Contraseña actual:";
            lblCont.Left = lblCont.Left - 40;
            _modo = "Modificar";
            txtNvaCont.Visible = true;
            lbNvaCont.Visible = true;
            lblConfCont.Visible = true;
            txtConfCont.Visible = true;
            Height = Height + 20;
        }

        private void lblConfCont_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public class RespuestaLogin
        {
            public int ErrorCod { get; set; }

            public string ErrorDsc { get; set; }
        }
    }
}
