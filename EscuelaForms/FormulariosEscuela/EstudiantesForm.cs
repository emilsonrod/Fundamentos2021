using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaForms.FormulariosEscuela
{
    public partial class EstudiantesForm : Form
    {
        public string TextoMostrar { get; set; }

        public EstudiantesForm(string textoMostrar)
        {
            InitializeComponent();
            this.label1.Text = textoMostrar;
        }
    }
}
