namespace WinRE_Settings_GUI
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.enable = new ReaLTaiizor.Controls.Button();
            this.disable = new ReaLTaiizor.Controls.Button();
            this.repair = new ReaLTaiizor.Controls.Button();
            this.SuspendLayout();
            // 
            // enable
            // 
            this.enable.BackColor = System.Drawing.Color.Transparent;
            this.enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enable.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.enable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable.Image = null;
            this.enable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enable.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.enable.Location = new System.Drawing.Point(3, 0);
            this.enable.Name = "enable";
            this.enable.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.enable.Size = new System.Drawing.Size(121, 42);
            this.enable.TabIndex = 0;
            this.enable.Text = "Enable";
            this.enable.TextAlignment = System.Drawing.StringAlignment.Center;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // disable
            // 
            this.disable.BackColor = System.Drawing.Color.Transparent;
            this.disable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disable.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.disable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disable.Image = null;
            this.disable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disable.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.disable.Location = new System.Drawing.Point(129, 0);
            this.disable.Name = "disable";
            this.disable.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.disable.Size = new System.Drawing.Size(121, 42);
            this.disable.TabIndex = 1;
            this.disable.Text = "Disable";
            this.disable.TextAlignment = System.Drawing.StringAlignment.Center;
            this.disable.Click += new System.EventHandler(this.disable_Click);
            // 
            // repair
            // 
            this.repair.BackColor = System.Drawing.Color.Transparent;
            this.repair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repair.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.repair.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repair.Image = null;
            this.repair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.repair.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.repair.Location = new System.Drawing.Point(255, 0);
            this.repair.Name = "repair";
            this.repair.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.repair.Size = new System.Drawing.Size(121, 42);
            this.repair.TabIndex = 2;
            this.repair.Text = "Repair";
            this.repair.TextAlignment = System.Drawing.StringAlignment.Center;
            this.repair.Click += new System.EventHandler(this.repair_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 45);
            this.Controls.Add(this.repair);
            this.Controls.Add(this.disable);
            this.Controls.Add(this.enable);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "WinRE Settings GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Button enable;
        private ReaLTaiizor.Controls.Button disable;
        private ReaLTaiizor.Controls.Button repair;
    }
}

