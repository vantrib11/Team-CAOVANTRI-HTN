namespace UI_CONTROOL
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
            this.bt_Stop = new System.Windows.Forms.Button();
            this.bt_L = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_F = new System.Windows.Forms.Button();
            this.bt_R = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(417, 142);
            this.bt_Stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(64, 19);
            this.bt_Stop.TabIndex = 0;
            this.bt_Stop.Text = "STOP";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // bt_L
            // 
            this.bt_L.Location = new System.Drawing.Point(338, 142);
            this.bt_L.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_L.Name = "bt_L";
            this.bt_L.Size = new System.Drawing.Size(56, 19);
            this.bt_L.TabIndex = 1;
            this.bt_L.Text = "LEFT";
            this.bt_L.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 187);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 19);
            this.button3.TabIndex = 2;
            this.button3.Text = "BACKWARD";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_F
            // 
            this.bt_F.Location = new System.Drawing.Point(417, 102);
            this.bt_F.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_F.Name = "bt_F";
            this.bt_F.Size = new System.Drawing.Size(64, 19);
            this.bt_F.TabIndex = 3;
            this.bt_F.Text = "FORWARD";
            this.bt_F.UseVisualStyleBackColor = true;
            // 
            // bt_R
            // 
            this.bt_R.Location = new System.Drawing.Point(492, 142);
            this.bt_R.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_R.Name = "bt_R";
            this.bt_R.Size = new System.Drawing.Size(56, 19);
            this.bt_R.TabIndex = 4;
            this.bt_R.Text = "RIGHT";
            this.bt_R.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 366);
            this.Controls.Add(this.bt_R);
            this.Controls.Add(this.bt_F);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_L);
            this.Controls.Add(this.bt_Stop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.Button bt_L;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_F;
        private System.Windows.Forms.Button bt_R;
    }
}

