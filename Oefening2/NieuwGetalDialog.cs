using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Oefening2
{
    public partial class NieuwGetalDialog : Form
    {
        public int Waarde { get; set; }
        public NieuwGetalDialog()
        {
            InitializeComponent();
            btn_ok.Text = "OK";
            btn_cancel.Text = "Cancel";
            btn_ok.DialogResult = DialogResult.OK;
            btn_cancel.DialogResult = DialogResult.Cancel;
            this.AcceptButton = btn_ok;
            this.CancelButton = btn_cancel;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Controls.Add(btn_ok);
            this.Controls.Add(btn_cancel);
            this.Controls.Add(tb_waarde);
            this.Text = "Nieuw Getal";
}

        private void NieuwGetalDialog_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Waarde = int.Parse(tb_waarde.Text);
            btn_ok.DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
