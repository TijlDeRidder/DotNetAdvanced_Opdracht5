using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class GemiddeldeMDI : Form
    {
        public GemiddeldeMDI()
        {
            InitializeComponent();
            
        }

        private void GemiddeldeMDI_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_number_Click(object sender, EventArgs e)
        {
            using (NieuwGetalDialog dialog = new NieuwGetalDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    int waarde = dialog.Waarde;
                    listBox1.Items.Add(waarde);
                }
                TbGemiddeldeUpdate();
            }
        }

        private void TbGemiddeldeUpdate()
        {
            int totaal = 0;
            foreach(int listBoxItem in listBox1.Items)
            {
                totaal += listBoxItem;
            }
            tb_gemiddelde.Text = (totaal / listBox1.Items.Count).ToString();
        }
    }
}
