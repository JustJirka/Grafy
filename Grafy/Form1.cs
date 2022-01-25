using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Grafy
{
    public partial class Form_main : Form
    {
        private Vykreslovani Vykresleni = new Vykreslovani();
        string mode = "";
        int hrany;
        public Form_main()
        {
            InitializeComponent();
        }

        private void Btn_addbod_Click(object sender, EventArgs e)
        {
            mode = "addbod";
        }

        private void Btn_deletebod_Click(object sender, EventArgs e)
        {
            mode = "removebod";
        }

        private void Picbx_grafy_MouseClick(object sender, MouseEventArgs e)
        {
            if (mode == "addbod") Vykresleni.AddBod(e.X, e.Y);
            else if (mode == "removebod") Vykresleni.RmBod(e.X, e.Y);
            else if (mode == "removehranu") Vykresleni.RmHranu(e.X, e.Y);
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
            picbx_grafy.Refresh();
        }

        private void Picbx_grafy_Paint(object sender, PaintEventArgs e)
        {
            nup_cil.Maximum = nup_start.Maximum = Vykresleni.Vykresli(e.Graphics);
        }

        private void Btn_addhranu_Click(object sender, EventArgs e)
        {
            mode = "addhranu";
        }

        private void Btn_deletehranu_Click(object sender, EventArgs e)
        {
            mode = "removehranu";
        }

        private void Btn_visual_Click(object sender, EventArgs e)
        {
            List<int[]> vypis = Vykresleni.StartDFS(Convert.ToInt32(nup_start.Value), Convert.ToInt32(nup_cil.Value));
            for (int i = 0; i < vypis.Count; i++) txtbx_debug.Text += vypis[i][0] + " => " + vypis[i][1] + ", ";
            tim_viz.Start();
        }

        private void Tim_viz_Tick(object sender, EventArgs e)
        {
            if (Vykresleni.Vizualiz()) tim_viz.Stop();
            picbx_grafy.Refresh();
        }
    }
}