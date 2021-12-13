using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafy
{
    public partial class form_main : Form
    {
        private Graf Grafy = new Graf(5);
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
            if (mode=="addbod")
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
                if (bod!=-1)
                {
                    hrany = bod;
                    mode = "addhranu2";
                }
            }
            else if (mode == "addhranu2")
            {
                int bod2 = Vykresleni.Najdibod(e.X, e.Y);
                if (bod2 != -1)
                {
                    Vykresleni.AddHranu(hrany,bod2);
                    hrany = -1;
                    mode = "addhranu"; 
                }

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
    }
}
