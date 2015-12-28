namespace FallasI
{
    partial class InitialScreen
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
            this.IntroduceData = new System.Windows.Forms.Button();
            this.Simulate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntroduceData
            // 
            this.IntroduceData.Location = new System.Drawing.Point(447, 46);
            this.IntroduceData.Name = "IntroduceData";
            this.IntroduceData.Size = new System.Drawing.Size(120, 30);
            this.IntroduceData.TabIndex = 0;
            this.IntroduceData.Text = "Introduce Data";
            this.IntroduceData.UseVisualStyleBackColor = true;
            this.IntroduceData.Click += new System.EventHandler(this.IntroduceData_Click);
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(447, 101);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(120, 30);
            this.Simulate.TabIndex = 1;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(447, 166);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 30);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FallasI.Properties.Resources.servicio;
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.IntroduceData);
            this.Name = "PantallaInicio";
            this.Text = "Serve Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IntroduceData;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.Button Exit;
    }
}

