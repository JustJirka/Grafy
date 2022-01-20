using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Grafy
{
    public partial class form_main : Form
    {
        private Vykreslovani Vykresleni = new Vykreslovani();
        string mode = "";
        int hrany;
        public form_main()
        {
            InitializeComponent();
        }

        private void btn_addbod_Click(object sender, EventArgs e)
        {
            mode = "addbod";
        }

        private void btn_deletebod_Click(object sender, EventArgs e)
        {
            mode = "removebod";
        }

        private void picbx_grafy_MouseClick(object sender, MouseEventArgs e)
        {
            if (mode == "addbod")
            {
                Vykresleni.AddBod(e.X, e.Y);
            }
            else if (mode == "removebod")
            {
                Vykresleni.RmBod(e.X, e.Y);
            }
            else if (mode == "addhranu")
            {
                int bod = Vykresleni.Najdibod(e.X, e.Y);
                if (bod != -1)
                {
                    hrany = bod;
                    mode = "addhranu2";
                }
            }
            else if (mode == "addhranu2")
            {
                int bod2 = Vykresleni.Najdibod(e.X, e.Y);
                if (bod2 != -1 && hrany != bod2)
                {
                    Vykresleni.AddHranu(hrany, bod2);
                    hrany = -1;
                    mode = "addhranu";
                }

            }
            else if (mode == "removehranu")
            {
                Vykresleni.RmHranu(e.X, e.Y);
            }
            picbx_grafy.Refresh();
        }

        private void picbx_grafy_Paint(object sender, PaintEventArgs e)
        {
            Vykresleni.Vykresli(e.Graphics);
        }

        private void btn_addhranu_Click(object sender, EventArgs e)
        {
            mode = "addhranu";
        }

        private void btn_deletehranu_Click(object sender, EventArgs e)
        {
            mode = "removehranu";
        }

        private void btn_visual_Click(object sender, EventArgs e)
        {
            List<int> vypis = Vykresleni.startDFS( Convert.ToInt32(nup_start.Value),Convert.ToInt32(nup_cil.Value));
            for (int i = 0; i < vypis.Count; i++)
            {
                txtbx_debug.Text += vypis[i] + " => ";
            }
        }
    }
}
