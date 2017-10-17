namespace ifModule2
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
            this.colorLabel = new System.Windows.Forms.Label();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.colorInput = new System.Windows.Forms.TextBox();
            this.shapeInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colorLabel.Location = new System.Drawing.Point(26, 40);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(251, 23);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Enter R for Red, or Enter G for Green";
            // 
            // shapeLabel
            // 
            this.shapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shapeLabel.Location = new System.Drawing.Point(26, 91);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(284, 23);
            this.shapeLabel.TabIndex = 1;
            this.shapeLabel.Text = "Enter C for Circle, or Enter R for Rectangle";
            // 
            // colorInput
            // 
            this.colorInput.Location = new System.Drawing.Point(339, 39);
            this.colorInput.Name = "colorInput";
            this.colorInput.Size = new System.Drawing.Size(84, 20);
            this.colorInput.TabIndex = 0;
            // 
            // shapeInput
            // 
            this.shapeInput.Location = new System.Drawing.Point(339, 90);
            this.shapeInput.Name = "shapeInput";
            this.shapeInput.Size = new System.Drawing.Size(84, 20);
            this.shapeInput.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Silver;
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterButton.Location = new System.Drawing.Point(339, 154);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(84, 36);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.shapeInput);
            this.Controls.Add(this.colorInput);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.colorLabel);
            this.Name = "Form1";
            this.Text = "if Statement 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.TextBox colorInput;
        private System.Windows.Forms.TextBox shapeInput;
        private System.Windows.Forms.Button enterButton;
    }
}

