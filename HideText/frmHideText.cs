using System;
using System.Windows.Forms;

namespace HideText
{
    public partial class frmHideText : Form
    {
        public frmHideText()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            // Nascondi
            Nascondi nascondi = new Nascondi(tbxOriginale.Text, tbxSegreto.Text);
            string check = nascondi.Check();
            if (check == "Ok")
            {
                tbxRisultato.Text = nascondi.Calcola();
                Clipboard.SetText(tbxRisultato.Text);
                tbxEstraiRisultato.Text = tbxRisultato.Text;
                MessageBox.Show("Hidden text copied to clipboard", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(check, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            // Estrai
            Nascondi nascondi = new Nascondi(tbxEstraiRisultato.Text);
            (tbxEstraiOriginale.Text, tbxEstraiSegreto.Text) = nascondi.Estrai();
            MessageBox.Show("Secret text extracted", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
