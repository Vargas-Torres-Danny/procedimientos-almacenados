using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dannykig
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        static private string cadena = "Server=dataepis.uandina.pe,49157;Database=BDAcademicoVargas;Uid=vargasd;pwd=deathgun34.sql";
        static private SqlConnection conexion = new SqlConnection(cadena);

       
       
        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarAlumnos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvTAlumnos.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarTUsuario", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvTAlumnos.DataSource = tabla;
        }

        private void btnTDocente_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarTDocente", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvTAlumnos.DataSource = tabla;
        }

        private void btnTCarrera_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarTCarrera", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvTAlumnos.DataSource = tabla;
        }
    }
}
