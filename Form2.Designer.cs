namespace FrostyFix {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_restartEA = new System.Windows.Forms.Button();
            this.btn_restartOrigin = new System.Windows.Forms.Button();
            this.btn_restartPC = new System.Windows.Forms.Button();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_restartEA
            // 
            this.btn_restartEA.Location = new System.Drawing.Point(145, 75);
            this.btn_restartEA.Name = "btn_restartEA";
            this.btn_restartEA.Size = new System.Drawing.Size(155, 33);
            this.btn_restartEA.TabIndex = 0;
            this.btn_restartEA.Text = "Restart EA Desktop";
            this.btn_restartEA.UseVisualStyleBackColor = true;
            this.btn_restartEA.Click += new System.EventHandler(this.btn_restartEA_Click);
            // 
            // btn_restartOrigin
            // 
            this.btn_restartOrigin.Location = new System.Drawing.Point(145, 114);
            this.btn_restartOrigin.Name = "btn_restartOrigin";
            this.btn_restartOrigin.Size = new System.Drawing.Size(155, 33);
            this.btn_restartOrigin.TabIndex = 1;
            this.btn_restartOrigin.Text = "Restart Origin";
            this.btn_restartOrigin.UseVisualStyleBackColor = true;
            this.btn_restartOrigin.Click += new System.EventHandler(this.btn_restartOrigin_Click);
            // 
            // btn_restartPC
            // 
            this.btn_restartPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restartPC.ForeColor = System.Drawing.Color.Red;
            this.btn_restartPC.Location = new System.Drawing.Point(145, 153);
            this.btn_restartPC.Name = "btn_restartPC";
            this.btn_restartPC.Size = new System.Drawing.Size(155, 33);
            this.btn_restartPC.TabIndex = 2;
            this.btn_restartPC.Text = "Restart PC";
            this.btn_restartPC.UseVisualStyleBackColor = true;
            this.btn_restartPC.Click += new System.EventHandler(this.btn_restartPC_Click);
            // 
            // lbl_title2
            // 
            this.lbl_title2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_title2.Location = new System.Drawing.Point(0, 0);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(445, 69);
            this.lbl_title2.TabIndex = 3;
            this.lbl_title2.Text = "After Patch Options";
            this.lbl_title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(445, 227);
            this.Controls.Add(this.lbl_title2);
            this.Controls.Add(this.btn_restartPC);
            this.Controls.Add(this.btn_restartOrigin);
            this.Controls.Add(this.btn_restartEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "FrostyFix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_restartEA;
        private System.Windows.Forms.Button btn_restartOrigin;
        private System.Windows.Forms.Button btn_restartPC;
        private System.Windows.Forms.Label lbl_title2;
    }
}