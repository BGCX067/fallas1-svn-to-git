namespace FallasI
{
    partial class Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Receptor = new System.Windows.Forms.PictureBox();
            this.Server = new System.Windows.Forms.PictureBox();
            this.Pique = new System.Windows.Forms.PictureBox();
            this.lblserverpower = new System.Windows.Forms.Label();
            this.lblservereffect = new System.Windows.Forms.Label();
            this.lblserverdirection = new System.Windows.Forms.Label();
            this.lblserverhilt = new System.Windows.Forms.Label();
            this.lblserverhilttype = new System.Windows.Forms.Label();
            this.lblservershottype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Receptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pique)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::FallasI.Properties.Resources.tennisBall;
            this.Ball.Location = new System.Drawing.Point(344, 252);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(33, 32);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // Receptor
            // 
            this.Receptor.BackColor = System.Drawing.Color.Transparent;
            this.Receptor.Image = ((System.Drawing.Image)(resources.GetObject("Receptor.Image")));
            this.Receptor.Location = new System.Drawing.Point(22, 239);
            this.Receptor.Name = "Receptor";
            this.Receptor.Size = new System.Drawing.Size(62, 62);
            this.Receptor.TabIndex = 1;
            this.Receptor.TabStop = false;
            // 
            // Server
            // 
            this.Server.Image = global::FallasI.Properties.Resources.dereha;
            this.Server.Location = new System.Drawing.Point(744, 252);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(66, 71);
            this.Server.TabIndex = 2;
            this.Server.TabStop = false;
            // 
            // Pique
            // 
            this.Pique.BackColor = System.Drawing.Color.Transparent;
            this.Pique.Image = global::FallasI.Properties.Resources.cross;
            this.Pique.Location = new System.Drawing.Point(247, 279);
            this.Pique.Name = "Pique";
            this.Pique.Size = new System.Drawing.Size(22, 22);
            this.Pique.TabIndex = 3;
            this.Pique.TabStop = false;
            this.Pique.Visible = false;
            // 
            // lblserverpower
            // 
            this.lblserverpower.AutoSize = true;
            this.lblserverpower.Location = new System.Drawing.Point(751, 80);
            this.lblserverpower.Name = "lblserverpower";
            this.lblserverpower.Size = new System.Drawing.Size(35, 13);
            this.lblserverpower.TabIndex = 4;
            this.lblserverpower.Text = "label1";
            // 
            // lblservereffect
            // 
            this.lblservereffect.AutoSize = true;
            this.lblservereffect.Location = new System.Drawing.Point(751, 112);
            this.lblservereffect.Name = "lblservereffect";
            this.lblservereffect.Size = new System.Drawing.Size(35, 13);
            this.lblservereffect.TabIndex = 5;
            this.lblservereffect.Text = "label2";
            // 
            // lblserverdirection
            // 
            this.lblserverdirection.AutoSize = true;
            this.lblserverdirection.Location = new System.Drawing.Point(751, 135);
            this.lblserverdirection.Name = "lblserverdirection";
            this.lblserverdirection.Size = new System.Drawing.Size(35, 13);
            this.lblserverdirection.TabIndex = 6;
            this.lblserverdirection.Text = "label1";
            // 
            // lblserverhilt
            // 
            this.lblserverhilt.AutoSize = true;
            this.lblserverhilt.Location = new System.Drawing.Point(751, 161);
            this.lblserverhilt.Name = "lblserverhilt";
            this.lblserverhilt.Size = new System.Drawing.Size(35, 13);
            this.lblserverhilt.TabIndex = 7;
            this.lblserverhilt.Text = "label1";
            // 
            // lblserverhilttype
            // 
            this.lblserverhilttype.AutoSize = true;
            this.lblserverhilttype.Location = new System.Drawing.Point(751, 193);
            this.lblserverhilttype.Name = "lblserverhilttype";
            this.lblserverhilttype.Size = new System.Drawing.Size(35, 13);
            this.lblserverhilttype.TabIndex = 8;
            this.lblserverhilttype.Text = "label1";
            // 
            // lblservershottype
            // 
            this.lblservershottype.AutoSize = true;
            this.lblservershottype.Location = new System.Drawing.Point(751, 227);
            this.lblservershottype.Name = "lblservershottype";
            this.lblservershottype.Size = new System.Drawing.Size(35, 13);
            this.lblservershottype.TabIndex = 9;
            this.lblservershottype.Text = "label1";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FallasI.Properties.Resources.tennis_court;
            this.ClientSize = new System.Drawing.Size(869, 455);
            this.Controls.Add(this.lblservershottype);
            this.Controls.Add(this.lblserverhilttype);
            this.Controls.Add(this.lblserverhilt);
            this.Controls.Add(this.lblserverdirection);
            this.Controls.Add(this.lblservereffect);
            this.Controls.Add(this.lblserverpower);
            this.Controls.Add(this.Pique);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.Receptor);
            this.Controls.Add(this.Ball);
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "Simulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Receptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Receptor;
        private System.Windows.Forms.PictureBox Server;
        private System.Windows.Forms.PictureBox Pique;
        private System.Windows.Forms.Label lblserverpower;
        private System.Windows.Forms.Label lblservereffect;
        private System.Windows.Forms.Label lblserverdirection;
        private System.Windows.Forms.Label lblserverhilt;
        private System.Windows.Forms.Label lblserverhilttype;
        private System.Windows.Forms.Label lblservershottype;
    }
}