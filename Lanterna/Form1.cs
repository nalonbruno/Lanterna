using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lanterna.Model;

namespace Lanterna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            lblStatus.Text = Program.MLanterna.Status.ToString();

            lblBateria.Text = Program.MLanterna.Bateria.Carga.ToString() + " %";
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            Program.MLanterna.LigaDesliga();

            lblStatus.Text = Program.MLanterna.Status.ToString();

            lblBateria.Text = Program.MLanterna.Bateria.Carga.ToString() + " %";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.MLanterna.Status == true)
            {
                if (Program.MLanterna.Bateria.Carga > 0)
                {
                    Program.MLanterna.Bateria.Carga -= 1;
                }
                if (Program.MLanterna.Bateria.Carga == 0)
                {
                    Program.MLanterna.LigaDesliga();
                }

            }
            lblStatus.Text = Program.MLanterna.Status.ToString();

            lblBateria.Text = Program.MLanterna.Bateria.Carga.ToString() + " %";
        }

        private void btnTrocarBateria_Click(object sender, EventArgs e)
        {
            Program.MLanterna.TrocarBateria();

            lblStatus.Text = Program.MLanterna.Status.ToString();

            lblBateria.Text = Program.MLanterna.Bateria.Carga.ToString() + " %";

        }
    }
}
