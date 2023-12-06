namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.miniconsole = new System.Windows.Forms.TextBox();
            this.triestextbox = new System.Windows.Forms.TextBox();
            this.holdtextbox = new System.Windows.Forms.TextBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.SLOT1HOLD = new System.Windows.Forms.Button();
            this.slot2HOLD = new System.Windows.Forms.Button();
            this.slot3HOLD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // miniconsole
            // 
            this.miniconsole.Location = new System.Drawing.Point(74, 351);
            this.miniconsole.Name = "miniconsole";
            this.miniconsole.Size = new System.Drawing.Size(100, 20);
            this.miniconsole.TabIndex = 5;
            // 
            // triestextbox
            // 
            this.triestextbox.Location = new System.Drawing.Point(74, 395);
            this.triestextbox.Name = "triestextbox";
            this.triestextbox.Size = new System.Drawing.Size(100, 20);
            this.triestextbox.TabIndex = 6;
            this.triestextbox.Text = "5";
            // 
            // holdtextbox
            // 
            this.holdtextbox.Location = new System.Drawing.Point(74, 441);
            this.holdtextbox.Name = "holdtextbox";
            this.holdtextbox.Size = new System.Drawing.Size(100, 20);
            this.holdtextbox.TabIndex = 7;
            // 
            // slot3
            // 
            this.slot3.Location = new System.Drawing.Point(488, 174);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(118, 120);
            this.slot3.TabIndex = 3;
            this.slot3.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.Location = new System.Drawing.Point(283, 174);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(118, 120);
            this.slot2.TabIndex = 2;
            this.slot2.TabStop = false;
            // 
            // slot1
            // 
            this.slot1.Location = new System.Drawing.Point(74, 174);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(118, 120);
            this.slot1.TabIndex = 1;
            this.slot1.TabStop = false;
            // 
            // background
            // 
            this.background.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tablebackground1;
            this.background.Location = new System.Drawing.Point(0, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(723, 506);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // SLOT1HOLD
            // 
            this.SLOT1HOLD.Location = new System.Drawing.Point(99, 126);
            this.SLOT1HOLD.Name = "SLOT1HOLD";
            this.SLOT1HOLD.Size = new System.Drawing.Size(75, 23);
            this.SLOT1HOLD.TabIndex = 8;
            this.SLOT1HOLD.Text = "HOLD";
            this.SLOT1HOLD.UseVisualStyleBackColor = true;
            // 
            // slot2HOLD
            // 
            this.slot2HOLD.Location = new System.Drawing.Point(305, 126);
            this.slot2HOLD.Name = "slot2HOLD";
            this.slot2HOLD.Size = new System.Drawing.Size(75, 23);
            this.slot2HOLD.TabIndex = 9;
            this.slot2HOLD.Text = "HOLD";
            this.slot2HOLD.UseVisualStyleBackColor = true;
            // 
            // slot3HOLD
            // 
            this.slot3HOLD.Location = new System.Drawing.Point(515, 126);
            this.slot3HOLD.Name = "slot3HOLD";
            this.slot3HOLD.Size = new System.Drawing.Size(75, 23);
            this.slot3HOLD.TabIndex = 10;
            this.slot3HOLD.Text = "HOLD";
            this.slot3HOLD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 501);
            this.Controls.Add(this.slot3HOLD);
            this.Controls.Add(this.slot2HOLD);
            this.Controls.Add(this.SLOT1HOLD);
            this.Controls.Add(this.holdtextbox);
            this.Controls.Add(this.triestextbox);
            this.Controls.Add(this.miniconsole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox miniconsole;
        private System.Windows.Forms.TextBox triestextbox;
        private System.Windows.Forms.TextBox holdtextbox;
        private System.Windows.Forms.Button SLOT1HOLD;
        private System.Windows.Forms.Button slot2HOLD;
        private System.Windows.Forms.Button slot3HOLD;
    }
}

