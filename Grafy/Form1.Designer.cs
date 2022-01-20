
namespace Grafy
{
    partial class form_main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.picbx_grafy = new System.Windows.Forms.PictureBox();
            this.txtbx_debug = new System.Windows.Forms.TextBox();
            this.btn_addbod = new System.Windows.Forms.Button();
            this.btn_addhranu = new System.Windows.Forms.Button();
            this.btn_deletebod = new System.Windows.Forms.Button();
            this.btn_deletehranu = new System.Windows.Forms.Button();
            this.nup_start = new System.Windows.Forms.NumericUpDown();
            this.nup_cil = new System.Windows.Forms.NumericUpDown();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_cil = new System.Windows.Forms.Label();
            this.btn_visual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_grafy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cil)).BeginInit();
            this.SuspendLayout();
            // 
            // picbx_grafy
            // 
            resources.ApplyResources(this.picbx_grafy, "picbx_grafy");
            this.picbx_grafy.Name = "picbx_grafy";
            this.picbx_grafy.TabStop = false;
            this.picbx_grafy.Paint += new System.Windows.Forms.PaintEventHandler(this.picbx_grafy_Paint);
            this.picbx_grafy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_grafy_MouseClick);
            // 
            // txtbx_debug
            // 
            resources.ApplyResources(this.txtbx_debug, "txtbx_debug");
            this.txtbx_debug.Name = "txtbx_debug";
            // 
            // btn_addbod
            // 
            resources.ApplyResources(this.btn_addbod, "btn_addbod");
            this.btn_addbod.Name = "btn_addbod";
            this.btn_addbod.UseVisualStyleBackColor = true;
            this.btn_addbod.Click += new System.EventHandler(this.btn_addbod_Click);
            // 
            // btn_addhranu
            // 
            resources.ApplyResources(this.btn_addhranu, "btn_addhranu");
            this.btn_addhranu.Name = "btn_addhranu";
            this.btn_addhranu.UseVisualStyleBackColor = true;
            this.btn_addhranu.Click += new System.EventHandler(this.btn_addhranu_Click);
            // 
            // btn_deletebod
            // 
            resources.ApplyResources(this.btn_deletebod, "btn_deletebod");
            this.btn_deletebod.Name = "btn_deletebod";
            this.btn_deletebod.UseVisualStyleBackColor = true;
            this.btn_deletebod.Click += new System.EventHandler(this.btn_deletebod_Click);
            // 
            // btn_deletehranu
            // 
            resources.ApplyResources(this.btn_deletehranu, "btn_deletehranu");
            this.btn_deletehranu.Name = "btn_deletehranu";
            this.btn_deletehranu.UseVisualStyleBackColor = true;
            this.btn_deletehranu.Click += new System.EventHandler(this.btn_deletehranu_Click);
            // 
            // nup_start
            // 
            resources.ApplyResources(this.nup_start, "nup_start");
            this.nup_start.Name = "nup_start";
            // 
            // nup_cil
            // 
            resources.ApplyResources(this.nup_cil, "nup_cil");
            this.nup_cil.Name = "nup_cil";
            // 
            // lbl_start
            // 
            resources.ApplyResources(this.lbl_start, "lbl_start");
            this.lbl_start.Name = "lbl_start";
            // 
            // lbl_cil
            // 
            resources.ApplyResources(this.lbl_cil, "lbl_cil");
            this.lbl_cil.Name = "lbl_cil";
            // 
            // btn_visual
            // 
            resources.ApplyResources(this.btn_visual, "btn_visual");
            this.btn_visual.Name = "btn_visual";
            this.btn_visual.UseVisualStyleBackColor = true;
            this.btn_visual.Click += new System.EventHandler(this.btn_visual_Click);
            // 
            // form_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_visual);
            this.Controls.Add(this.lbl_cil);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.nup_cil);
            this.Controls.Add(this.nup_start);
            this.Controls.Add(this.btn_deletehranu);
            this.Controls.Add(this.btn_deletebod);
            this.Controls.Add(this.btn_addhranu);
            this.Controls.Add(this.btn_addbod);
            this.Controls.Add(this.txtbx_debug);
            this.Controls.Add(this.picbx_grafy);
            this.Name = "form_main";
            ((System.ComponentModel.ISupportInitialize)(this.picbx_grafy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_grafy;
        private System.Windows.Forms.TextBox txtbx_debug;
        private System.Windows.Forms.Button btn_addbod;
        private System.Windows.Forms.Button btn_addhranu;
        private System.Windows.Forms.Button btn_deletebod;
        private System.Windows.Forms.Button btn_deletehranu;
        private System.Windows.Forms.NumericUpDown nup_start;
        private System.Windows.Forms.NumericUpDown nup_cil;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_cil;
        private System.Windows.Forms.Button btn_visual;
    }
}

