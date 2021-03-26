namespace FrostyFix
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_enable = new System.Windows.Forms.Button();
            this.btn_disable = new System.Windows.Forms.Button();
            this.rbtn_bf2015 = new System.Windows.Forms.RadioButton();
            this.rbtn_bf2017 = new System.Windows.Forms.RadioButton();
            this.rbtn_mea = new System.Windows.Forms.RadioButton();
            this.rbtn_custom = new System.Windows.Forms.RadioButton();
            this.txtb_custompath = new System.Windows.Forms.TextBox();
            this.btn_customchoose = new System.Windows.Forms.Button();
            this.lbl_enabled = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.rbtn_bf1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_github = new System.Windows.Forms.Button();
            this.rbtn_nfs = new System.Windows.Forms.RadioButton();
            this.rbtn_nfsheat = new System.Windows.Forms.RadioButton();
            this.rbtn_gw2 = new System.Windows.Forms.RadioButton();
            this.rbtn_nfspayback = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_title.Location = new System.Drawing.Point(334, 3);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(181, 69);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "FrostyFix";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_enable
            // 
            this.btn_enable.Enabled = false;
            this.btn_enable.Location = new System.Drawing.Point(326, 332);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(149, 68);
            this.btn_enable.TabIndex = 1;
            this.btn_enable.Text = "Enable Mods";
            this.btn_enable.UseVisualStyleBackColor = true;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.Location = new System.Drawing.Point(326, 401);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(149, 23);
            this.btn_disable.TabIndex = 2;
            this.btn_disable.Text = "Disable Mods";
            this.btn_disable.UseVisualStyleBackColor = true;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // rbtn_bf2015
            // 
            this.rbtn_bf2015.AutoSize = true;
            this.rbtn_bf2015.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_bf2015.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_bf2015.Location = new System.Drawing.Point(60, 94);
            this.rbtn_bf2015.Name = "rbtn_bf2015";
            this.rbtn_bf2015.Size = new System.Drawing.Size(186, 20);
            this.rbtn_bf2015.TabIndex = 3;
            this.rbtn_bf2015.TabStop = true;
            this.rbtn_bf2015.Text = "Star Wars Battlefront (2015)";
            this.rbtn_bf2015.UseVisualStyleBackColor = true;
            this.rbtn_bf2015.CheckedChanged += new System.EventHandler(this.rbtn_bf2015_CheckedChanged);
            // 
            // rbtn_bf2017
            // 
            this.rbtn_bf2017.AutoSize = true;
            this.rbtn_bf2017.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_bf2017.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_bf2017.Location = new System.Drawing.Point(60, 121);
            this.rbtn_bf2017.Name = "rbtn_bf2017";
            this.rbtn_bf2017.Size = new System.Drawing.Size(195, 20);
            this.rbtn_bf2017.TabIndex = 4;
            this.rbtn_bf2017.TabStop = true;
            this.rbtn_bf2017.Text = "Star Wars Battlefront II (2017)";
            this.rbtn_bf2017.UseVisualStyleBackColor = true;
            this.rbtn_bf2017.CheckedChanged += new System.EventHandler(this.rbtn_bf2017_CheckedChanged);
            // 
            // rbtn_mea
            // 
            this.rbtn_mea.AutoSize = true;
            this.rbtn_mea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_mea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_mea.Location = new System.Drawing.Point(565, 94);
            this.rbtn_mea.Name = "rbtn_mea";
            this.rbtn_mea.Size = new System.Drawing.Size(169, 20);
            this.rbtn_mea.TabIndex = 5;
            this.rbtn_mea.TabStop = true;
            this.rbtn_mea.Text = "Mass Effect Andromeda";
            this.rbtn_mea.UseVisualStyleBackColor = true;
            this.rbtn_mea.CheckedChanged += new System.EventHandler(this.rbtn_mea_CheckedChanged);
            // 
            // rbtn_custom
            // 
            this.rbtn_custom.AutoSize = true;
            this.rbtn_custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_custom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_custom.Location = new System.Drawing.Point(60, 255);
            this.rbtn_custom.Name = "rbtn_custom";
            this.rbtn_custom.Size = new System.Drawing.Size(71, 20);
            this.rbtn_custom.TabIndex = 7;
            this.rbtn_custom.TabStop = true;
            this.rbtn_custom.Text = "Custom";
            this.rbtn_custom.UseVisualStyleBackColor = true;
            // 
            // txtb_custompath
            // 
            this.txtb_custompath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtb_custompath.Enabled = false;
            this.txtb_custompath.Location = new System.Drawing.Point(60, 279);
            this.txtb_custompath.Name = "txtb_custompath";
            this.txtb_custompath.ReadOnly = true;
            this.txtb_custompath.Size = new System.Drawing.Size(600, 20);
            this.txtb_custompath.TabIndex = 10;
            // 
            // btn_customchoose
            // 
            this.btn_customchoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customchoose.Location = new System.Drawing.Point(666, 278);
            this.btn_customchoose.Name = "btn_customchoose";
            this.btn_customchoose.Size = new System.Drawing.Size(75, 21);
            this.btn_customchoose.TabIndex = 11;
            this.btn_customchoose.Text = "Choose...";
            this.btn_customchoose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_customchoose.UseVisualStyleBackColor = true;
            this.btn_customchoose.Click += new System.EventHandler(this.btn_customchoose_Click);
            // 
            // lbl_enabled
            // 
            this.lbl_enabled.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_enabled.Location = new System.Drawing.Point(150, 316);
            this.lbl_enabled.Name = "lbl_enabled";
            this.lbl_enabled.Size = new System.Drawing.Size(500, 13);
            this.lbl_enabled.TabIndex = 12;
            this.lbl_enabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(713, 12);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(75, 23);
            this.btn_info.TabIndex = 13;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // rbtn_bf1
            // 
            this.rbtn_bf1.AutoSize = true;
            this.rbtn_bf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_bf1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_bf1.Location = new System.Drawing.Point(60, 147);
            this.rbtn_bf1.Name = "rbtn_bf1";
            this.rbtn_bf1.Size = new System.Drawing.Size(113, 20);
            this.rbtn_bf1.TabIndex = 14;
            this.rbtn_bf1.TabStop = true;
            this.rbtn_bf1.Text = "Battlefield One";
            this.rbtn_bf1.UseVisualStyleBackColor = true;
            this.rbtn_bf1.CheckedChanged += new System.EventHandler(this.rbtn_bf1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::FrostyFix.Properties.Resources.FrostyFixNBSm;
            this.pictureBox1.Location = new System.Drawing.Point(286, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_github
            // 
            this.btn_github.Location = new System.Drawing.Point(632, 12);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(75, 23);
            this.btn_github.TabIndex = 16;
            this.btn_github.Text = "GitHub";
            this.btn_github.UseVisualStyleBackColor = true;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // rbtn_nfs
            // 
            this.rbtn_nfs.AutoSize = true;
            this.rbtn_nfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_nfs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_nfs.Location = new System.Drawing.Point(326, 94);
            this.rbtn_nfs.Name = "rbtn_nfs";
            this.rbtn_nfs.Size = new System.Drawing.Size(122, 20);
            this.rbtn_nfs.TabIndex = 17;
            this.rbtn_nfs.TabStop = true;
            this.rbtn_nfs.Text = "Need for Speed";
            this.rbtn_nfs.UseVisualStyleBackColor = true;
            this.rbtn_nfs.CheckedChanged += new System.EventHandler(this.rbtn_nfs_CheckedChanged);
            // 
            // rbtn_nfsheat
            // 
            this.rbtn_nfsheat.AutoSize = true;
            this.rbtn_nfsheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_nfsheat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_nfsheat.Location = new System.Drawing.Point(326, 147);
            this.rbtn_nfsheat.Name = "rbtn_nfsheat";
            this.rbtn_nfsheat.Size = new System.Drawing.Size(154, 20);
            this.rbtn_nfsheat.TabIndex = 18;
            this.rbtn_nfsheat.TabStop = true;
            this.rbtn_nfsheat.Text = "Need for Speed Heat";
            this.rbtn_nfsheat.UseVisualStyleBackColor = true;
            this.rbtn_nfsheat.CheckedChanged += new System.EventHandler(this.rbtn_nfsheat_CheckedChanged);
            // 
            // rbtn_gw2
            // 
            this.rbtn_gw2.AutoSize = true;
            this.rbtn_gw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_gw2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_gw2.Location = new System.Drawing.Point(565, 121);
            this.rbtn_gw2.Name = "rbtn_gw2";
            this.rbtn_gw2.Size = new System.Drawing.Size(162, 20);
            this.rbtn_gw2.TabIndex = 19;
            this.rbtn_gw2.TabStop = true;
            this.rbtn_gw2.Text = "PvZ: Garden Warfare 2";
            this.rbtn_gw2.UseVisualStyleBackColor = true;
            this.rbtn_gw2.CheckedChanged += new System.EventHandler(this.rbtn_gw2_CheckedChanged);
            // 
            // rbtn_nfspayback
            // 
            this.rbtn_nfspayback.AutoSize = true;
            this.rbtn_nfspayback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_nfspayback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_nfspayback.Location = new System.Drawing.Point(326, 121);
            this.rbtn_nfspayback.Name = "rbtn_nfspayback";
            this.rbtn_nfspayback.Size = new System.Drawing.Size(179, 20);
            this.rbtn_nfspayback.TabIndex = 20;
            this.rbtn_nfspayback.TabStop = true;
            this.rbtn_nfspayback.Text = "Need for Speed Payback";
            this.rbtn_nfspayback.UseVisualStyleBackColor = true;
            this.rbtn_nfspayback.CheckedChanged += new System.EventHandler(this.rbtn_nfspayback_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_nfspayback);
            this.Controls.Add(this.rbtn_gw2);
            this.Controls.Add(this.rbtn_nfsheat);
            this.Controls.Add(this.rbtn_nfs);
            this.Controls.Add(this.btn_github);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtn_bf1);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.lbl_enabled);
            this.Controls.Add(this.btn_customchoose);
            this.Controls.Add(this.txtb_custompath);
            this.Controls.Add(this.rbtn_custom);
            this.Controls.Add(this.rbtn_mea);
            this.Controls.Add(this.rbtn_bf2017);
            this.Controls.Add(this.rbtn_bf2015);
            this.Controls.Add(this.btn_disable);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FrostyFix";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_enable;
        private System.Windows.Forms.Button btn_disable;
        private System.Windows.Forms.RadioButton rbtn_bf2015;
        private System.Windows.Forms.RadioButton rbtn_bf2017;
        private System.Windows.Forms.RadioButton rbtn_mea;
        private System.Windows.Forms.RadioButton rbtn_custom;
        private System.Windows.Forms.TextBox txtb_custompath;
        private System.Windows.Forms.Button btn_customchoose;
        private System.Windows.Forms.Label lbl_enabled;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.RadioButton rbtn_bf1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_github;
        private System.Windows.Forms.RadioButton rbtn_nfs;
        private System.Windows.Forms.RadioButton rbtn_nfsheat;
        private System.Windows.Forms.RadioButton rbtn_gw2;
        private System.Windows.Forms.RadioButton rbtn_nfspayback;
    }
}

