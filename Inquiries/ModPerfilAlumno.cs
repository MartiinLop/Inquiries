using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquiries
{
    public partial class ModPerfilAlumno : Form
    {
        public ModPerfilAlumno()
        {
            InitializeComponent();
            panel7.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            btnEliminadoAl.Hide();
            string sdatos;
            sdatos = Persona.Mdatos();
            String[] resultado = sdatos.Split('|');
            txtNombre.Text = resultado[0];
            txtApodo.Text = resultado[1];
            txtContra.Text = resultado[2];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardarAl_Click(object sender, EventArgs e)
        {
            Alumno m = new Alumno();
            m.ModPerfAl(txtNombre.Text, txtApodo.Text, txtContra.Text);
        }


        private void panel4_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            label6.Show();
        }
        
        private void panel5_Click(object sender, EventArgs e)
        {
            txtApodo.ReadOnly = false;
            label7.Show();
        }
        
        private void panel6_Click(object sender, EventArgs e)
        {
            txtContra.ReadOnly = false;
            label8.Show();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //public static Boolean Insedoc(int dCI, string dCon)
            //{

            //    MySqlConnection conectar0 = new MySqlConnection(conexbd);
            //    conectar0.Open();
            //    Boolean comp = false;
            //    string check = "select destado from docente where dci = " + obtCI + ";";
            //    MySqlCommand chequear = new MySqlCommand(string.Format(check), conectar0);
            //    MySqlDataReader revisar = chequear.ExecuteReader();

            //    if (revisar.Read())
            //    {
            //        comp = revisar.GetBoolean("destado");
            //    }


            //    if (comp == true)
            //    {
            //        MySqlConnection conectar = new MySqlConnection(conexbd);
            //        conectar.Open();
            //        MySqlDataReader com;
            //        int op;
            //        int vCI;
            //        String vCon;
            //        string a = "select dci,dcon from docente";
            //        MySqlCommand seleccionar = new MySqlCommand(string.Format(a), conectar);

            //        com = seleccionar.ExecuteReader();

            //        while (com.Read())
            //        {
            //            vCI = com.GetInt32("dci");
            //            vCon = com.GetString("dcon");
            //            if (vCI == dCI && vCon == dCon)
            //            {
            //                op = 1;
            //                obtCI = vCI;
            //            }
            //            else
            //            {
            //                op = 0;
            //            }

            //            if (op == 1)
            //            {
            //                op = 0;
            //                MySqlConnection conectar2 = new MySqlConnection(conexbd);
            //                conectar2.Open();
            //                MySqlCommand conex = new MySqlCommand("update docente set dconexion = true where dci =" + obtCI + ";", conectar2);
            //                conex.ExecuteNonQuery();
            //                conectar.Close();
            //                conectar2.Close();
            //                return true;
            //            }
            //        }
            //        conectar.Close();
            //        return false;
            //    }
            //    conectar0.Close();
            //    return false;

            //}
        }

        private void ModPerfilAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarAl_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Alumno.ElAl();
            MessageBox.Show("Se ha eliminado su usuario correctamente!", "Eliminación usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnEliminadoAl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel7.Hide();
        }
    }
}
