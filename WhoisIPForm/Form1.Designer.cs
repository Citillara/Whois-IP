namespace WhoisIPForm
{
    partial class Form1
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRIPE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxARIN = new System.Windows.Forms.TextBox();
            this.textBoxAPNIC = new System.Windows.Forms.TextBox();
            this.textBoxLACNIC = new System.Windows.Forms.TextBox();
            this.textBoxAfriNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(13, 13);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(103, 20);
            this.textBoxIP.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(122, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRIPE
            // 
            this.textBoxRIPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRIPE.Location = new System.Drawing.Point(13, 52);
            this.textBoxRIPE.Multiline = true;
            this.textBoxRIPE.Name = "textBoxRIPE";
            this.textBoxRIPE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRIPE.Size = new System.Drawing.Size(323, 561);
            this.textBoxRIPE.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RIPE";
            // 
            // textBoxARIN
            // 
            this.textBoxARIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxARIN.Location = new System.Drawing.Point(342, 52);
            this.textBoxARIN.Multiline = true;
            this.textBoxARIN.Name = "textBoxARIN";
            this.textBoxARIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxARIN.Size = new System.Drawing.Size(323, 561);
            this.textBoxARIN.TabIndex = 4;
            // 
            // textBoxAPNIC
            // 
            this.textBoxAPNIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAPNIC.Location = new System.Drawing.Point(671, 52);
            this.textBoxAPNIC.Multiline = true;
            this.textBoxAPNIC.Name = "textBoxAPNIC";
            this.textBoxAPNIC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAPNIC.Size = new System.Drawing.Size(323, 561);
            this.textBoxAPNIC.TabIndex = 5;
            // 
            // textBoxLACNIC
            // 
            this.textBoxLACNIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLACNIC.Location = new System.Drawing.Point(1000, 52);
            this.textBoxLACNIC.Multiline = true;
            this.textBoxLACNIC.Name = "textBoxLACNIC";
            this.textBoxLACNIC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLACNIC.Size = new System.Drawing.Size(323, 561);
            this.textBoxLACNIC.TabIndex = 6;
            // 
            // textBoxAfriNIC
            // 
            this.textBoxAfriNIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAfriNIC.Location = new System.Drawing.Point(1329, 52);
            this.textBoxAfriNIC.Multiline = true;
            this.textBoxAfriNIC.Name = "textBoxAfriNIC";
            this.textBoxAfriNIC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAfriNIC.Size = new System.Drawing.Size(323, 561);
            this.textBoxAfriNIC.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ARIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "APNIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(997, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "LACNIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1329, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AfriNIC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 625);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAfriNIC);
            this.Controls.Add(this.textBoxLACNIC);
            this.Controls.Add(this.textBoxAPNIC);
            this.Controls.Add(this.textBoxARIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRIPE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIP);
            this.Name = "Form1";
            this.Text = "Whois IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRIPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxARIN;
        private System.Windows.Forms.TextBox textBoxAPNIC;
        private System.Windows.Forms.TextBox textBoxLACNIC;
        private System.Windows.Forms.TextBox textBoxAfriNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

