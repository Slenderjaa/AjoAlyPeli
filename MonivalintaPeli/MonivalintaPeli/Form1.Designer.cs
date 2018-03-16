namespace MonivalintaPeli
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
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.radioWrong2 = new System.Windows.Forms.RadioButton();
            this.radioWrong = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRightCounter = new System.Windows.Forms.Label();
            this.kuvaBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kuvaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(15, 199);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(85, 17);
            this.radioRight.TabIndex = 0;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "radioButton1";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // radioWrong2
            // 
            this.radioWrong2.AutoSize = true;
            this.radioWrong2.Location = new System.Drawing.Point(166, 199);
            this.radioWrong2.Name = "radioWrong2";
            this.radioWrong2.Size = new System.Drawing.Size(85, 17);
            this.radioWrong2.TabIndex = 1;
            this.radioWrong2.TabStop = true;
            this.radioWrong2.Text = "radioButton2";
            this.radioWrong2.UseVisualStyleBackColor = true;
            // 
            // radioWrong
            // 
            this.radioWrong.AutoSize = true;
            this.radioWrong.Location = new System.Drawing.Point(339, 199);
            this.radioWrong.Name = "radioWrong";
            this.radioWrong.Size = new System.Drawing.Size(85, 17);
            this.radioWrong.TabIndex = 2;
            this.radioWrong.TabStop = true;
            this.radioWrong.Text = "radioButton3";
            this.radioWrong.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRightCounter
            // 
            this.lblRightCounter.AutoSize = true;
            this.lblRightCounter.Location = new System.Drawing.Point(12, 9);
            this.lblRightCounter.Name = "lblRightCounter";
            this.lblRightCounter.Size = new System.Drawing.Size(96, 13);
            this.lblRightCounter.TabIndex = 4;
            this.lblRightCounter.Text = "Oikeat vastaukset:";
            // 
            // kuvaBox
            // 
            this.kuvaBox.Location = new System.Drawing.Point(114, 31);
            this.kuvaBox.Name = "kuvaBox";
            this.kuvaBox.Size = new System.Drawing.Size(211, 142);
            this.kuvaBox.TabIndex = 6;
            this.kuvaBox.TabStop = false;
            this.kuvaBox.Click += new System.EventHandler(this.kuvaBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 385);
            this.Controls.Add(this.kuvaBox);
            this.Controls.Add(this.lblRightCounter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioWrong);
            this.Controls.Add(this.radioWrong2);
            this.Controls.Add(this.radioRight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kuvaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioWrong2;
        private System.Windows.Forms.RadioButton radioWrong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRightCounter;
        private System.Windows.Forms.PictureBox kuvaBox;
    }
}

