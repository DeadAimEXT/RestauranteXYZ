using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteXYZ.Formularios
{
    public partial class Orden : Form
    {

        CheckBox[] chkArray;
        NumericUpDown[] nudArray;

        public Orden()
        {
            InitializeComponent();
            chkArray = new CheckBox[] {chkSopaGallina, chkPapas, chkSopaTortilla, chkPollo, chkCarne, chkLomo, chkHamburguesa, chkTocino, chkPupusas, chkGaseosas,
                                       chkBatido, chkAgua, chkCafe, chkTe, chkBrownie, chkTorta};
            nudArray = new NumericUpDown[] {nudSopaGallina, nudPapas, nudSopaTortilla, nudPollo, nudCarne, nudLomo, nudHamburguesa, nudTocino, nudPupusas, nudGaseosas,
                                            nudBatido, nudAgua, nudCafe, nudTe, nudBrownie, nudTorta};
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void chkSopaGallina_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkPapas_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkSopaTortilla_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkPollo_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkCarne_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkLomo_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkHamburguesa_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkTocino_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkPupusas_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkGaseosas_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkBatido_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkAgua_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkCafe_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkTe_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkBrownie_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void chkTorta_CheckedChanged(object sender, EventArgs e)
        {
            validarNuds();
        }

        private void validarNuds()
        {
            for (int i = 0; i < 16; i++)
            {
                if (chkArray[i].Checked)
                {
                    nudArray[i].Enabled = true;
                }
                else
                {
                    nudArray[i].Enabled = false;
                }
            }
        }
    }
}
