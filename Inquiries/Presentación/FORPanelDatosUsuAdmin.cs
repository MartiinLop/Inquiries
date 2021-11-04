using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inquiries.Properties;

namespace TemplateParteAdmin
{
    public partial class FORPanelDatosUsuAdmin : Form
    {
        public FORPanelDatosUsuAdmin(string na, string grup, string tipo)
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            labelNA.Text = na;
            labelG.Text = grup;
            labelTipo.Text = tipo;
            pictureBox1.Image = Resources.imgPerf;
        }
    }
}
    