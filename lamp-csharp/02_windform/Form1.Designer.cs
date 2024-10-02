namespace _02_windform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            accendi = new Button();
            spegni = new Button();
            pictureBoxOFF = new PictureBox();
            pictureBoxON = new PictureBox();
            up = new Button();
            down = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOFF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxON).BeginInit();
            SuspendLayout();
            // 
            // accendi
            // 
            accendi.Location = new Point(12, 22);
            accendi.Name = "accendi";
            accendi.Size = new Size(145, 58);
            accendi.TabIndex = 0;
            accendi.Text = "ACCENDI";
            accendi.UseVisualStyleBackColor = true;
            accendi.Click += accendi_Click;
            // 
            // spegni
            // 
            spegni.Location = new Point(12, 97);
            spegni.Name = "spegni";
            spegni.Size = new Size(145, 58);
            spegni.TabIndex = 1;
            spegni.Text = "SPEGNI";
            spegni.UseVisualStyleBackColor = true;
            spegni.Click += spegni_Click;
            // 
            // pictureBoxOFF
            // 
            pictureBoxOFF.ErrorImage = (Image)resources.GetObject("pictureBoxOFF.ErrorImage");
            pictureBoxOFF.Image = (Image)resources.GetObject("pictureBoxOFF.Image");
            pictureBoxOFF.InitialImage = (Image)resources.GetObject("pictureBoxOFF.InitialImage");
            pictureBoxOFF.Location = new Point(358, 166);
            pictureBoxOFF.Name = "pictureBoxOFF";
            pictureBoxOFF.Size = new Size(80, 146);
            pictureBoxOFF.TabIndex = 3;
            pictureBoxOFF.TabStop = false;
            // 
            // pictureBoxON
            // 
            pictureBoxON.Image = (Image)resources.GetObject("pictureBoxON.Image");
            pictureBoxON.Location = new Point(358, 166);
            pictureBoxON.Name = "pictureBoxON";
            pictureBoxON.Size = new Size(80, 146);
            pictureBoxON.TabIndex = 4;
            pictureBoxON.TabStop = false;
            // 
            // up
            // 
            up.BackColor = SystemColors.ActiveCaption;
            up.Location = new Point(713, 22);
            up.Name = "up";
            up.Size = new Size(75, 23);
            up.TabIndex = 5;
            up.Text = "UP";
            up.UseVisualStyleBackColor = false;
            up.Click += up_Click;
            // 
            // down
            // 
            down.BackColor = Color.RosyBrown;
            down.Location = new Point(713, 57);
            down.Name = "down";
            down.Size = new Size(75, 23);
            down.TabIndex = 6;
            down.Text = "DOWN";
            down.UseVisualStyleBackColor = false;
            down.Click += down_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(down);
            Controls.Add(up);
            Controls.Add(pictureBoxOFF);
            Controls.Add(spegni);
            Controls.Add(accendi);
            Controls.Add(pictureBoxON);
            Name = "Form1";
            Text = "LAMP";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOFF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxON).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button accendi;
        private Button spegni;
        private PictureBox pictureBoxOFF;
        private PictureBox pictureBoxON;
        private Button up;
        private Button down;
    }
}
