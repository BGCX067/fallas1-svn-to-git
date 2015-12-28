namespace FallasI.Src
{
    partial class IntroduceData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSurfaceType = new System.Windows.Forms.ComboBox();
            this.cmbReceptorPositionY = new System.Windows.Forms.ComboBox();
            this.cmbReceptorPositionX = new System.Windows.Forms.ComboBox();
            this.cmbReceptorType = new System.Windows.Forms.ComboBox();
            this.cmbReceptorHeight = new System.Windows.Forms.ComboBox();
            this.cmbServerHeight = new System.Windows.Forms.ComboBox();
            this.cmbServerType = new System.Windows.Forms.ComboBox();
            this.cmbGameSurface = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSurfaceType);
            this.panel1.Controls.Add(this.cmbReceptorPositionY);
            this.panel1.Controls.Add(this.cmbReceptorPositionX);
            this.panel1.Controls.Add(this.cmbReceptorType);
            this.panel1.Controls.Add(this.cmbReceptorHeight);
            this.panel1.Controls.Add(this.cmbServerHeight);
            this.panel1.Controls.Add(this.cmbServerType);
            this.panel1.Controls.Add(this.cmbGameSurface);
            this.panel1.Location = new System.Drawing.Point(336, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 212);
            this.panel1.TabIndex = 1;
            // 
            // cmbSurfaceType
            // 
            this.cmbSurfaceType.FormattingEnabled = true;
            this.cmbSurfaceType.Items.AddRange(new object[] {
            "Indoor",
            "Outdoor"});
            this.cmbSurfaceType.Location = new System.Drawing.Point(-1, 0);
            this.cmbSurfaceType.Name = "cmbSurfaceType";
            this.cmbSurfaceType.Size = new System.Drawing.Size(187, 21);
            this.cmbSurfaceType.TabIndex = 10;
            // 
            // cmbReceptorPositionY
            // 
            this.cmbReceptorPositionY.FormattingEnabled = true;
            this.cmbReceptorPositionY.Items.AddRange(new object[] {
            "Border Line",
            "Middle",
            "Far"});
            this.cmbReceptorPositionY.Location = new System.Drawing.Point(0, 189);
            this.cmbReceptorPositionY.Name = "cmbReceptorPositionY";
            this.cmbReceptorPositionY.Size = new System.Drawing.Size(186, 21);
            this.cmbReceptorPositionY.TabIndex = 9;
            this.cmbReceptorPositionY.SelectedIndexChanged += new System.EventHandler(this.cmbReceptorPositionY_SelectedIndexChanged);
            // 
            // cmbReceptorPositionX
            // 
            this.cmbReceptorPositionX.FormattingEnabled = true;
            this.cmbReceptorPositionX.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.cmbReceptorPositionX.Location = new System.Drawing.Point(0, 162);
            this.cmbReceptorPositionX.Name = "cmbReceptorPositionX";
            this.cmbReceptorPositionX.Size = new System.Drawing.Size(187, 21);
            this.cmbReceptorPositionX.TabIndex = 8;
            // 
            // cmbReceptorType
            // 
            this.cmbReceptorType.FormattingEnabled = true;
            this.cmbReceptorType.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cmbReceptorType.Location = new System.Drawing.Point(-1, 135);
            this.cmbReceptorType.Name = "cmbReceptorType";
            this.cmbReceptorType.Size = new System.Drawing.Size(187, 21);
            this.cmbReceptorType.TabIndex = 7;
            // 
            // cmbReceptorHeight
            // 
            this.cmbReceptorHeight.FormattingEnabled = true;
            this.cmbReceptorHeight.Items.AddRange(new object[] {
            "Tall",
            "Average",
            "Short"});
            this.cmbReceptorHeight.Location = new System.Drawing.Point(-2, 108);
            this.cmbReceptorHeight.Name = "cmbReceptorHeight";
            this.cmbReceptorHeight.Size = new System.Drawing.Size(188, 21);
            this.cmbReceptorHeight.TabIndex = 6;
            // 
            // cmbServerHeight
            // 
            this.cmbServerHeight.FormattingEnabled = true;
            this.cmbServerHeight.Items.AddRange(new object[] {
            "Tall",
            "Average",
            "Short"});
            this.cmbServerHeight.Location = new System.Drawing.Point(0, 81);
            this.cmbServerHeight.Name = "cmbServerHeight";
            this.cmbServerHeight.Size = new System.Drawing.Size(186, 21);
            this.cmbServerHeight.TabIndex = 4;
            // 
            // cmbServerType
            // 
            this.cmbServerType.FormattingEnabled = true;
            this.cmbServerType.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cmbServerType.Location = new System.Drawing.Point(0, 54);
            this.cmbServerType.Name = "cmbServerType";
            this.cmbServerType.Size = new System.Drawing.Size(186, 21);
            this.cmbServerType.TabIndex = 3;
            // 
            // cmbGameSurface
            // 
            this.cmbGameSurface.FormattingEnabled = true;
            this.cmbGameSurface.Items.AddRange(new object[] {
            "Clay",
            "Concrete",
            "Grass",
            "Synthetic Fast",
            "Synthetic Very Fast"});
            this.cmbGameSurface.Location = new System.Drawing.Point(0, 27);
            this.cmbGameSurface.Name = "cmbGameSurface";
            this.cmbGameSurface.Size = new System.Drawing.Size(186, 21);
            this.cmbGameSurface.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(139, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 212);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Game Surface Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Receptor Position Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Receptor Position X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Receptor Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Receptor Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Server Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Server Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game Surface";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(261, 319);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 30);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // IntroduceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FallasI.Properties.Resources.tennis_img;
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IntroduceData";
            this.Text = "IntroduceData";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox cmbGameSurface;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbServerHeight;
        private System.Windows.Forms.ComboBox cmbServerType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbReceptorHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbReceptorType;
        private System.Windows.Forms.ComboBox cmbReceptorPositionX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbReceptorPositionY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSurfaceType;







    }
}