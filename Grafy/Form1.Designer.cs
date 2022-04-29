
namespace Grafy
{
    partial class Form_main
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
            this.components = new System.ComponentModel.Container();
            this.picbx_grafy = new System.Windows.Forms.PictureBox();
            this.txtbx_debug = new System.Windows.Forms.TextBox();
            this.btn_addbod = new System.Windows.Forms.Button();
            this.btn_addhranu = new System.Windows.Forms.Button();
            this.btn_deletebod = new System.Windows.Forms.Button();
            this.btn_deletehranu = new System.Windows.Forms.Button();
            this.nup_start = new System.Windows.Forms.NumericUpDown();
            this.lbl_start = new System.Windows.Forms.Label();
            this.btn_visual = new System.Windows.Forms.Button();
            this.tim_viz = new System.Windows.Forms.Timer(this.components);
            this.startBSF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_grafy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_start)).BeginInit();
            this.SuspendLayout();
            // 
            // picbx_grafy
            // 
            this.picbx_grafy.Location = new System.Drawing.Point(12, 12);
            this.picbx_grafy.Name = "picbx_grafy";
            this.picbx_grafy.Size = new System.Drawing.Size(832, 602);
            this.picbx_grafy.TabIndex = 0;
            this.picbx_grafy.TabStop = false;
            this.picbx_grafy.Paint += new System.Windows.Forms.PaintEventHandler(this.Picbx_grafy_Paint);
            this.picbx_grafy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Picbx_grafy_MouseClick);
            // 
            // txtbx_debug
            // 
            this.txtbx_debug.Location = new System.Drawing.Point(850, 12);
            this.txtbx_debug.Multiline = true;
            this.txtbx_debug.Name = "txtbx_debug";
            this.txtbx_debug.Size = new System.Drawing.Size(229, 461);
            this.txtbx_debug.TabIndex = 1;
            // 
            // btn_addbod
            // 
            this.btn_addbod.Location = new System.Drawing.Point(923, 479);
            this.btn_addbod.Name = "btn_addbod";
            this.btn_addbod.Size = new System.Drawing.Size(75, 23);
            this.btn_addbod.TabIndex = 2;
            this.btn_addbod.Text = "Přidej bod";
            this.btn_addbod.UseVisualStyleBackColor = true;
            this.btn_addbod.Click += new System.EventHandler(this.Btn_addbod_Click);
            // 
            // btn_addhranu
            // 
            this.btn_addhranu.Location = new System.Drawing.Point(923, 508);
            this.btn_addhranu.Name = "btn_addhranu";
            this.btn_addhranu.Size = new System.Drawing.Size(75, 23);
            this.btn_addhranu.TabIndex = 3;
            this.btn_addhranu.Text = "Přidej Hranu";
            this.btn_addhranu.UseVisualStyleBackColor = true;
            this.btn_addhranu.Click += new System.EventHandler(this.Btn_addhranu_Click);
            // 
            // btn_deletebod
            // 
            this.btn_deletebod.Location = new System.Drawing.Point(1004, 477);
            this.btn_deletebod.Name = "btn_deletebod";
            this.btn_deletebod.Size = new System.Drawing.Size(75, 23);
            this.btn_deletebod.TabIndex = 4;
            this.btn_deletebod.Text = "Smaž bod";
            this.btn_deletebod.UseVisualStyleBackColor = true;
            this.btn_deletebod.Click += new System.EventHandler(this.Btn_deletebod_Click);
            // 
            // btn_deletehranu
            // 
            this.btn_deletehranu.Location = new System.Drawing.Point(1004, 506);
            this.btn_deletehranu.Name = "btn_deletehranu";
            this.btn_deletehranu.Size = new System.Drawing.Size(75, 23);
            this.btn_deletehranu.TabIndex = 5;
            this.btn_deletehranu.Text = "Smaž hranu";
            this.btn_deletehranu.UseVisualStyleBackColor = true;
            this.btn_deletehranu.Click += new System.EventHandler(this.Btn_deletehranu_Click);
            // 
            // nup_start
            // 
            this.nup_start.Location = new System.Drawing.Point(1004, 537);
            this.nup_start.Name = "nup_start";
            this.nup_start.Size = new System.Drawing.Size(75, 20);
            this.nup_start.TabIndex = 6;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(926, 539);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(72, 13);
            this.lbl_start.TabIndex = 8;
            this.lbl_start.Text = "Startovní bod";
            // 
            // btn_visual
            // 
            this.btn_visual.Location = new System.Drawing.Point(1004, 563);
            this.btn_visual.Name = "btn_visual";
            this.btn_visual.Size = new System.Drawing.Size(75, 25);
            this.btn_visual.TabIndex = 10;
            this.btn_visual.Text = "DFS";
            this.btn_visual.UseVisualStyleBackColor = true;
            this.btn_visual.Click += new System.EventHandler(this.StartDFS_Click);
            // 
            // tim_viz
            // 
            this.tim_viz.Interval = 1000;
            this.tim_viz.Tick += new System.EventHandler(this.Tim_viz_Tick);
            // 
            // startBSF
            // 
            this.startBSF.Location = new System.Drawing.Point(923, 565);
            this.startBSF.Name = "startBSF";
            this.startBSF.Size = new System.Drawing.Size(75, 23);
            this.startBSF.TabIndex = 11;
            this.startBSF.Text = "BFS";
            this.startBSF.UseVisualStyleBackColor = true;
            this.startBSF.Click += new System.EventHandler(this.StartBSF_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 638);
            this.Controls.Add(this.startBSF);
            this.Controls.Add(this.btn_visual);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.nup_start);
            this.Controls.Add(this.btn_deletehranu);
            this.Controls.Add(this.btn_deletebod);
            this.Controls.Add(this.btn_addhranu);
            this.Controls.Add(this.btn_addbod);
            this.Controls.Add(this.txtbx_debug);
            this.Controls.Add(this.picbx_grafy);
            this.Name = "Form_main";
            this.Text = "Grafy";
            ((System.ComponentModel.ISupportInitialize)(this.picbx_grafy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_start)).EndInit();
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
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Button btn_visual;
        private System.Windows.Forms.Timer tim_viz;
        private System.Windows.Forms.Button startBSF;
    }
}

