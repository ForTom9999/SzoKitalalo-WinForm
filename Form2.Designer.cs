namespace Akasztófa_WinForm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BBtn = new System.Windows.Forms.Button();
            this.SecretLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lifelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BBtn
            // 
            resources.ApplyResources(this.BBtn, "BBtn");
            this.BBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BBtn.Name = "BBtn";
            this.BBtn.UseVisualStyleBackColor = false;
            this.BBtn.Click += new System.EventHandler(this.BBtn_Click);
            // 
            // SecretLbl
            // 
            resources.ApplyResources(this.SecretLbl, "SecretLbl");
            this.SecretLbl.AutoEllipsis = true;
            this.SecretLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SecretLbl.Name = "SecretLbl";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lifelbl
            // 
            resources.ApplyResources(this.lifelbl, "lifelbl");
            this.lifelbl.Name = "lifelbl";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.lifelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecretLbl);
            this.Controls.Add(this.BBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button BBtn;
        private Label SecretLbl;
        private Label label3;
        private Label lifelbl;
    }
}