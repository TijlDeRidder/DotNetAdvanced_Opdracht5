using System;
using System.Drawing;
using System.Windows.Forms;
namespace Oefening1
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void tsmi_BackColor_Red_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.BackColor = Color.Red;

        }

        private void tsmi_BackColor_Green_Click(object sender, EventArgs e)
        {
           rtb_TextVeld.BackColor = Color.Green;

        }

        private void tsmi_BackColor_Blue_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.BackColor = Color.Blue;
        }

        private void tsmi_Color_Red_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.ForeColor = Color.Red;
        }

        private void tsmi_Color_Green_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.ForeColor = Color.Green;

        }

        private void tsmi_Color_Blue_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.ForeColor = Color.Blue;
        }

        private void tsmi_Font_Small_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.Font = new Font(Menus.ActiveForm.Font.Name, 6);
        }

        private void tsmi_Font_Large_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.Font = new Font(Menus.ActiveForm.Font.Name, 14);
        }

        private void tsmi_Font_Normal_Click(object sender, EventArgs e)
        {
            rtb_TextVeld.Font = new Font(Menus.ActiveForm.Font.Name, 9);

        }

        private void exitToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Menus.ActiveForm.Close();
        }
    }
}
